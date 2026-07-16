var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
app.UseStaticFiles();          // Serves wwwroot/index.html
app.MapControllers();
app.MapGet("/", () => Results.Redirect("/index.html"));
app.Run("http://localhost:5000");
