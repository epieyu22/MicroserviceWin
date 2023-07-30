using Manipulative.api.service.Core.ContextMongoDB;
using Manipulative.api.service.Core.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manipulative.api.service.Reporsitory
{
    public class manipulativeRepository : IManipulativeRepository
    {
        private readonly IManipulativeContext _manipulativeContext;
        public manipulativeRepository(IManipulativeContext manipulativeContext)
        {
            _manipulativeContext = manipulativeContext;
        }

        public async Task<IEnumerable<manipulative>> GetManipulative()
        {
            return await _manipulativeContext.Manipulatives.Find(p => true).ToListAsync();
        }
    }
}
