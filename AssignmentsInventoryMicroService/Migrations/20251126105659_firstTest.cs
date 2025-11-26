using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssignmentsInventoryMicroService.Migrations
{
    /// <inheritdoc />
    public partial class firstTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "audits",
                columns: table => new
                {
                    AuditId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SnapshotTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedCount = table.Column<int>(type: "int", nullable: false),
                    UsedCount = table.Column<int>(type: "int", nullable: false),
                    EntitlementsPurchased = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_audits", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "devices",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hostname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnerUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastSeen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devices", x => x.DeviceId);
                });

            migrationBuilder.CreateTable(
                name: "user_assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntitlementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevokedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUsedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExemptFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_assignments", x => x.AssignmentId);
                });

            migrationBuilder.CreateTable(
                name: "installations",
                columns: table => new
                {
                    InstallationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntitlementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastSeen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discovered = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_installations", x => x.InstallationId);
                    table.ForeignKey(
                        name: "FK_installations_devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "devices",
                        principalColumn: "DeviceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usage_tracking",
                columns: table => new
                {
                    UsageEventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DurationSeconds = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usage_tracking", x => x.UsageEventId);
                    table.ForeignKey(
                        name: "FK_usage_tracking_devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "devices",
                        principalColumn: "DeviceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "audits",
                columns: new[] { "AuditId", "AssignedCount", "EntitlementsPurchased", "ProductId", "SnapshotTime", "Status", "UsedCount" },
                values: new object[,]
                {
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000001"), 50, 55, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), new DateTime(2024, 10, 3, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 45 },
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000002"), 60, 55, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Utc), "OverLicensed", 40 },
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000003"), 20, 20, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7707"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 18 },
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000004"), 25, 20, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7707"), new DateTime(2024, 12, 25, 9, 0, 0, 0, DateTimeKind.Utc), "OverLicensed", 5 },
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000005"), 5, 5, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7704"), new DateTime(2024, 9, 3, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 5 },
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000006"), 7, 5, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7704"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), "UnderLicensed", 7 },
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000007"), 30, 30, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7705"), new DateTime(2024, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 29 },
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000008"), 35, 35, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7709"), new DateTime(2024, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 32 },
                    { new Guid("fe10dc32-ab45-4e67-8901-000000000009"), 15, 20, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7706"), new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Utc), "OverLicensed", 3 },
                    { new Guid("fe10dc32-ab45-4e67-8901-00000000000a"), 10, 10, new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7708"), new DateTime(2024, 11, 17, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 9 }
                });

            migrationBuilder.InsertData(
                table: "devices",
                columns: new[] { "DeviceId", "DepartmentId", "DeviceType", "Hostname", "LastSeen", "OwnerUserId", "Status" },
                values: new object[,]
                {
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789001"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c1"), "Desktop", "DESKTOP-IT-01", new DateTime(2025, 1, 1, 9, 10, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334401"), "Active" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789002"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c2"), "Laptop", "LAPTOP-FIN-01", new DateTime(2025, 1, 1, 9, 20, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334402"), "Active" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789003"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c2"), "Laptop", "LAPTOP-FIN-02", new DateTime(2025, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334407"), "Active" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789004"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c3"), "Laptop", "LAPTOP-HR-01", new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334403"), "Active" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789005"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c4"), "Server", "SERVER-APP-01", new DateTime(2025, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334404"), "Active" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789006"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c4"), "Server", "SERVER-DB-01", new DateTime(2024, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334404"), "Active" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789007"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c4"), "Laptop", "LAPTOP-ENG-01", new DateTime(2025, 1, 1, 9, 5, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334405"), "Active" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789008"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c4"), "Laptop", "LAPTOP-ENG-02", new DateTime(2025, 1, 1, 8, 55, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334404"), "Inactive" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789009"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c1"), "VDI", "VDI-IT-01", new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334408"), "Active" },
                    { new Guid("f1aa2b3c-4d5e-4678-9a0b-12345678900a"), new Guid("d4a1f530-23a7-4a8a-9b8c-11aa22bb33c5"), "Laptop", "LAPTOP-SALES-01", new DateTime(2025, 1, 1, 9, 45, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334406"), "Active" }
                });

            migrationBuilder.InsertData(
                table: "user_assignments",
                columns: new[] { "AssignmentId", "AssignedAt", "EntitlementId", "ExemptFlag", "LastUsedAt", "ProductId", "RevokedAt", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000001"), new DateTime(2024, 9, 3, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc01"), false, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334401") },
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000002"), new DateTime(2024, 9, 23, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc02"), false, new DateTime(2024, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334402") },
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000003"), new DateTime(2024, 10, 13, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc08"), false, new DateTime(2024, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7707"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334407") },
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000004"), new DateTime(2024, 10, 3, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc01"), false, new DateTime(2024, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334403") },
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000005"), new DateTime(2024, 6, 15, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc05"), true, new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7704"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334404") },
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000006"), new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc04"), false, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7703"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334405") },
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000007"), new DateTime(2024, 11, 22, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc06"), false, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7705"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334406") },
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000008"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc0a"), false, new DateTime(2024, 12, 29, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7709"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334409") },
                    { new Guid("aa11bb22-cc33-44dd-8855-000000000009"), new DateTime(2024, 10, 23, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc07"), false, new DateTime(2024, 12, 25, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7706"), null, "Active", new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334408") },
                    { new Guid("aa11bb22-cc33-44dd-8855-00000000000a"), new DateTime(2024, 7, 5, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc01"), false, new DateTime(2024, 10, 3, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), "Revoked", new Guid("e2f7b1c0-9a10-4ce3-bf21-00112233440a") }
                });

            migrationBuilder.InsertData(
                table: "installations",
                columns: new[] { "InstallationId", "DeviceId", "Discovered", "EntitlementId", "InstallDate", "LastSeen", "ProductId", "Version" },
                values: new object[,]
                {
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000001"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789001"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc01"), new DateTime(2024, 10, 3, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 9, 10, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), "Microsoft 365 Apps" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000002"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789002"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc02"), new DateTime(2024, 10, 23, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 9, 20, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), "Microsoft 365 Apps" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000003"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789003"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc08"), new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7707"), "Power BI Desktop" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000004"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789004"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc01"), new DateTime(2024, 9, 3, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), "Microsoft 365 Apps" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000005"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789005"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc09"), new DateTime(2024, 7, 5, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7708"), "Jira Server 9.0" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000006"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789006"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc05"), new DateTime(2024, 6, 15, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7704"), "SQL Server 2019" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000007"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789007"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc04"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 9, 5, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7703"), "VS 2022 Enterprise" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000008"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789008"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc03"), new DateTime(2024, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 8, 55, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7702"), "Photoshop 2024" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-000000000009"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789009"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc07"), new DateTime(2024, 11, 17, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7706"), "Slack Desktop" },
                    { new Guid("c1d2e3f4-1111-4a2b-9c3d-00000000000a"), new Guid("f1aa2b3c-4d5e-4678-9a0b-12345678900a"), true, new Guid("b3c4d5e6-7788-49aa-bbcc-8899aabbcc06"), new DateTime(2024, 12, 12, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 9, 45, 0, 0, DateTimeKind.Utc), new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7705"), "Zoom Client 5.x" }
                });

            migrationBuilder.InsertData(
                table: "usage_tracking",
                columns: new[] { "UsageEventId", "DeviceId", "DurationSeconds", "EventType", "ProductId", "SessionId", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000001"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789001"), 5400, "session_start", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), new Guid("91000000-0000-0000-0000-000000000001"), new DateTime(2025, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334401") },
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000002"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789002"), 3600, "session_start", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), new Guid("91000000-0000-0000-0000-000000000002"), new DateTime(2025, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334402") },
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000003"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789003"), 900, "report_refresh", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7707"), null, new DateTime(2025, 1, 1, 5, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334407") },
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000004"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789004"), 2700, "session_start", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), new Guid("91000000-0000-0000-0000-000000000004"), new DateTime(2025, 1, 1, 4, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334403") },
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000005"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789006"), 7200, "db_maintenance", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7704"), null, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334404") },
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000006"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789007"), 1200, "build_solution", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7703"), null, new DateTime(2025, 1, 1, 7, 30, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334405") },
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000007"), new Guid("f1aa2b3c-4d5e-4678-9a0b-12345678900a"), 3600, "meeting_join", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7705"), new Guid("91000000-0000-0000-0000-000000000007"), new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334406") },
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000008"), new Guid("f1aa2b3c-4d5e-4678-9a0b-12345678900a"), 1800, "chat_activity", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7709"), null, new DateTime(2025, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334409") },
                    { new Guid("dd11ee22-ff33-44aa-9900-000000000009"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789009"), 300, "message_post", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7706"), null, new DateTime(2024, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-001122334408") },
                    { new Guid("dd11ee22-ff33-44aa-9900-00000000000a"), new Guid("f1aa2b3c-4d5e-4678-9a0b-123456789004"), 1800, "session_start", new Guid("a8b6c3de-1011-4f2c-94aa-55bb66cc7701"), new Guid("91000000-0000-0000-0000-000000000010"), new DateTime(2024, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("e2f7b1c0-9a10-4ce3-bf21-00112233440a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_installations_DeviceId",
                table: "installations",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_usage_tracking_DeviceId",
                table: "usage_tracking",
                column: "DeviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "audits");

            migrationBuilder.DropTable(
                name: "installations");

            migrationBuilder.DropTable(
                name: "usage_tracking");

            migrationBuilder.DropTable(
                name: "user_assignments");

            migrationBuilder.DropTable(
                name: "devices");
        }
    }
}
