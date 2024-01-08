using Business_Layer.Services;
using Data_Access_Layer.Data;
using Data_Access_Layer.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Add custom services

builder.Services.AddTransient<IPassWordsRepo, PassWordsRepo>();
 
builder.Services.AddScoped<IPassWordsServics , PassWordsServices>();


//Add the database

builder.Services.AddDbContext<ApplicationDbContext>( options => options.UseSqlServer(

    builder.Configuration.GetConnectionString("DefaultString")    
    
));


//Add automapper

builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
