var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseDefaultFiles();
app.UseStaticFiles();

// Map Razor Pages endpoints.
app.MapRazorPages();

// app.MapGet("/", () => "Hello World!");

app.Run();




