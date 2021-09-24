using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface IReadingService
    {
         Task<IEnumerable<Reading>> GetReadings();
         Task<IEnumerable<Reading>> GetReadingsList(int buildingId, int objectId,
            int dataFieldId, DateTime? startTime, DateTime? endTime);
    }
}
