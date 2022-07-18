using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace JARF.Definitions.Tables
{
    public class View : PrimaryDBObject, IView
    {
        public List<IColumn> Columns { get; set; }
        public IKey PrimaryKey { get; set; }
        public List<IKey> ForeignKeys { get; set; }
        public string Text { get; set; }
        
        public View(XElement elm) : base(elm)
        {
            this.Columns = elm.Element("columns").Elements("column").Select(c => new Column(c)).ToList<IColumn>();
        }
    }
}
