using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class Index : PrimaryDBObject, IIndex
    {
        public string ConstraintName { get; set; }
        public string TableName { get; set; }
        public string IndexType { get; set; }
        public bool IsUnique { get; set; }
        public bool IsPrimary { get; set; }
        public int IndexId { get; set; }
        public Index(XElement elm) : base(elm)
        {
            this.ConstraintName = elm.Element("constraint_name").Value;
            this.TableName = elm.Element("table_name").Value;
            this.IndexType = elm.Element("type_desc").Value;
            this.IsUnique = bool.Parse(elm.Element("is_unique").Value);
            this.IsPrimary = bool.Parse(elm.Element("is_primary_key").Value);
            this.IndexId = int.Parse(elm.Element("index_id").Value);
        }
    }
}
