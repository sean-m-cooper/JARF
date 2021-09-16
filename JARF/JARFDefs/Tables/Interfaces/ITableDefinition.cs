using System.Collections.Generic;

namespace JARF.Definitions.Tables
{
    public interface ITableDefinition
    {
        List<Column> Columns { get; set; }
        List<Key> ForeignKeys { get; set; }
        Key PrimaryKey { get; set; }
        bool ShowInList { get; set; }
    }
}