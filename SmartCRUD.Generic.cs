using Dapper;
using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCRUD
{
    public class SmartCRUD<T>
    {
        Type type { get; set; } 
        PropertyInfo[] properties { get; set; }

        public string EncapPrefix { get; set; }
        public string EncapSuffix { get; set; }
        public string VariablePrefix { get; set; }

        public SmartCRUD()
        {
            this.EncapPrefix = "\"";
            this.EncapSuffix = "\"";
            this.VariablePrefix = ":";
            this.type = typeof(T);
            this.properties = this.type.GetProperties();
        }
        public string BuildSelect()
        {
            string sql = "select {0} from {1}";
            sql = String.Format(sql, BuildSelectFields(), GetTableName());

            return sql;
        }
        public string BuildSelect(object key)
        {
            string sql = "select {0} from {1} where {2}";
            return String.Format(sql, BuildSelectFields(), GetTableName(), BuildWhereClause(key));
        }
        public string BuildSelect(string whereClause)
        {
            string sql = "select {0} from {1} where {2}";
            return String.Format(sql, BuildSelectFields(), GetTableName(), whereClause);
        }
        public string BuildDelete()
        {
            string sql = "delete from {0} where {1}";
            var properties = type.GetProperties();
            sql = String.Format(sql, GetTableName(), BuildWhereClause());

            return sql;
        }
        public string BuildUpdate()
        {
            string sql = "update {0} set {1} where {2}";
            var properties = type.GetProperties();
            sql = String.Format(sql, GetTableName(), BuildUpdateFields(), BuildWhereClause());

            return sql;
        }
        public string BuildInsert()
        {
            string sql = "insert into {0} ({1}) values ({2})";
            var properties = type.GetProperties();
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
            var tableattr = type.GetCustomAttributes(true).SingleOrDefault(attr => attr.GetType().Name == typeof(TableAttribute).Name) as TableAttribute;

            if (tableattr != null)
            {
                if (!String.IsNullOrEmpty(tableattr.Schema))
                    name = Encapsulate(tableattr.Schema) + ".";

                name += Encapsulate(tableattr.Name);
            }
            else
                name = Encapsulate(type.Name);

            return name;
        }
        private string Encapsulate(string field)
        {
            return $"{EncapPrefix}{field}{EncapSuffix}";
        }
    }
}
