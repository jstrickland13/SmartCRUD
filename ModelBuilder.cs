using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SmartCRUD
{
    public class ModelBuilder
    {
        public string ConnectionString { get; set; }
        public ModelBuilder(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IList<string> BuildOwner(string owner, string[] tablenames = null)
        {
            var list = new List<string>();
            list.Add($"using System;");
            list.Add($"using System.Linq;");
            list.Add($"using System.ComponentModel.DataAnnotations;");
            list.Add($"using System.ComponentModel.DataAnnotations.Schema;");
            list.Add($"");
            list.Add($"namespace {owner}");
            list.Add($"{{");

            if (tablenames == null)
            {
                using (var db = new OracleConnection(ConnectionString))
                {
                    tablenames = db.Query("select table_name from all_tables where owner=:owner", new { owner = owner })
                                   .Select(t => (string)t.TABLE_NAME).OrderBy(m => m).ToArray();
                }
            }

            int count = tablenames.Length;
            foreach (var tablename in tablenames)
            {
                list = list.Concat(BuildClass(owner, tablename)).ToList();
                Console.WriteLine($"{count} of {tablenames.Length} : {tablename}");
                count--;
            }
            list.Add($"}}");

            return list;
        }
        public IList<string> BuildClass(string owner, string tablename)
        {
            var list = new List<string>();
            list.Add($"    [Table(\"{tablename}\", Schema = \"{owner}\")]");
            list.Add($"    public partial class {tablename.Replace("$", "")}");
            list.Add($"    {{");

            string sql = String.Empty;
            if (!String.IsNullOrEmpty(owner))
                sql = $"SELECT * FROM \"{owner}\".\"{tablename}\"";
            else
                sql = $"SELECT * FROM \"{tablename}\"";

            using (var da = new OracleDataAdapter(sql, ConnectionString))
            {
                DataTable table = new DataTable();
                da.FillSchema(table, SchemaType.Source);

                var keys = table.PrimaryKey.Cast<DataColumn>().Select(col => col.ColumnName);
                foreach (var col in table.Columns.Cast<DataColumn>())
                {
                    if (keys.Contains(col.ColumnName))
                    {
                        list.Add($"        [Key]");
                    }

                    var isNullable = col.DataType.IsValueType && col.AllowDBNull ? "?" : "";
                    var colName = col.ColumnName;

                    #region columnName fixes
                    if (colName.Contains("#"))
                    {
                        colName = colName.Replace("#", "_");
                    }
                    if (colName.Contains("$"))
                    {
                        colName = colName.Replace("$", "_");
                    }
                    if (colName == tablename)
                    {
                        colName = colName + "_val";
                    }
                    #endregion columnName fixes

                    if (colName != col.ColumnName)
                    {
                        list.Add($"        [Column(\"{col.ColumnName}\")]");
                    }
                    list.Add($"        public {col.DataType}{isNullable} {colName} {{ get; set; }}");
                }
            }
            list.Add($"    }}");

            return list;
        }
    }
}
