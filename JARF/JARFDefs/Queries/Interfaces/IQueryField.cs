using System.Text;

namespace JARF.Definitions.Queries
{
    public interface IQueryField
    {
        string Alias { get; set; }
        string Field { get; set; }

        void AppendQueryFieldString(ref StringBuilder sb, bool isFirstField);
        string ToQueryFieldString(bool isFirstField);
        string ToQueryFieldString(StringBuilder sb, bool isFirstField);
    }
}