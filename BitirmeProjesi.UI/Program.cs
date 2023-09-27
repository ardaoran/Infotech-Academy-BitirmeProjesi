


using BitirmeProjesi.BL.Repositories;
using BitirmeProjesi.DAL.Content;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SQLContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CS1")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(SQLRepository<>));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt=>
{
    opt.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    opt.LoginPath = "/admin/login"; //yetkisi olmadan giriþ yapmaya çalýþtýðýnda
    opt.LogoutPath = "/admin/logout"; // süre dolduðunda gideceði sayfa

}
);

var app = builder.Build();
if (!app.Environment.IsDevelopment()) app.UseStatusCodePagesWithRedirects("/hata/{0}");
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication(); //kimlik doðrulama
app.UseAuthorization();  //yetkilendirme

app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
