using PhoneInfoMVC.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration; 

IWebHostEnvironment environment = builder.Environment;


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ITellInfoRepository, FakeTellInfo>();
builder.Services.AddMvc();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
string conString = configuration["Data:ConnectionStrings:TellInfoRepo"];
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(conString));


var app = builder.Build();

//Configure the HTTP request pipeline.
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

app.UseMvc(routes =>
{
    routes.MapRoute(
     name: "default",
     template: "{controller=TellInfo}/{action=List}/{id?}");
});
    

app.Run();
