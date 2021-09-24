using Microsoft.EntityFrameworkCore;

using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Object = OA.Data.Entities.Object;

namespace OA.Repo
{
    public class ObjectRepository<T> : IObjectRepository<T> where T: Object
    {
        private readonly DBContext _context;
        private DbSet<T> entities;

        public ObjectRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return (IEnumerable<T>)await _context.Objects.ToListAsync();
        }
    }
}
