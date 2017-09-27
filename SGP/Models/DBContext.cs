using System.Data.Entity;

namespace SGP.Models
{
    class DBContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Contacts> Contacts { get; set; }

        public DBContext() : base("SGP")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    }

}
