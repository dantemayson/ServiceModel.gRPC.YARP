var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapReverseProxy(x =>
{
    x.UseSessionAffinity();
    x.UseLoadBalancing();
});
app.Run();
