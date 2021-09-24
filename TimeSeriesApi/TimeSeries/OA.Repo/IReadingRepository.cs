using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public interface IReadingRepository<T> where T:Reading
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(int buildingId, int objectId,
            int dataFieldId, DateTime? startTime, DateTime? endTime);


    }
}
