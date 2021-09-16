using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARF.TableClasses
{
    interface IPrimaryDBObject
    {
         DateTime CreateDate { get; set; }
         DateTime ModifyDate { get; set; }
    }
}
