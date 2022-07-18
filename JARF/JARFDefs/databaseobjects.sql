--tables
select t.name, 
	s.name as 'schema_name',
	o.create_date, 
	o.modify_date, 
	o.object_id, 
	o.parent_object_id, 
	o.type, 
	o.schema_id,
	(select c.is_nullable,
		c.is_identity,
		c.system_type_id,
		st.name as 'system_type_name',
		c.max_length,
		c.precision,
		c.scale,
		o.create_date, 
		o.modify_date, 
		o.object_id, 
		o.parent_object_id, 
		o.type, 
		o.schema_id
		from sys.columns c 
			inner join sys.types st on c.system_type_id = st.system_type_id
			inner join sys.objects o on c.object_id = o.object_id
		where c.object_id = t.object_id 
		for xml path ('column'),root('columns'),type), 
	(select i.name, kc.name as 'constraint_name',  io.name as 'table_name', i.type_desc, i.is_unique, i.is_unique_constraint, i.is_primary_key, i.index_id
		from sys.indexes i
			inner join sys.key_constraints kc on i.object_id = kc.parent_object_id
			inner join sys.objects io on i.object_id = io.object_id
		where io.object_id = t.object_id
		order by i.name
		for xml path ('index'), root('indexes'),type),
	(select kc.*
		from sys.key_constraints kc 
		where kc.parent_object_id = t.object_id 
		for xml path ('primarykey'),root('primarykeys'),type), 
	(select fk.* 
		from sys.foreign_keys fk 
		where fk.parent_object_id = t.object_id 
		for xml path ('foreignkey'),root('foreignkeys'),type)
from sys.tables t
	inner join sys.schemas s on t.schema_id = s.schema_id
	inner join sys.objects o on t.object_id = o.object_id
order by name for xml path('table'),root ('tables')


--views
select t.*,	
	(select c.*
		, st.Name as 'system_type_name' 
	from sys.columns c 
		left join sys.types st on c.system_type_id = st.system_type_id
		where c.object_id = t.object_id 
		for xml path ('column'),root('columns'),type),
	(select i.* from sys.indexes i where i.object_id = t.object_id
		for xml path ('index'), root ('indexes'),type)		 
	from sys.views t 
	order by name 
	for xml path('view'),root ('views')

--procedures
select s.name as 'schema_name', 
	p.name, 
	m.definition,  
	o.create_date, 
	o.modify_date, 
	o.object_id, 
	o.parent_object_id, 
	o.type, 
	o.schema_id
from sys.sql_modules m
	inner join sys.procedures p on m.object_id = p.object_id
	inner join sys.schemas s on p.schema_id = s.schema_id
	inner join sys.objects o on p.object_id = o.object_id
order by s.name, p.name
for XML PATH ('procedure'), ROOT ('procedures')

--table -> index -> key contraint

--select * from sys.types
--select i.name, t.name, i.* from sys.indexes i
--	inner join sys.tables t on i.object_id = t.object_id
--	where i.type>0
--select * from sys.index_columns
--select * from sys.identity_columns
