using DesignPattern.Repository.BusinessLayer.Abstract;
using DesignPattern.Repository.BusinessLayer.Concrete;
using DesignPattern.Repository.DataAccessLayer.Abstract;
using DesignPattern.Repository.DataAccessLayer.Concrete;
using DesignPattern.Repository.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlServer"));
});

builder.Services.AddScoped(typeof(IGenericDal<>),typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>),typeof(GenericService<>));
builder.Services.AddScoped<IProductService,ProductService>();

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
