using System.Collections.Generic;
using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class Key : PrimaryDBObject, IKey
    {
        public bool IsPrimary { get; set; }
        public bool IsClustered { get; set; }
        public List<IKeyField> Fields { get; set; }

        public Key(XElement elm, bool isPrimary) : base(elm)
        {
            this.IsPrimary = isPrimary;

        }
    }
}
