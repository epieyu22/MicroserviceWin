using Manipulative.api.service.Core.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Manipulative.api.service.Core.ContextMongoDB
{
    public class ManipulativeContext : IManipulativeContext
    {
        private readonly IMongoDatabase _database;
        public ManipulativeContext(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _database = client.GetDatabase(options.Value.DatabaseName);
        }
        public IMongoCollection<manipulative> Manipulatives => _database.GetCollection<manipulative>("manipulative");
    }
}
