using AssignmentsInventoryMicroService.Data;
using AssignmentsInventoryMicroService.Models;
using AssignmentsInventoryMicroService.Repositories;
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
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AssignmentsInventoryDbContext>();

    if (!db.Devices.Any())
    {
        // Dummy data for Devices
        var device1 = new Device
        {
            DeviceId = Guid.NewGuid(),
            Hostname = "DESKTOP-IT-01",
            OwnerUserId = Guid.NewGuid(),
            DepartmentId = Guid.NewGuid(),
            DeviceType = "Desktop",
            LastSeen = DateTime.UtcNow,
            Status = "Active"
        };

        db.Devices.Add(device1);

        // Dummy Installations
        db.Installations.Add(new Installation
        {
            InstallationId = Guid.NewGuid(),
            DeviceId = device1.DeviceId,
            ProductId = Guid.NewGuid(),       // Dummy
            EntitlementId = Guid.NewGuid(),   // Dummy
            Version = "1.0",
            InstallDate = DateTime.UtcNow.AddDays(-10),
            LastSeen = DateTime.UtcNow
        });

        // Dummy Assignment
        db.UserAssignments.Add(new UserAssignment
        {
            AssignmentId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            ProductId = Guid.NewGuid(),
            EntitlementId = Guid.NewGuid(),
            AssignedAt = DateTime.UtcNow,
            LastUsedAt = DateTime.UtcNow.AddHours(-1),
            Status = "Active"
        });

        // Dummy UsageEvent
        db.UsageEvents.Add(new UsageEvent
        {
            UsageEventId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            DeviceId = device1.DeviceId,
            ProductId = Guid.NewGuid(),
            EventType = "session_start",
            Timestamp = DateTime.UtcNow
        });

        // Dummy Audit Snapshot
        db.ComplianceAudits.Add(new ComplianceAuditSnapshot
        {
            AuditId = Guid.NewGuid(),
            ProductId = Guid.NewGuid(),
            SnapshotTime = DateTime.UtcNow,
            AssignedCount = 10,
            UsedCount = 7,
            EntitlementsPurchased = 12,
            Status = "Compliant"
        });

        db.SaveChanges();
    }
}

app.Run();
