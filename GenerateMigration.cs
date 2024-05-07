// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DownEast.ActiveRecord
{
    public class MigrationGenerator
    {

        public string GenerateFullMigration(string connectionString)
        {
            using (SqlConnection mssql = new SqlConnection(connectionString))
            {
                string[] tableNames = TableNames(mssql);

                List<string> buffer = new List<string>();

                foreach (string tableName in tableNames)
                {
                    buffer.AddRange(GetTableMigration(mssql, tableName));
                }

                for (int i = 0; i < buffer.Count; i++)
                    buffer[i] = "\t\t\t" + buffer[i];

                for (int i = 0; i < buffer.Count; i++)
                    Console.WriteLine(buffer[i]);

                string s = File.ReadAllText("../../../template.cs.txt");
                s = s.Replace("{{namespace}}", "crm").Replace("{{body}}", string.Join("\n", buffer));

                buffer = new List<string>();
                for (int i = 0; i < tableNames.Length; i++)
                {
                    buffer.Add($"\t\t\tDelete.Table(\"{tableNames[i]}\");");
                }

                s = s.Replace("{{downbody}}", string.Join("\n", buffer));

                return s;
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
        public List<string> GetTableMigration(SqlConnection mssql, string tablename)
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

                return mig;
            }
        }
    }
}