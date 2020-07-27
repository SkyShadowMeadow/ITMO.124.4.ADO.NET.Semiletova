
using System.Data.Entity;
using static CodeFirst.Model;

namespace CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("Pets")
        { }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Property(c => c.LastName).IsRequired().HasMaxLength(30);
        }
    }
}
