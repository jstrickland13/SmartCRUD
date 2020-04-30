using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace WNCCRM
{
    public interface IRepository<T>
    {
        public IEnumerable<T> Get();
        public IEnumerable<T> Get(object key);
        public IEnumerable<T> FirstOrDefault(object key);

        public int Insert(T value);
        public int Update(T value);
        public int Delete(T value);
    }

    public class OracleRepository<T> : IRepository<T>
    {
        public OracleConnection Connection { get; set; }
        public SmartCRUD.SmartCRUD<T> CRUD { get; set; }
        public OracleRepository(OracleConnection connection)
        {
            Connection = connection;
            CRUD = new SmartCRUD.SmartCRUD<T>();
        }
        public int Delete(T value)
        {
            return Connection.Execute(CRUD.BuildDelete(), value);
        }

        public IEnumerable<T> FirstOrDefault(object key)
        {
            return Connection.Query<T>(CRUD.BuildSelect(key), key);
        }

        public IEnumerable<T> Get()
        {
            return Connection.Query<T>(CRUD.BuildSelect());
        }

        public IEnumerable<T> Get(object key)
        {
            return Connection.QuerySingleOrDefault(CRUD.BuildSelect(key), key);
        }

        public int Insert(T value)
        {
            return Connection.Execute(CRUD.BuildInsert(), value);
        }

        public int Update(T value)
        {
            return Connection.Execute(CRUD.BuildUpdate(), value);
        }
    }
}

