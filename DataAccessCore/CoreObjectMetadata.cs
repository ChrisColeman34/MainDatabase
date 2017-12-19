using DataAccessCore.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessCore
{
    public class CoreObjectMetadata : ICoreObjectMetadata
    {
        public CoreObjectMetadata()
        {
            CoreObjects = new HashSet<ICoreObjects>();
            CoreRelationships = new HashSet<ICoreRelationships>();
        }

        public int Id { get; set; }
        public string Metadata { get; set; }
        public int MetadataType { get; set; }

        public IMetadataType MetadataTypeNavigation { get; set; }
        public ICollection<ICoreObjects> CoreObjects { get; set; }
        public ICollection<ICoreRelationships> CoreRelationships { get; set; }
    }
}
