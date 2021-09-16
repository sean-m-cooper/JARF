using System.Collections.Generic;
using System.Xml.Linq;
using JARF.TableClasses;

namespace JARF
{
    public class JARFData
    {
        public static XDocument TableDoc { get; set; }
        public static XDocument ViewDoc { get; set; }

        public static List<TableDef> Tables { get; set; }
        public static List<ViewDef> Views { get; set; }

        public static string ConStringFormat = "Server={0};Database={1};User Id={2};Password={3}";
        public static string TableQuery = @"select t.*, (select * from sys.columns c where c.object_id = t.object_id for xml path ('column'),root('columns'),type), (select * from sys.key_constraints kc where kc.parent_object_id = t.object_id for xml path ('primarykey'),root('primarykeys'),type), (select * from sys.foreign_keys fk where fk.parent_object_id = t.object_id for xml path ('foreignkey'),root('foreignkeys'),type) from sys.tables t order by name for xml path('table'),root ('tables')";
        public static string ViewQuery = @"select t.*,	(select * from sys.columns c where c.object_id = t.object_id for xml path ('column'),root('columns'),type) from sys.views  t order by name for xml path('view'),root ('views')";
    }
}
