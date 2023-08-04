using CarTransportBack.Entity;
using CarTransportBack.Services;
using Microsoft.EntityFrameworkCore;

namespace CarTransportBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var Connection = builder.Configuration.GetConnectionString("TransportDBConnection");
            // Add services to the container.
            builder.Services.AddTransient<IUserService,UserService>();
            builder.Services.AddTransient<IRideService,RideService>();
            builder.Services.AddTransient<ICarService,CarService>();
            builder.Services.AddDbContext<TransportDBContext>(option=>option.UseSqlServer(Connection));
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}