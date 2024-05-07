using Dapper;
using System.Data;

namespace JohnStrickland.ActiveRecord
{
    //public static class IDbConnectionExtensions
    //{
    //    public static IEnumerable<T> GetList<T>(this IDbConnection connection, object id, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null)
    //    {
    //        SqlGenerator<T> crud = new SqlGenerator<T>();
    //        var sql = crud.BuildSelect() + " where " + crud.BuildWhereClause(id);

    //        return connection.Query<T>(sql, id, transaction, buffered, commandTimeout, CommandType.Text);
    //    }
    //    public static T Get<T>(this IDbConnection connection, object id, IDbTransaction transaction = null, int? commandTimeout = null)
    //    {
    //        SqlGenerator<T> crud = new SqlGenerator<T>();
    //        var sql = crud.BuildSelect() + " where " + crud.BuildWhereClause(id);

    //        return connection.QueryFirstOrDefault<T>(sql, id, transaction, commandTimeout, CommandType.Text);
    //    }

    //    public static int Insert<T>(this IDbConnection connection, T @object, IDbTransaction transaction = null, int? commandTimeout = null)
    //    {
    //        SqlGenerator<T> crud = new SqlGenerator<T>();
    //        var sql = crud.BuildInsert();
    //        return connection.Execute(sql, @object, transaction, commandTimeout, CommandType.Text);
    //    }

    //    public static int Update<T>(this IDbConnection connection, T @object, IDbTransaction transaction = null, int? commandTimeout = null)
    //    {
    //        SqlGenerator<T> crud = new SqlGenerator<T>();
    //        var sql = crud.BuildUpdate();
    //        return connection.Execute(sql, @object, transaction, commandTimeout, CommandType.Text);
    //    }

    //    public static int Delete<T>(this IDbConnection connection, T @object, IDbTransaction transaction = null, int? commandTimeout = null)
    //    {
    //        SqlGenerator<T> crud = new SqlGenerator<T>();
    //        var sql = crud.BuildDelete();
    //        return connection.Execute(sql, @object, transaction, commandTimeout, CommandType.Text);
    //    }

    //}
}
