namespace JARF.Definitions
{
    public class TableMappingConstants
    {
        public const string ConStringFormat = "Server={0};Database={1};User Id={2};Password={3}";

        public const string TableQuery = @"select t.*, 
	(select c.* 
		, st.name as 'system_type_name'
		from sys.columns c 
			inner join sys.types st on c.system_type_id = st.system_type_id
		where c.object_id = t.object_id 
		for xml path ('column'),root('columns'),type), 
	(select kc.* from sys.key_constraints kc where kc.parent_object_id = t.object_id 
		for xml path ('primarykey'),root('primarykeys'),type), 
	(select fk.* from sys.foreign_keys fk where fk.parent_object_id = t.object_id 
		for xml path ('foreignkey'),root('foreignkeys'),type) ,
	(select i.* from sys.indexes i where i.object_id = t.object_id
		for xml path ('index'), root ('indexes'),type)
from sys.tables t order by name for xml path('table'),root ('tables')";

        public const string ViewQuery = @"select t.*,	(select * from sys.columns c where c.object_id = t.object_id for xml path ('column'),root('columns'),type) from sys.views  t order by name for xml path('view'),root ('views')";
    }
}
