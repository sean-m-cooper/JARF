using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class Column : DbObject, IColumn
    {
        public bool AllowNull { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsIdentity { get; set; }

        public Column(XElement elm) : base(elm)
        {
            this.AllowNull = elm.Element("is_nullable").Value == "1";
            this.IsIdentity = elm.Element("is_identity").Value == "1";

        }
    }
}
