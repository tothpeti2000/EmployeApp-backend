using DAL;
using Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Setup
{
    public static class ServiceRegistration
    {
        // Add services to the container.
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            RegisterControllers(builder);
            RegisterDbContext(builder);
            RegisterSwagger(builder);
            RegisterCustomServices(builder);

            return builder;
        }

        private static void RegisterControllers(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
        }

        private static void RegisterDbContext(this WebApplicationBuilder builder)
        {
            var connStr = builder.Configuration.GetConnectionString("ConnStr");

            if (connStr == null)
            {
                throw new Exception("Couldn't find a connection string in appsettings.json");
            }

            builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(connStr));
        }

        private static void RegisterSwagger(this WebApplicationBuilder builder)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }

        private static void RegisterCustomServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<EmployeeService, EmployeeService>();
            builder.Services.AddScoped<DepartmentService, DepartmentService>();
        }
    }
}
