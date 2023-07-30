using MongoDB.Driver;
using Manipulative.api.service.Core.Entities;

namespace Manipulative.api.service.Core.ContextMongoDB
{
    public interface IManipulativeContext
    {
        IMongoCollection<manipulative> Manipulatives { get; }

    }
}
