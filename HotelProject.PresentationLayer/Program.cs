using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();

builder.Services.AddScoped<IContactDAL, EFContactDAL>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IMessageDAL, EFMessageDAL>();
builder.Services.AddScoped<IMessageService, MessageManager>();

builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IMenuDAL, EFMenuDAL>();
builder.Services.AddScoped<IMenuService, MenuManager>();

builder.Services.AddScoped<IOrderDAL, EFOrderDAL>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<IReservationDAL, EFReservationDAL>();
builder.Services.AddScoped<IReservationService, ReservationManager>();

builder.Services.AddScoped<IRestaurantDAL, EFRestaurantDAL>();
builder.Services.AddScoped<IRestaurantService, RestaurantManager>();

builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();
builder.Services.AddScoped<IServiceService, ServiceManager>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();

