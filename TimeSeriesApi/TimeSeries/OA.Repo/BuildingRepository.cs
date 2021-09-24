using Microsoft.EntityFrameworkCore;

using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class BuildingRepository<T> : IBuildingRepository<T> where T:Building
    {
        private readonly DBContext _context;
        private DbSet<T> entities;

        public BuildingRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                var e = _context.Buildings.ToList();
                var r = e;
            }
            catch(Exception ex)
            {

            }
          
            return (IEnumerable<T>)await _context.Buildings.ToListAsync();
        }
    }
}
