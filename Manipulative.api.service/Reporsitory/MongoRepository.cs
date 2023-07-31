using Manipulative.api.service.Core;
using Manipulative.api.service.Core.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Linq;

namespace Manipulative.api.service.Reporsitory
{
    public class MongoRepository<TDocument> : IMongoRepository<TDocument> where TDocument : IDocument
    {
        private readonly IMongoCollection<TDocument> _collection;

        public MongoRepository(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            var db = client.GetDatabase(options.Value.DatabaseName);

            _collection = db.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));
        }

        private protected string GetCollectionName(Type documenType)
        {
            return ((BsonCollectionAttribute)documenType.GetCustomAttributes(typeof(BsonCollectionAttribute),true).FirstOrDefault()).CollectionName;
        }

        public IQueryable<TDocument> GetAll()
        {
            return _collection.AsQueryable();
        }
    }
}
