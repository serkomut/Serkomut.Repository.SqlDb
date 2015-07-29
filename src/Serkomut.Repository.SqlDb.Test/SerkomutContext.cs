using System.Data.Entity;

namespace Serkomut.Repository.SqlDb.Test
{
    public class SerkomutContext : DbContext
    {
        public SerkomutContext()
            : base("name=SerkomutContext")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}