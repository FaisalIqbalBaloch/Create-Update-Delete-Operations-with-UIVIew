using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Create_Update_Delete_Operations.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Create_Update_Delete_OperationsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Create_Update_Delete_OperationsContext") ?? throw new InvalidOperationException("Connection string 'Create_Update_Delete_OperationsContext' not found.")));

// Add services to the container.
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
