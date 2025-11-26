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
            migrationBuilder.InsertData(
                table: "audits",
                columns: new[] { "AuditId", "AssignedCount", "EntitlementsPurchased", "ProductId", "SnapshotTime", "Status", "UsedCount" },
                values: new object[,]
                {
                    { new Guid("80000000-0000-0000-0000-000000000001"), 50, 55, new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2024, 10, 3, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 45 },
                    { new Guid("80000000-0000-0000-0000-000000000002"), 60, 55, new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Utc), "OverLicensed", 40 },
                    { new Guid("80000000-0000-0000-0000-000000000003"), 20, 20, new Guid("10000000-0000-0000-0000-000000000007"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 18 },
                    { new Guid("80000000-0000-0000-0000-000000000004"), 25, 20, new Guid("10000000-0000-0000-0000-000000000007"), new DateTime(2024, 12, 25, 9, 0, 0, 0, DateTimeKind.Utc), "OverLicensed", 5 },
                    { new Guid("80000000-0000-0000-0000-000000000005"), 5, 5, new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2024, 9, 3, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 5 },
                    { new Guid("80000000-0000-0000-0000-000000000006"), 7, 5, new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), "UnderLicensed", 7 },
                    { new Guid("80000000-0000-0000-0000-000000000007"), 30, 30, new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2024, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 29 },
                    { new Guid("80000000-0000-0000-0000-000000000008"), 35, 35, new Guid("10000000-0000-0000-0000-000000000009"), new DateTime(2024, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 32 },
                    { new Guid("80000000-0000-0000-0000-000000000009"), 15, 20, new Guid("10000000-0000-0000-0000-000000000006"), new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Utc), "OverLicensed", 3 },
                    { new Guid("80000000-0000-0000-0000-000000000010"), 10, 10, new Guid("10000000-0000-0000-0000-000000000008"), new DateTime(2024, 11, 17, 9, 0, 0, 0, DateTimeKind.Utc), "Compliant", 9 }
                });

            migrationBuilder.InsertData(
                table: "devices",
                columns: new[] { "DeviceId", "DepartmentId", "DeviceType", "Hostname", "LastSeen", "OwnerUserId", "Status" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("40000000-0000-0000-0000-000000000001"), "Desktop", "DESKTOP-IT-01", new DateTime(2025, 1, 1, 9, 10, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000001"), "Active" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("40000000-0000-0000-0000-000000000002"), "Laptop", "LAPTOP-FIN-01", new DateTime(2025, 1, 1, 9, 20, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000002"), "Active" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("40000000-0000-0000-0000-000000000002"), "Laptop", "LAPTOP-FIN-02", new DateTime(2025, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000007"), "Active" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("40000000-0000-0000-0000-000000000003"), "Laptop", "LAPTOP-HR-01", new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000003"), "Active" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("40000000-0000-0000-0000-000000000004"), "Server", "SERVER-APP-01", new DateTime(2025, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000004"), "Active" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("40000000-0000-0000-0000-000000000004"), "Server", "SERVER-DB-01", new DateTime(2024, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000004"), "Active" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("40000000-0000-0000-0000-000000000004"), "Laptop", "LAPTOP-ENG-01", new DateTime(2025, 1, 1, 9, 5, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000005"), "Active" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("40000000-0000-0000-0000-000000000004"), "Laptop", "LAPTOP-ENG-02", new DateTime(2025, 1, 1, 8, 55, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000004"), "Inactive" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("40000000-0000-0000-0000-000000000001"), "VDI", "VDI-IT-01", new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000008"), "Active" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("40000000-0000-0000-0000-000000000005"), "Laptop", "LAPTOP-SALES-01", new DateTime(2025, 1, 1, 9, 45, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000006"), "Active" }
                });

            migrationBuilder.InsertData(
                table: "user_assignments",
                columns: new[] { "AssignmentId", "AssignedAt", "EntitlementId", "ExemptFlag", "LastUsedAt", "ProductId", "RevokedAt", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("60000000-0000-0000-0000-000000000001"), new DateTime(2024, 9, 3, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000001"), false, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000001"), null, "Active", new Guid("30000000-0000-0000-0000-000000000001") },
                    { new Guid("60000000-0000-0000-0000-000000000002"), new DateTime(2024, 9, 23, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000002"), false, new DateTime(2024, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000001"), null, "Active", new Guid("30000000-0000-0000-0000-000000000002") },
                    { new Guid("60000000-0000-0000-0000-000000000003"), new DateTime(2024, 10, 13, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000008"), false, new DateTime(2024, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000007"), null, "Active", new Guid("30000000-0000-0000-0000-000000000007") },
                    { new Guid("60000000-0000-0000-0000-000000000004"), new DateTime(2024, 10, 3, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000001"), false, new DateTime(2024, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000001"), null, "Active", new Guid("30000000-0000-0000-0000-000000000003") },
                    { new Guid("60000000-0000-0000-0000-000000000005"), new DateTime(2024, 6, 15, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000005"), true, new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000004"), null, "Active", new Guid("30000000-0000-0000-0000-000000000004") },
                    { new Guid("60000000-0000-0000-0000-000000000006"), new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000004"), false, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000003"), null, "Active", new Guid("30000000-0000-0000-0000-000000000005") },
                    { new Guid("60000000-0000-0000-0000-000000000007"), new DateTime(2024, 11, 22, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000006"), false, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000005"), null, "Active", new Guid("30000000-0000-0000-0000-000000000006") },
                    { new Guid("60000000-0000-0000-0000-000000000008"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000010"), false, new DateTime(2024, 12, 29, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000009"), null, "Active", new Guid("30000000-0000-0000-0000-000000000009") },
                    { new Guid("60000000-0000-0000-0000-000000000009"), new DateTime(2024, 10, 23, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000007"), false, new DateTime(2024, 12, 25, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000006"), null, "Active", new Guid("30000000-0000-0000-0000-000000000008") },
                    { new Guid("60000000-0000-0000-0000-000000000010"), new DateTime(2024, 7, 5, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("20000000-0000-0000-0000-000000000001"), false, new DateTime(2024, 10, 3, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), "Revoked", new Guid("30000000-0000-0000-0000-000000000010") }
                });

            migrationBuilder.InsertData(
                table: "installations",
                columns: new[] { "InstallationId", "DeviceId", "Discovered", "EntitlementId", "InstallDate", "LastSeen", "ProductId", "Version" },
                values: new object[,]
                {
                    { new Guid("50000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 10, 3, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 9, 10, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000001"), "Microsoft 365 Apps" },
                    { new Guid("50000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), true, new Guid("20000000-0000-0000-0000-000000000002"), new DateTime(2024, 10, 23, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 9, 20, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000001"), "Microsoft 365 Apps" },
                    { new Guid("50000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), true, new Guid("20000000-0000-0000-0000-000000000008"), new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000007"), "Power BI Desktop" },
                    { new Guid("50000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), true, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 9, 3, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000001"), "Microsoft 365 Apps" },
                    { new Guid("50000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), true, new Guid("20000000-0000-0000-0000-000000000009"), new DateTime(2024, 7, 5, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000008"), "Jira Server 9.0" },
                    { new Guid("50000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), true, new Guid("20000000-0000-0000-0000-000000000005"), new DateTime(2024, 6, 15, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000004"), "SQL Server 2019" },
                    { new Guid("50000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), true, new Guid("20000000-0000-0000-0000-000000000004"), new DateTime(2024, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 9, 5, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000003"), "VS 2022 Enterprise" },
                    { new Guid("50000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), true, new Guid("20000000-0000-0000-0000-000000000003"), new DateTime(2024, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 8, 55, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000002"), "Photoshop 2024" },
                    { new Guid("50000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), true, new Guid("20000000-0000-0000-0000-000000000007"), new DateTime(2024, 11, 17, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000006"), "Slack Desktop" },
                    { new Guid("50000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000010"), true, new Guid("20000000-0000-0000-0000-000000000006"), new DateTime(2024, 12, 12, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 9, 45, 0, 0, DateTimeKind.Utc), new Guid("10000000-0000-0000-0000-000000000005"), "Zoom Client 5.x" }
                });

            migrationBuilder.InsertData(
                table: "usage_tracking",
                columns: new[] { "UsageEventId", "DeviceId", "DurationSeconds", "EventType", "ProductId", "SessionId", "Timestamp", "UserId" },
                values: new object[,]
                {
                    { new Guid("70000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 5400, "session_start", new Guid("10000000-0000-0000-0000-000000000001"), new Guid("71000000-0000-0000-0000-000000000001"), new DateTime(2025, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000001") },
                    { new Guid("70000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 3600, "session_start", new Guid("10000000-0000-0000-0000-000000000001"), new Guid("71000000-0000-0000-0000-000000000002"), new DateTime(2025, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000002") },
                    { new Guid("70000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 900, "report_refresh", new Guid("10000000-0000-0000-0000-000000000007"), null, new DateTime(2025, 1, 1, 5, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000007") },
                    { new Guid("70000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 2700, "session_start", new Guid("10000000-0000-0000-0000-000000000001"), new Guid("71000000-0000-0000-0000-000000000004"), new DateTime(2025, 1, 1, 4, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000003") },
                    { new Guid("70000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006"), 7200, "db_maintenance", new Guid("10000000-0000-0000-0000-000000000004"), null, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000004") },
                    { new Guid("70000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000007"), 1200, "build_solution", new Guid("10000000-0000-0000-0000-000000000003"), null, new DateTime(2025, 1, 1, 7, 30, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000005") },
                    { new Guid("70000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000010"), 3600, "meeting_join", new Guid("10000000-0000-0000-0000-000000000005"), new Guid("71000000-0000-0000-0000-000000000007"), new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000006") },
                    { new Guid("70000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000010"), 1800, "chat_activity", new Guid("10000000-0000-0000-0000-000000000009"), null, new DateTime(2025, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000009") },
                    { new Guid("70000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 300, "message_post", new Guid("10000000-0000-0000-0000-000000000006"), null, new DateTime(2024, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000008") },
                    { new Guid("70000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000004"), 1800, "session_start", new Guid("10000000-0000-0000-0000-000000000001"), new Guid("71000000-0000-0000-0000-000000000010"), new DateTime(2024, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("30000000-0000-0000-0000-000000000010") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "audits",
                keyColumn: "AuditId",
                keyValue: new Guid("80000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "installations",
                keyColumn: "InstallationId",
                keyValue: new Guid("50000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "usage_tracking",
                keyColumn: "UsageEventId",
                keyValue: new Guid("70000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "user_assignments",
                keyColumn: "AssignmentId",
                keyValue: new Guid("60000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));
        }
    }
}
