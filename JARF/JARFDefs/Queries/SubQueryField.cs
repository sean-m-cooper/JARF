using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARF.Definitions.Queries
{
    public class SubQueryField:QueryField
    {
        public string SubQuery { get; set; }

        public override void AppendQueryFieldString(ref StringBuilder sb, bool isFirstField)
        {
            CreateQueryFieldString(ref sb, isFirstField);
        }

        public override string ToQueryFieldString(bool isFirstField)
        {
            var sb = new StringBuilder();
            return this.ToQueryFieldString(sb, isFirstField);
        }

        public override string ToQueryFieldString(StringBuilder sb, bool isFirstField)
        {
            CreateQueryFieldString(ref sb, isFirstField);
            return sb.ToString();
        }

        private void CreateQueryFieldString(ref StringBuilder sb, bool isFirstField)
        {
            if (!isFirstField) sb.Append(", ");
            sb.Append(this.SubQuery);
            sb.Append($" as '{this.Alias}");
        }
    }
}
