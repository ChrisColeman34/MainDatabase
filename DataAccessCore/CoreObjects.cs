using DataAccessCore.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessCore
{
    public class CoreObjects : ICoreObjects
    {
        public CoreObjects()
        {
            CoreRelationshipsObjectIdNodeOneNavigation = new HashSet<ICoreRelationships>();
            CoreRelationshipsObjectIdNodeTwoNavigation = new HashSet<ICoreRelationships>();
        }

        public int Id { get; set; }
        public int ObjectTypeId { get; set; }
        public string ObjectName { get; set; }
        public int ObjectMetadataId { get; set; }
        public int VersionId { get; set; }

        public ICoreObjectMetadata ObjectMetadata { get; set; }
        public ICoreObjectTypes ObjectType { get; set; }
        public ICollection<ICoreRelationships> CoreRelationshipsObjectIdNodeOneNavigation { get; set; }
        public ICollection<ICoreRelationships> CoreRelationshipsObjectIdNodeTwoNavigation { get; set; }
    }
}
