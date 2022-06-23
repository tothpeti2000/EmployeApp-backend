using DAL;

namespace API.Setup
{
    public static class DbDataSeed
    {
        public static WebApplication SeedDbData(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                TestDataSeeder.Initialize(services);
            }

            return app;
        }
    }
}
