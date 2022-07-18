using System.Text;

namespace JARF.Definitions.Queries
{
    public interface IBasicQueryField
    {
        void AppendQueryFieldString(ref StringBuilder sb, bool isFirstField);
        string ToQueryFieldString(bool isFirstField);
        string ToQueryFieldString(StringBuilder sb, bool isFirstField);
    }
}