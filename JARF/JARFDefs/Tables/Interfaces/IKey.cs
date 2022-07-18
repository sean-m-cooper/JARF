using System.Collections.Generic;

namespace JARF.Definitions.Tables
{
    public interface IKey
    {
        List<IKeyField> Fields { get; set; }
        bool IsClustered { get; set; }
        bool IsPrimary { get; set; }
    }
}