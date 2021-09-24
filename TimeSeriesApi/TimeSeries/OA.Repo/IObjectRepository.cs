using OA.Data.Entities;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public interface IObjectRepository<T> where T:Object
    {
        Task<IEnumerable<T>> GetAll();

    }
}
