using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;

namespace JARF.Definitions.Connection
{
    public static class JarfDbConnectionFactory
    {
        public enum DBType
        {
            AzureSQL = 1,
            MSSQL = 2,
            OracleDB = 3
        }

        public static System.Data.IDbConnection GetDatabaseConnection(DBType databaseType, string connectionString)
        {
            switch (databaseType)
            {
                case DBType.AzureSQL:
                case DBType.MSSQL:
                    return new SqlConnection(connectionString);
                case DBType.OracleDB:
                    return new OracleConnection(connectionString);
            }
            return null;
        }
    }
}
