using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARF.Definitions.Tables
{
    interface IPrimaryDBObject
    {
         DateTime CreateDate { get; set; }
         DateTime ModifyDate { get; set; }
    }
}
