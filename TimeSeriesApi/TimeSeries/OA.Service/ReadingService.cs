using OA.Data.Entities;
using OA.Repo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class ReadingService : IReadingService
    {
        private IReadingRepository<Reading> repository;
        public ReadingService(IReadingRepository<Reading> readingRepository)
        {
            repository = readingRepository;
        }
       

        public async Task<IEnumerable<Reading>> GetReadings()
        {
            return await repository.GetAll();
        }

        public async Task<IEnumerable<Reading>> GetReadingsList(int buildingId, int objectId, int dataFieldId, DateTime? startTime, DateTime? endTime)
        {
            return await repository.GetAll( buildingId,  objectId,
             dataFieldId,  startTime,  endTime);
        }
    }
}
