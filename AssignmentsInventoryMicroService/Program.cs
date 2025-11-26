using AssignmentsInventoryMicroService.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(opts =>
    {
        // avoid object cycle issues
        opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SQL Server – code first
builder.Services.AddDbContext<AssignmentsInventoryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AssignmentsInventoryDb")));

// TODO: register repositories & services (shown below)
//builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
