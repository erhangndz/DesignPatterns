


using DesignPattern.UnitOfWork.BusinessLayer.Abstract;
using DesignPattern.UnitOfWork.BusinessLayer.Concrete;
using DesignPattern.UnitOfWork.DataAccessLayer.Abstract;
using DesignPattern.UnitOfWork.DataAccessLayer.Concrete;
using DesignPattern.UnitOfWork.DataAccessLayer.Repositories;
using DesignPattern.UnitOfWork.DataAccessLayer.UnitofWork.Abstract;
using DesignPattern.UnitOfWork.DataAccessLayer.UnitofWork.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<UOWContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlServer"));
});
builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<IUnitofWorkDal, UnitofWorkDal>();
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
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
