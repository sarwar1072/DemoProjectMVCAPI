using Autofac.Extensions.DependencyInjection;
using Autofac;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using Framework;

namespace WebApi_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            var assemblyName = Assembly.GetExecutingAssembly().FullName;
            var webHostEnvironment = builder.Environment.WebRootPath;

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
            {
                // containerBuilder.RegisterModule(new WebModule());
                containerBuilder.RegisterModule(new FramworkModule(connectionString,
                        assemblyName, webHostEnvironment));
            });
            builder.Services.AddDbContext<AppDbcontext>(options =>
                options.UseSqlServer(connectionString, m => m.MigrationsAssembly(assemblyName)));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
