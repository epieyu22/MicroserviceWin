using Manipulative.api.service.Core.Entities;
using System.Linq;

namespace Manipulative.api.service.Reporsitory
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        IQueryable<TDocument> GetAll();
    }
}
