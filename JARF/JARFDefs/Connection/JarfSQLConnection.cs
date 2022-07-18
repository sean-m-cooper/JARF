using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace JARF.Definitions.Connection
{
    public sealed class JarfSQLConnection : IJarfSQLConnection
    {
        private SqlConnection connection;

        private static JarfSQLConnection instance = new();

        static JarfSQLConnection() { }

        private JarfSQLConnection() { }
        private JarfSQLConnection(string connectionString)
        {
            this.connection = JarfDbConnectionFactory.GetDatabaseConnection(JarfDbConnectionFactory.DBType.MSSQL, connectionString) as SqlConnection;
        }

        public static JarfSQLConnection Instance { get { return instance; } }

        public static void Create(string connectionString)
        {
            instance = new JarfSQLConnection(connectionString);
        }

        public void Open()
        {
            this.connection.Open();
        }

        public async Task OpenAsync()
        {
            await this.connection.OpenAsync();
        }

        public async Task OpenAsync(CancellationToken cancellationToken)
        {
            await this.connection.OpenAsync(cancellationToken);
        }

    }
}
