using Dapper;
using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCRUD
{
    public class SmartCRUD
    {
        Type Type { get; set; }
        PropertyInfo[] properties { get { return this.Type.GetProperties(); } }

        public string EncapPrefix { get; set; }
        public string EncapSuffix { get; set; }
        public string VariablePrefix { get; set; }

        public SmartCRUD(string typeName)
        {
            this.Type = Type.GetType(typeName);
            this.EncapPrefix = "\"";
            this.EncapSuffix = "\"";
            this.VariablePrefix = ":";
        }

        public SmartCRUD(Type type)
        {
            this.Type = type;
            this.EncapPrefix = "\"";
            this.EncapSuffix = "\"";
            this.VariablePrefix = ":";
        }

        public string BuildSelect(string whereClause = null)
        {
            string sql = "select {0} from {1}";
            if (whereClause != null)
                sql += " where " + whereClause;
            var properties = Type.GetProperties();
            sql = String.Format(sql, BuildSelectFields(), GetTableName(), BuildWhereClause());

            return sql;
        }
        public string BuildDelete()
        {
            string sql = "delete from {0} where {1}";
            sql = String.Format(sql, GetTableName(), BuildWhereClause());

            return sql;
        }
        public string BuildUpdate()
        {
            string sql = "update {0} set {1} where {2}";
            sql = String.Format(sql, GetTableName(), BuildUpdateFields(), BuildWhereClause());

            return sql;
        }
        public string BuildInsert()
        {
            string sql = "insert into {0} ({1}) values ({2})";
            sql = String.Format(sql, GetTableName(), BuildInsertFields(), BuildInsertValues());

            return sql;
        }
        private string BuildSelectFields()
        {
            var ss = properties.Select(m => $"{EncapPrefix}{m.GetColumnName()}{EncapSuffix} as {m.Name}");
            var s = String.Join(", ", ss);
            return s;
        }
        private string BuildWhereClause()
        {
            var ss = properties.Where(m => m.IsKey()).Select(m => $"{EncapPrefix}{m.GetColumnName()}{EncapSuffix}={VariablePrefix}{m.Name}");
            var s = String.Join(" and ", ss);
            return s;
        }
        public string BuildWhereClause(object obj)
        {
            var p = obj.GetType().GetProperties();
            var ss = p.Select(m => $"{EncapPrefix}{m.GetColumnName()}{EncapSuffix}={VariablePrefix}{m.Name}");
            var s = String.Join(" and ", ss);
            return s;
        }
        private string BuildUpdateFields()
        {
            var ss = properties.Where(m => !m.IsKey()).Select(m => $"{EncapPrefix}{m.GetColumnName()}{EncapSuffix}={VariablePrefix}{m.Name}");
            var s = String.Join(",", ss);
            return s;
        }
        private string BuildInsertFields()
        {
            var ss = properties.Where(m => !m.IsDatabaseGenerated()).Select(m => Encapsulate(m.GetColumnName()));
            var s = String.Join(",", ss);
            return s;
        }
        private string BuildInsertValues()
        {
            var ss = properties.Where(m => !m.IsDatabaseGenerated()).Select(m => VariablePrefix + m.GetColumnName());
            var s = String.Join(",", ss);
            return s;
        }

        private string GetTableName()
        {
            string name = "";
            var tableattr = this.Type.GetCustomAttributes(true).SingleOrDefault(attr => attr.GetType().Name == typeof(TableAttribute).Name) as TableAttribute;

            if (tableattr != null)
            {
                if (!String.IsNullOrEmpty(tableattr.Schema))
                    name = Encapsulate(tableattr.Schema) + ".";

                name += Encapsulate(tableattr.Name);
            }
            else
                name = Encapsulate(this.Type.Name);

            return name;
        }

        private string Encapsulate(string field)
        {
            return $"{EncapPrefix}{field}{EncapSuffix}";
        }
    }
}
