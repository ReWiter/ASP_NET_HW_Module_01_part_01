//¹1
//var bulder = WebApplication.CreateBuilder(args);
//var app=bulder.Build();

//app.MapGet("/",()=>DateTime.Today);
//app.Run();
//¹2
//var builder = WebApplication.CreateBuilder(args);
//var app=builder.Build();
//Random rand = new Random();
//string[] b = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","p","q","r","s","t","v","w","x","y","z"};
//app.Run(async (context) =>
//{
//    int a = rand.Next(b.Length);
//    await context.Response.WriteAsync(b[a]);
//});
//app.Run();
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app=builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.Run(async context=>
{
    var path = context.Request.Path;
    context.Response.ContentType = "text/html";
    if (path == "/restoran")
    {
        await context.Response.SendFileAsync("wwwroot/htmlpage.html");
    }
    else if(path == "/country")
    {
        await context.Response.SendFileAsync("wwwroot/country.html");
    }
});
app.Run();