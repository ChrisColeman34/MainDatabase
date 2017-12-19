using DataAccessCore.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessCore
{
    public partial class MetadataType : IMetadataType
    {
        public MetadataType()
        {
            CoreObjectMetadata = new HashSet<ICoreObjectMetadata>();
        }

        public int Id { get; set; }

        public ICollection<ICoreObjectMetadata> CoreObjectMetadata { get; set; }
    }
}
