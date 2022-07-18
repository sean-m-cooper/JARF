namespace JARF.Definitions.Tables
{
    public interface IIndex
    {
        string ConstraintName { get; set; }
        int IndexId { get; set; }
        string IndexType { get; set; }
        bool IsPrimary { get; set; }
        bool IsUnique { get; set; }
        string TableName { get; set; }
    }
}