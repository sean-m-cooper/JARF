using System.Text;

namespace JARF.Definitions.Queries
{
    public abstract class QueryField : IQueryField
    {
        public string Field { get; set; }
        public string Alias { get; set; }

        public abstract string ToQueryFieldString(bool isFirstField);
        public abstract string ToQueryFieldString(StringBuilder sb, bool isFirstField);

        public abstract void AppendQueryFieldString(ref StringBuilder sb, bool isFirstField);
    }
}
