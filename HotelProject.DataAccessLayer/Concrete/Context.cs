using HotelProject.EntityLayer.Concrete;
using HotelProject.EntityLayer.Concrete.Blogs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI;database=MyHotelDB;integrated security=true;trusted_connection=true;encrypt=false");
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMessage> Messages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogContent> BlogContents { get; set; }
        public DbSet<Paragraph> Paragraphs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomCategory> RoomCategories { get; set; }
        public DbSet<RoomStatus> RoomStatus  { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<RoomDetail> RoomDetails { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}