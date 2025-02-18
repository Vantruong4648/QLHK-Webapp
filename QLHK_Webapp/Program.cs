using Microsoft.EntityFrameworkCore;
using QLHK_Webapp.IServices;
using QLHK_Webapp.Models;
using QLHK_Webapp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<INguoiDungService, NguoiDungService>();
builder.Services.AddScoped<IThongTinHenKhamService, ThongTinHenKhamService>();
builder.Services.AddScoped<ILoaiKhamService, LoaiKhamService>();
builder.Services.AddScoped<IPhongKhamService, PhongKhamService>();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});


builder.Services.AddDbContext<DangKyKhamDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();


app.Run();
