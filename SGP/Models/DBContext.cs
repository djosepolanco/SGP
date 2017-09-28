using System.Data.Entity;

namespace SGP.Models
{
    class DBContext:DbContext
    {
        public DbSet<Users> Users { get; set; }

        public DBContext() : base("SGP")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    }

}
