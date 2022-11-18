using BasicWebApp.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IInterest, Simple>();
//builder.Services.AddTransient<ISiteStore, XmlSiteStore>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
