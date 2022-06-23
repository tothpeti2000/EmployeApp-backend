using API.Setup;

var builder = WebApplication.CreateBuilder(args)
    .RegisterServices();

var app = builder.Build()
    .SetupMiddleware()
    .SeedDbData();

app.Run();
