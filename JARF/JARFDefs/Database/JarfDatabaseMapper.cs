using JARF.Definitions.Connection;
using JARF.Definitions.Tables;
using System.Collections.Generic;

namespace JARF.Definitions.Database
{
    public class JarfDatabaseMapper
    {
        public IJarfSQLConnection Connection { get; set; }

        public IList<ITable> Tables { get; set; }
        public IList<IView> Views { get; set; }


    }
}
