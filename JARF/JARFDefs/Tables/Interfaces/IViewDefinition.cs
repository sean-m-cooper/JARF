using System.Collections.Generic;

namespace JARF.Definitions.Tables
{
    public interface IViewDefinition
    {
        List<Column> Columns { get; set; }
        List<Key> ForeignKeys { get; set; }
        Key PrimaryKey { get; set; }
    }
}