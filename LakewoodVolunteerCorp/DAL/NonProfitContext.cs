using LakewoodVolunteerCorp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LakewoodVolunteerCorp.DAL
{
    public class NonProfitContext : DbContext
    {

        public NonProfitContext() : base("NonProfitContext")
        {
        }

        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<SignUp> SignUps { get; set; }
        public DbSet<Duty> Duties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}