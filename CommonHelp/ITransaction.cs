using System.Collections.Generic;

namespace CommonHelp
{
    public interface ITransaction
    {
        List<T> Query<T>(string sql, object param);
        T QueryFirstOrDefault<T>(string sql, object param);
        T ExecuteScalar<T>(string sql, object param);
        int Execute(string sql, object param);

    }
}
