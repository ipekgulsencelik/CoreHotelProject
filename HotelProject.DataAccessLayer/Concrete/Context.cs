using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI;database=HotelDB;integrated security=true;trusted_connection=true;encrypt=false");
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMessage> Messages { get; set; }
    }
}