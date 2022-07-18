using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class Table : PrimaryDBObject, ITable
    {
        public List<IColumn> Columns { get; set; }
        public IKey PrimaryKey { get; set; }
        public List<IKey> ForeignKeys { get; set; }
        public List<IIndex> Indexes { get; set; }
        public bool ShowInList { get; set; }



        public Table(XElement elm) : base(elm)
        {
            ShowInList = true;
            this.Columns = elm.Element("columns").Elements("column").Select(c => new Column(c)).ToList<IColumn>();
            this.Indexes = elm.Element("indexes").Elements("index").Select(i => new Index(i)).ToList<IIndex>();
            this.ForeignKeys = elm.Element("foreignKeys").Elements("foreignKey").Select(k => new Key(k, false)).ToList<IKey>();
            this.PrimaryKey = elm.Element("primaryKeys").Elements("primaryKey").Select(k => new Key(k, true)).ToList<IKey>().FirstOrDefault();
        }
    }

}
