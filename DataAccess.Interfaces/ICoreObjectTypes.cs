using System.Collections.Generic;

namespace DataAccessCore.Interfaces 
{
    public interface ICoreObjectTypes : IEntity
    {
        ICollection<ICoreObjects> CoreObjects { get; set; }
        string ObjectTypeName { get; set; }
    }
}