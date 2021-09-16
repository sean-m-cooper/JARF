namespace JARF.Definitions.Tables
{
    public interface IColumn
    {
        bool AllowNull { get; set; }
        bool IsIdentity { get; set; }
        bool IsPrimaryKey { get; set; }
    }
}