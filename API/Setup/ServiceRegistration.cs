﻿using DAL;
using Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Setup
{
    public static class ServiceRegistration
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddControllers();

            // DB connection
            var connStr = builder.Configuration.GetConnectionString("ConnStr");

            if (connStr == null)
            {
                throw new Exception("Couldn't find a connection string in appsettings.json");
            }

            builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(connStr));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<EmployeeService, EmployeeService>();
            builder.Services.AddScoped<DepartmentService, DepartmentService>();

            return builder;
        }
    }
}