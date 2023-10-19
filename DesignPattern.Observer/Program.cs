using DesignPattern.Observer.DataAccess;
using DesignPattern.Observer.ObserverPattern;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddScoped<IObserver,CreateWelcomeMessage>();
builder.Services.AddScoped<ObserverObject>(sp =>
{
    var observerObject= new ObserverObject();

    observerObject.RegisterObserver(new CreateWelcomeMessage(sp));
    observerObject.RegisterObserver(new CreateMagazineAnnouncement(sp));
    observerObject.RegisterObserver(new CreateDiscountCode(sp));
    return observerObject;
});
builder.Services.AddControllersWithViews();

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

app.Run();
