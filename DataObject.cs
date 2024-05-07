using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace DownEast.ActiveRecord
{
    public class ActiveRecordMediator<T> where T : class
    {
        public string Encapsulation { get; set; }
        public string VariablePrefix { get; set; }

        public ActiveRecordMediator()
        {
            Encapsulation = "\"{value}\"";
            VariablePrefix = "@";
        }
        public ActiveRecordMediator(string encapsulation, string variablePrefix)
        {
            Encapsulation = encapsulation;
            VariablePrefix = variablePrefix;
        }

        public Dictionary<string, object> ToDictionary(T obj, bool useColumnNames = false)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            foreach (PropertyInfo property in typeof(T).GetProperties())
            {
                if (useColumnNames)
                    dict.Add(property.GetColumnName(), property.GetValue(obj));
                else
                    dict.Add(property.Name, property.GetValue(obj));
            }
            return dict;
        }
        public string TableName()
        {
            string name = typeof(T).Name;
            var tableattr = typeof(T).GetCustomAttributes(true).SingleOrDefault(attr => attr.GetType().Name == typeof(TableAttribute).Name) as TableAttribute;

            if (tableattr != null)
                if (!String.IsNullOrEmpty(tableattr.Schema))
                    name = $"{tableattr.Schema}.{tableattr.Name}";
                else
                    name = tableattr.Name;

            return name;
        }
        public Dictionary<string, string> Fields()
        {
            return new Dictionary<string, string>(typeof(T).GetProperties().Select(p => new KeyValuePair<string, string>(p.Name, p.GetColumnName())));
        }
        public Dictionary<string, string> Keys()
        {
            return new Dictionary<string, string>(typeof(T).GetProperties().Where(p => p.GetCustomAttribute<KeyAttribute>() != null).Select(p => new KeyValuePair<string, string>(p.Name, p.GetColumnName())));
        }
        public Dictionary<string, string> NotKeys()
        {
            return new Dictionary<string, string>(typeof(T).GetProperties().Where(p => p.GetCustomAttribute<KeyAttribute>() == null).Select(p => new KeyValuePair<string, string>(p.Name, p.GetColumnName())));
        }
        public Dictionary<string, string> ExplicitKeys()
        {
            return new Dictionary<string, string>(typeof(T).GetProperties().Where(p => p.GetCustomAttribute<Dapper.Contrib.Extensions.ExplicitKeyAttribute>() != null).Select(p => new KeyValuePair<string, string>(p.Name, p.GetColumnName())));
        }

        public string SelectString()
        {
            string fields = String.Join(", ", Fields().Select(f => f.Value));
            string sql = $"select {fields} from {TableName()}";
            return sql;
        }
        public string InsertString()
        {
            string fields = String.Join(", ", Fields().Select(f => f.Value));
            string values = String.Join(", ", Fields().Select(f => VariablePrefix + f.Key));
            string sql = $"insert into {TableName()} ({fields}) values ({values})";
            return sql;
        }
        public string UpdateString()
        {
            string fields = String.Join(", ", Fields().Where(f => !Keys().ContainsKey(f.Key)).Select(f => $"{f.Value}={VariablePrefix}{f.Key}"));
            string keys = String.Join(" and ", Keys().Select(k => $"{k.Value}={VariablePrefix}{k.Key}"));
            string sql = $"update {TableName()} set {fields} where {keys}";
            return sql;
        }
        public string DeleteString()
        {
            string keys = String.Join(" and ", Keys().Select(k => $"{k.Value}={VariablePrefix}{k.Key}"));
            string sql = $"delete from {TableName()} where {keys}";
            return sql;
        }
    }
}
