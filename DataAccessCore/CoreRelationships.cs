using DataAccessCore.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessCore
{
    public partial class CoreRelationships : ICoreRelationships
    {
        public int Id { get; set; }
        public int ObjectIdNodeOne { get; set; }
        public int ObjectIdNodeTwo { get; set; }
        public int MetadataId { get; set; }

        public ICoreObjectMetadata Metadata { get; set; }
        public ICoreObjects ObjectIdNodeOneNavigation { get; set; }
        public ICoreObjects ObjectIdNodeTwoNavigation { get; set; }
    }
}
