using System.Data;
using Microsoft.Data.SqlClient;

namespace DownEastDev.Data
{
    public class SqlModelGenerator
    {
        protected string _namespace;
        protected SqlConnection _connection;

        public SqlModelGenerator(string @namespace, SqlConnection connection)
        {
            _namespace = @namespace;
            _connection = connection;
        }

        public List<String> GenerateNamespace(bool explicitKeys = false)
        {
            List<string> strings = new List<string>();
            strings.Add("using System;");
            strings.Add("using System.ComponentModel.DataAnnotations;");
            strings.Add("using System.ComponentModel.DataAnnotations.Schema;");
            strings.Add("");
            strings.Add($"namespace {_namespace}");
            strings.Add("{");

            var tablenames = GetTableNames();
            foreach (var name in tablenames)
            {
                strings.AddRange(GenerateClass(name, explicitKeys).Select(l => "\t" + l));
            }
            strings.Add("}");

            Console.WriteLine(String.Join("\n", strings));

            return strings;
        }

        public List<string> GenerateClassForQuery(string name, string query)
        {
            Console.WriteLine(query);

            List<string> strings = new List<string>();
            strings.Add($"[Table(\"{name}\")]");
            strings.Add($"public partial class {name}");
            strings.Add("{");
            strings.Add($"\tpublic {name}()");
            strings.Add("\t{}");
            strings.Add("");

            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.FillSchema(table, SchemaType.Source);

            foreach (DataColumn column in table.Columns)
            {
                var list = GenerateProperty(table, column);
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = "\t" + list[i];
                }
                strings.AddRange(list);
                strings.Add("");
            }

            strings.Add("}");
            return strings;
        }

        protected List<string> GenerateClass(string tableName, bool explicitKeys = false)
        {
            Console.WriteLine(tableName);

            List<string> strings = new List<string>();
            strings.Add($"[Table(\"{tableName}\")]");
            strings.Add($"public partial class {tableName}");
            strings.Add("{");
            strings.Add($"\tpublic {tableName}()");
            strings.Add("\t{}");
            strings.Add("");

            SqlDataAdapter adapter = new SqlDataAdapter($"select top 1 * from {tableName}", _connection);
            DataTable table = new DataTable();
            adapter.FillSchema(table, SchemaType.Source);

            foreach (DataColumn column in table.Columns)
            {
                var list = GenerateProperty(table, column, explicitKeys);
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = "\t" + list[i];
                }
                strings.AddRange(list);
                strings.Add("");
            }

            strings.Add("}");



            return strings;
        }
        protected List<string> GenerateProperty(DataTable table, DataColumn column, bool explicitKeys = false)
        {
            List<string> strings = new List<string>();

            if (table.PrimaryKey.Contains(column))
            {
                if (!explicitKeys)
                    strings.Add($"[Key]");
                else
                    strings.Add($"[Dapper.Contrib.Extensions.ExplicitKey]");
            }

            string huh = column.AllowDBNull && column.DataType != typeof(string) ? "?" : "";
            strings.Add($"[Column(\"{column.ColumnName}\")]");
            strings.Add($"public {column.DataType}{huh} {column.ColumnName} {{ get; set; }}");

            return strings;
        }
        protected List<string?>? GetTableNames()
        {
            var SQL = "SELECT * "
                    + " FROM INFORMATION_SCHEMA.TABLES "
                    + " WHERE TABLE_TYPE='BASE TABLE' "
                    + "   AND TABLE_NAME NOT IN ( 'TABLES' ) "
                    + " order BY TABLE_NAME";

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            var list = table.Rows.Cast<DataRow>().Select(m => m["TABLE_NAME"].ToString()).ToList();
            return list;
        }
    }
}
