using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class ViewDefinition : PrimaryDBObject, IViewDefinition
    {
        public List<Column> Columns { get; set; }
        public Key PrimaryKey { get; set; }
        public List<Key> ForeignKeys { get; set; }
        public ViewDefinition(XElement elm) : base(elm)
        {
            this.Columns = elm.Element("columns").Elements("column").Select(c => new Column(c)).ToList();
        }
    }
}
