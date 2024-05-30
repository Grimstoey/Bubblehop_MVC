using BubblehopWeb.DataAccess;
using BubblehopWeb.DataAccess.ManageDataMethod;
using BubblehopWeb.DataAccess.ManageDataMethod.Interface;
using Microsoft.EntityFrameworkCore;
using Bubblehop.DataAccess;
using Bubblehop.DataAccess.DataRepository.RepositoryInterface;
using Bubblehop.DataAccess.DataRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add DbContext service
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); //ฉีด UnitOfWork เข้าไปใน IUnitOfWork


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
    pattern: "{area=User}/{controller=Home}/{action=Index}/{id?}");


app.Run();
