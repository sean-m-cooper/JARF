namespace JARF.Definitions.Tables
{
    public interface IKeyField
    {
        string FieldName { get; set; }
        SortOrder SortOrder { get; set; }
    }
}