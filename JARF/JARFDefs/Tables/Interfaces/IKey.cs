using System.Collections.Generic;

namespace JARF.Definitions.Tables
{
    public interface IKey
    {
        List<KeyField> Fields { get; set; }
        bool IsClustered { get; set; }
        bool IsPrimary { get; set; }
    }
}