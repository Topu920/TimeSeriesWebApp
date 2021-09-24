using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public interface IDataFieldRepository<T> where T: DataField
    {
        Task<IEnumerable<T>> GetAll();

    }
}
