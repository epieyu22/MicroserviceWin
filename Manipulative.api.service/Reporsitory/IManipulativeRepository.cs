using Manipulative.api.service.Core.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manipulative.api.service.Reporsitory
{
    public interface IManipulativeRepository
    {
        Task<IEnumerable<manipulative>> GetManipulative();
    }
}
