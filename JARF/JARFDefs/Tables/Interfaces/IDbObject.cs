namespace JARF.Definitions.Tables
{
    public interface IDbObject
    {
        string Name { get; set; }
        string ObjectId { get; set; }
        string ParentObjectId { get; set; }
    }
}