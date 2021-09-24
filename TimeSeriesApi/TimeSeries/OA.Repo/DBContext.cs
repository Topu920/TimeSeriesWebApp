using Microsoft.EntityFrameworkCore;

using OA.Data.Entities;

using Object = OA.Data.Entities.Object;

namespace OA.Repo
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            :base(options)
        {

        }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Object> Objects { get; set; }
        public DbSet<DataField> DataFields { get; set; }
        public DbSet<Reading> Readings { get; set; }
    }
}
