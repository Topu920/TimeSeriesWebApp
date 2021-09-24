using Microsoft.EntityFrameworkCore;

using OA.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class DataFieldRepository<T> : IDataFieldRepository<T> where T: DataField
    {
        private readonly DBContext _context;
        private DbSet<T> entities;

        public DataFieldRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return (IEnumerable<T>)await _context.DataFields.ToListAsync();
        }
    }
}
