using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCRUD
{
    public static class PropertyInfoExtensions
    {
        public static string GetColumnName(this PropertyInfo pi)
        {
            var attr = pi.GetCustomAttributes().SingleOrDefault(a => a.GetType().Name == typeof(ColumnAttribute).Name) as ColumnAttribute;
            if (attr != null)
                return attr.Name;
            else
                return pi.Name;
        }
        public static bool IsKey(this PropertyInfo pi)
        {
            var attr = pi.GetCustomAttributes().SingleOrDefault(a => a.GetType().Name == typeof(KeyAttribute).Name) as KeyAttribute;
            return attr != null;
        }
        public static bool IsDatabaseGenerated(this PropertyInfo pi)
        {
            var attr = pi.GetCustomAttributes().SingleOrDefault(a => a.GetType().Name == typeof(DatabaseGeneratedAttribute).Name) as DatabaseGeneratedAttribute;
            if (attr == null) return false;

            var val = attr.DatabaseGeneratedOption;
            if (val == DatabaseGeneratedOption.None) return false;

            return true;
        }
    }
}
