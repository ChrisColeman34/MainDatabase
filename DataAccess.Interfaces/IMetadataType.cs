using System.Collections.Generic;

namespace DataAccessCore.Interfaces
{
    public interface IMetadataType : IEntity
    {
        ICollection<ICoreObjectMetadata> CoreObjectMetadata { get; set; }
    }
}