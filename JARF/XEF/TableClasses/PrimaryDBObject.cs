using System;
using System.Xml.Linq;

namespace JARF.TableClasses
{
    public class PrimaryDBObject : DbObject, IPrimaryDBObject
    {
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public PrimaryDBObject(XElement elm) : base(elm)
        {
            if (elm.Element("create_date") != null)
            {
                this.CreateDate = DateTime.Parse(elm.Element("create_date").Value);
            }
            if (elm.Element("modify_date") != null)
            {
                this.ModifyDate = DateTime.Parse(elm.Element("modify_date").Value);
            }
        }
    }
}
