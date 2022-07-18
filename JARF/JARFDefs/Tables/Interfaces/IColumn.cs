namespace JARF.Definitions.Tables
{
    public interface IColumn : IDbObject
    {
        bool AllowNull { get; set; }
        bool IsIdentity { get; set; }
        bool IsPrimaryKey { get; set; }
    }
}