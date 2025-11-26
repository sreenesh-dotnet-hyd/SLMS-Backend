using AssignmentsInventoryMicroService.Data;
using AssignmentsInventoryMicroService.Middleware;
using AssignmentsInventoryMicroService.Models;
using AssignmentsInventoryMicroService.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add controllers and JSON options
builder.Services.AddControllers()
    .AddJsonOptions(opts =>
    {
        opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register DbContext
builder.Services.AddDbContext<AssignmentsInventoryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AssignmentsInventoryDb")));

// Register repositories
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 🔹 Add global exception handling BEFORE routing & HTTPS redirection
app.UseGlobalExceptionHandling();

app.UseHttpsRedirection();

// JWT will be added later here:
// app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

// 🔹 Seeding (only runs if DB empty)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AssignmentsInventoryDbContext>();
    db.Database.EnsureCreated(); // Ensures DB exists

    if (!db.Devices.Any())
    {
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

        db.Installations.Add(new Installation
        {
            InstallationId = Guid.NewGuid(),
            DeviceId = device1.DeviceId,
            ProductId = Guid.NewGuid(),
            EntitlementId = Guid.NewGuid(),
            Version = "1.0",
            InstallDate = DateTime.UtcNow.AddDays(-10),
            LastSeen = DateTime.UtcNow
        });

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

        db.UsageEvents.Add(new UsageEvent
        {
            UsageEventId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            DeviceId = device1.DeviceId,
            ProductId = Guid.NewGuid(),
            EventType = "session_start",
            Timestamp = DateTime.UtcNow
        });

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
