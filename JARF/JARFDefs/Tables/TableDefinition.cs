using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class TableDefinition : PrimaryDBObject, ITableDefinition
    {
        public List<Column> Columns { get; set; }
        public Key PrimaryKey { get; set; }
        public List<Key> ForeignKeys { get; set; }
        public bool ShowInList { get; set; }

        public TableDefinition(XElement elm) : base(elm)
        {
            ShowInList = true;
            this.Columns = elm.Element("columns").Elements("column").Select(c => new Column(c)).ToList();
            this.ForeignKeys = elm.Element("foreignKeys").Elements("foreignKey").Select(k => new Key(k)).ToList();

        }
    }
}
