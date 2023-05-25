var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
var app = builder.Build();

app.MapReverseProxy();

app.Run();


