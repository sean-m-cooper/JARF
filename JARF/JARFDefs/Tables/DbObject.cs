using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class DbObject : IDbObject
    {
        public string Name { get; set; }
        public string ObjectId { get; set; }
        public string ParentObjectId { get; set; }
        public string Type { get; set; }
        public int SchemaId { get; set; }
        public string SchemaName { get; set; }

        public DbObject(XElement elm)
        {
            this.Name = elm.Element("name").Value;
            this.ObjectId = elm.Element("object_id").Value;
            this.ParentObjectId = elm.Element("parent_object_id")?.Value;
            this.Type = elm.Element("type").Value;
            this.SchemaId = int.Parse(elm.Element("schema_id").Value);
            this.SchemaName = elm.Element("schema_name").Value;
        }
    }
}
