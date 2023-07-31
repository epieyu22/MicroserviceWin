using System;

namespace Manipulative.api.service.Core.Entities
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BsonCollectionAttribute : Attribute
    {
        public string CollectionName { get; }

        public BsonCollectionAttribute (string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
