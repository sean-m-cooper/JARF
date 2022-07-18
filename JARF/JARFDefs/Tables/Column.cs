using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class Column : DbObject, IColumn
    {
        public bool AllowNull { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsIdentity { get; set; }
        public int SystemDataType { get; set; }
        public string SystemTypeName { get; set; }
        public int MaxLength { get; set; }
        public int Precision { get; set; }
        public int Scale { get; set; }

        public Column(XElement elm) : base(elm)
        {
            this.AllowNull = elm.Element("is_nullable").Value == "1";
            this.IsIdentity = elm.Element("is_identity").Value == "1";
            this.SystemDataType =  int.Parse(elm.Element("system_type_id").Value);
            this.SystemTypeName = elm.Element("system_type_name").Value;
            this.MaxLength = int.Parse(elm.Element("max_length").Value);
            this.Precision = int.Parse(elm.Element("precision").Value);
            this.Scale = int.Parse(elm.Element("scale").Value);
        }
    }
}
