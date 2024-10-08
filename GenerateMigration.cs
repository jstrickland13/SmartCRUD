// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;

namespace DownEastDev.Data
{
    public class MigrationGenerator
    {

        public string GenerateFullMigration(string connectionString, string @namespace, int id)
        {
            using (SqlConnection mssql = new SqlConnection(connectionString))
            {
                string[] tableNames = TableNames(mssql);
                List<string> buffer = new List<string>();

                buffer.Add($"using FluentMigrator;");
                buffer.Add($"namespace {@namespace}");
                buffer.Add($"{{");
                buffer.Add($"  [Migration({id})]");
                buffer.Add($"  public class CreateAccount : Migration");
                buffer.Add($"  {{");
                buffer.Add($"    public override void Up()");
                buffer.Add($"    {{");

                foreach (string tableName in tableNames)
                {
                    buffer.AddRange(GetTableMigration(mssql, tableName, 3));
                }

                buffer.Add($"    }}");
                buffer.Add($"    public override void Up()");
                buffer.Add($"    {{");
                
                for (int i = 0; i < tableNames.Length; i++)
                {
                    buffer.Add($"      Delete.Table(\"{tableNames[i]}\");");
                }
                
                buffer.Add($"    }}");
                buffer.Add($"  }}");
                buffer.Add($"}}");

                return String.Join("\n",buffer);
            }
        }

        public string[] TableNames(SqlConnection mssql)
        {
            using (var da = new SqlDataAdapter("select table_name from information_schema.tables where table_type = 'BASE TABLE'", mssql))
            {
                DataTable table = new DataTable();
                da.Fill(table);
                return table.Rows.Cast<DataRow>().Where(m => m["table_name"].ToString() != "dtproperties").Select(m => m["table_name"].ToString()).OrderBy(m => m).ToArray();
            }
        }
        public List<string> GetTableMigration(SqlConnection mssql, string tablename, int tabs)
        {
            using (var da = new SqlDataAdapter($"select * from {tablename}", mssql))
            {
                List<string> mig = new List<string>();

                DataTable table = new DataTable(tablename);
                da.FillSchema(table, SchemaType.Source);

                mig.Add($"Create.Table(\"{table.TableName}\")");
                foreach (DataColumn col in table.Columns)
                {
                    string datatype = col.DataType.Name;
                    switch (datatype)
                    {
                        case "Byte[]":
                            datatype = "Binary";
                            break;
                        case "Single":
                            datatype = "Decimal";
                            break;
                        default:
                            break;
                    }
                    string l = col.DataType.Name == "String" ? col.MaxLength.ToString() : "";
                    mig.Add($"\t.WithColumn(\"{col.ColumnName.ToLower()}\").As{datatype}({l})");
                    if (!col.AllowDBNull)
                        mig[mig.Count - 1] += ".NotNullable()";
                    else
                        mig[mig.Count - 1] += ".Nullable()";

                    if (table.PrimaryKey.Contains(col)) mig[mig.Count - 1] += ".PrimaryKey()";

                }
                mig[mig.Count - 1] += ";";
                mig.Add("");

                for (int i = 0; i < tabs; i++)
                {
                    for (int j = 0; j < mig.Count; j++)
                    {
                        mig[j] = "  " + mig[j];
                    }
                }

                return mig;
            }
        }
    }
}