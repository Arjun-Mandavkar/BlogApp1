using Microsoft.Data.SqlClient;

namespace BlogApp1.DbConnection
{
    public interface IDbConnectionFactory
    {
        public SqlConnection GetDefaultConnection();
    }
}
