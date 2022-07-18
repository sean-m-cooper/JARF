using JARF.Definitions.Tables;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace JARF.Definitions.Procedures
{
    public class Procedure : PrimaryDBObject
    {
        public string ProcedureText { get; set; }

        public Procedure(XElement elm) : base(elm)
        {
            this.ProcedureText = elm.Element("definition").Value;
        }
    }
}
