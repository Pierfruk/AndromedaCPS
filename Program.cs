var startupPath = Path.GetDirectoryName(@"C:\Users\pierf\source\repos\Andromeda\Andromeda\");
var options = new WebApplicationOptions
{
    ContentRootPath = startupPath,
    WebRootPath = startupPath,
};
var webBuilder = WebApplication.CreateBuilder(options);
var app = webBuilder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();


