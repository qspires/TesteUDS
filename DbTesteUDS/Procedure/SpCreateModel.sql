
Create procedure [dbo].[SP_CreateMODEL]
(
	@Table varchar(20),
	@model varchar(20)='',
	@viewmodel varchar(20) = ''
)
as begin
select 
	Column_name,
	type,
	length,
	Scale,
	'public ' + 
		(
			case 
				when type = 'text' then 'string'
				when type = 'char' then 'string'
				when type = 'varchar' then 'string'
				when type = 'uniqueidentifier' then 'string'
				when type = 'datetime' and Nullable = 2 then 'DateTime?'
				when type = 'datetime' and Nullable = 1 then 'DateTime'
				when type = 'smalldatetime'  and Nullable = 2 then 'DateTime?'
				when type = 'smalldatetime'  and Nullable = 1 then 'DateTime'
				when type = 'numeric' then 'Decimal'
				when type = 'numeric' then 'Decimal'
				when type = 'int' then 'int'
				when type = 'bit' then 'bool'	
			end
		) + ' ' +
	Column_name + ' { get; set; }' + ' //' + 
			convert(varchar(200),isnull((
						SELECT top 1 P.VALUE 
						FROM SYS.ALL_COLUMNS C 
						JOIN SYS.TYPES T ON T.SYSTEM_TYPE_ID=C.SYSTEM_TYPE_ID 
						LEFT OUTER JOIN SYS.SYSCOMMENTS CC ON CC.ID=C.DEFAULT_OBJECT_ID 
						LEFT OUTER JOIN SYS.EXTENDED_PROPERTIES P ON P.MAJOR_ID=C.OBJECT_ID AND MINOR_ID=C.COLUMN_ID
						JOIN SYS.ALL_OBJECTS OBJETOS ON OBJETOS.OBJECT_ID=C.OBJECT_ID WHERE C.NAME = s1.Column_name
						), '')) 'Model/ViewModel',
	case when type in ('char', 'varchar')  and Nullable = 1 then @viewmodel+'.'+ Column_name + ' = ' +@model + '.'+ Column_name + ' ?? "";' else @viewmodel+'.'+ Column_name + ' = ' +@model + '.'+ Column_name + ' ;' end toViewModel,
	case when type in ('char', 'varchar') and Nullable = 1 then @model+'.'+ Column_name + ' = ' +@viewmodel + '.'+ Column_name + ' ?? "";' else @model+'.'+ Column_name + ' = ' +@viewmodel + '.'+ Column_name + ' ;' end toCreate
from (
		select
		'Column_name'			= name,
		'Type'					= type_name(user_type_id),
		'Computed'				= case when ColumnProperty(object_id, name, 'IsComputed') = 0 then '1' else '2' end,
		'Length'				= convert(int, max_length),
		'Nullable'				= case when is_nullable = 0 then '1' else '2' end,
		'TrimTrailingBlanks'	= case ColumnProperty(object_id, name, 'UsesAnsiTrim')	when 1 then '1'	when 0 then '2'	else '(n/a)' end,
		'FixedLenNullInSource'	= case	when type_name(system_type_id) not in ('varbinary','varchar','binary','char') then '(n/a)' when is_nullable = 0 then '1' else '2' end,
		'Collation'				= collation_name,
		'Prec'					= case when charindex(type_name(system_type_id) + ',', 'tinyint,smallint,decimal,int,bigint,real,money,float,numeric,smallmoney,date,time,datetime2,datetimeoffset,') > 0 then convert(char(5),ColumnProperty(object_id, name, 'precision')) else '     ' end,
		'Scale'					= case when charindex(type_name(system_type_id) + ',', 'tinyint,smallint,decimal,int,bigint,real,money,float,numeric,smallmoney,date,time,datetime2,datetimeoffset,') > 0 then convert(char(5),OdbcScale(system_type_id,scale)) else '     ' end			
		from sys.all_columns where object_id =  object_id(@Table) ) s1
end





