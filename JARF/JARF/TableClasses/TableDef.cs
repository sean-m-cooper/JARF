using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace JARF.TableClasses
{
    public class TableDef : PrimaryDBObject
    {
        public List<Column> Columns { get; set; }
        public Key PrimaryKey { get; set; }
        public List<Key> ForeignKeys { get; set; }
        public bool ShowInList { get; set; }

        public TableDef(XElement elm) : base(elm)
        {
            ShowInList = true;
            this.Columns = elm.Element("columns").Elements("column").Select(c => new Column(c)).ToList();

        }
    }
}
