using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public interface IBuildingRepository<T> where T :Building
    {
        Task<IEnumerable<T>> GetAll();
    }
}
