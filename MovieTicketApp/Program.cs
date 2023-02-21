using Microsoft.EntityFrameworkCore;
using MovieTicketApp.Data;
using MovieTicketApp.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultString")));
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IActorsService, ActorsService>();
//builder.Services.AddScoped<IProducersService, ProducersService>();
//builder.Services.AddScoped<ICinemasService, CinemasService>();
//builder.Services.AddScoped<IMoviesService, MoviesService>();
//builder.Services.AddScoped<IOrdersService, OrdersService>();

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

AppDbInitializer.Seed(app);

app.Run();
