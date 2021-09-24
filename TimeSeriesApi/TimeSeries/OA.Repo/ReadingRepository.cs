using Microsoft.EntityFrameworkCore;

using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class ReadingRepository<T> : IReadingRepository<T> where T: Reading
    {
        private readonly DBContext _context;
        private DbSet<T> entities;

        public ReadingRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return (IEnumerable<T>)await _context.Readings.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(int buildingId, int objectId, int dataFieldId, DateTime? startTime, DateTime? endTime)
        {
            var list = await _context.Readings.ToListAsync();

            if (buildingId > 0)
            {
                list = list.Where(b => b.BuildingId == buildingId).ToList();
            }
            if (objectId > 0)
            {
                list = list.Where(b => b.ObjectId == objectId).ToList();
            }
            if (dataFieldId > 0)
            {
                list = list.Where(b => b.DataFieldId == dataFieldId).ToList();
            }
            if (startTime.HasValue && endTime.HasValue )
            {
                list = list.Where(b => b.TimeStamp >= startTime && b.TimeStamp <= endTime).ToList();
            }

            return (IEnumerable<T>)list;
        }
    }
}
