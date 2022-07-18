using System.Collections.Generic;

namespace JARF.Definitions.Tables
{
    public interface IView
    {
        List<IColumn> Columns { get; set; }
        List<IKey> ForeignKeys { get; set; }
        IKey PrimaryKey { get; set; }
    }
}