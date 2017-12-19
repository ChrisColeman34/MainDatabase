using System.Collections.Generic;

namespace DataAccessCore.Interfaces
{
    public interface ICoreObjectMetadata : IEntity
    {
        ICollection<ICoreObjects> CoreObjects { get; set; }
        ICollection<ICoreRelationships> CoreRelationships { get; set; }
        string Metadata { get; set; }
        int MetadataType { get; set; }
        IMetadataType MetadataTypeNavigation { get; set; }
    }
}