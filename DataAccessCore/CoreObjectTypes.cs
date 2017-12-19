using DataAccessCore.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessCore
{
    public partial class CoreObjectTypes : ICoreObjectTypes
    {
        public CoreObjectTypes()
        {
            CoreObjects = new HashSet<ICoreObjects>();
        }

        public int Id { get; set; }
        public string ObjectTypeName { get; set; }

        public ICollection<ICoreObjects> CoreObjects { get; set; }
    }
}
