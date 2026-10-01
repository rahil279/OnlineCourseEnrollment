var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Memory Cache
builder.Services.AddMemoryCache();

// Session
builder.Services.AddSession();

// HttpClient
builder.Services.AddHttpClient();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Course}/{action=Index}/{id?}");

app.Run();
