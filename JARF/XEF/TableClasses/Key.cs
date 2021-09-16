using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace JARF.TableClasses
{
    public class Key : PrimaryDBObject
    {
        public bool IsPrimary { get; set; }
        public bool IsClustered { get; set; }
        public List<KeyField> Fields { get; set; }

        public Key(XElement elm) : base(elm)
        {

        }
    }
}
