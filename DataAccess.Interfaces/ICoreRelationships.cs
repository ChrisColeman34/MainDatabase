namespace DataAccessCore.Interfaces
{
    public interface ICoreRelationships : IEntity
    {
        ICoreObjectMetadata Metadata { get; set; }
        int MetadataId { get; set; }
        int ObjectIdNodeOne { get; set; }
        ICoreObjects ObjectIdNodeOneNavigation { get; set; }
        int ObjectIdNodeTwo { get; set; }
        ICoreObjects ObjectIdNodeTwoNavigation { get; set; }
    }
}