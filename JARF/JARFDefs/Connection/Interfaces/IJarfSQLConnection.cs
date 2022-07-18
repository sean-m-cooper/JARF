using System.Threading;
using System.Threading.Tasks;

namespace JARF.Definitions.Connection
{
    public interface IJarfSQLConnection
    {
        void Open();
        Task OpenAsync();
        Task OpenAsync(CancellationToken cancellationToken);
    }
}