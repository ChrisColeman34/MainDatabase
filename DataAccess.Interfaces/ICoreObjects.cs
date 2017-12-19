using System.Collections.Generic;

namespace DataAccessCore.Interfaces
{
    public interface ICoreObjects : IEntity
    {
        ICollection<ICoreRelationships> CoreRelationshipsObjectIdNodeOneNavigation { get; set; }
        ICollection<ICoreRelationships> CoreRelationshipsObjectIdNodeTwoNavigation { get; set; }

        ICoreObjectMetadata ObjectMetadata { get; set; }
        int ObjectMetadataId { get; set; }
        string ObjectName { get; set; }
        ICoreObjectTypes ObjectType { get; set; }
        int ObjectTypeId { get; set; }
        int VersionId { get; set; }
    }
}