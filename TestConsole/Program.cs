using System;
using System.Linq;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var coreObject = new DataAccessCore.CoreObjects { ObjectName = "Test" };
            var objectMeta = new DataAccessCore.CoreObjectMetadata();
            coreObject.ObjectMetadata = objectMeta;
            
            using (var repo = new DataAccessCore.CoreRepository())
            {
                repo.Add(coreObject);
                var objects = repo.GetAll<DataAccessCore.Interfaces.ICoreObjects>();

                Console.WriteLine(objects.First().ObjectName);
            }
        }
    }
}
