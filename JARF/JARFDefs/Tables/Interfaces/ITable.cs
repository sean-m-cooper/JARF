using System.Collections.Generic;

namespace JARF.Definitions.Tables
{
    public interface ITable
    {
        List<IColumn> Columns { get; set; }
        List<IKey> ForeignKeys { get; set; }
        List<IIndex> Indexes { get; set; }
        IKey PrimaryKey { get; set; }
        bool ShowInList { get; set; }
    }
}