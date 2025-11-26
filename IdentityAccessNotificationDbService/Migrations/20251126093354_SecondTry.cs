using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityAccessNotificationDbService.Migrations
{
    /// <inheritdoc />
    public partial class SecondTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 1,
                column: "Channel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 2,
                column: "Channel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 3,
                column: "Channel",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 4,
                column: "Channel",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 5,
                column: "Channel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 6,
                column: "Channel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 7,
                column: "Channel",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 8,
                column: "Channel",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 9,
                column: "Channel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 10,
                column: "Channel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), 0, 0, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc), 1, 1, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), 2, 2, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), 3, 0, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), 4, 1, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), 0, 2, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), 1, 0, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc), 2, 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3, 2, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), 4, 0, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 24, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 22, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 21, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 20, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 17, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 16, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 1,
                column: "Channel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 2,
                column: "Channel",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 3,
                column: "Channel",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 4,
                column: "Channel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 5,
                column: "Channel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 6,
                column: "Channel",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 7,
                column: "Channel",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 8,
                column: "Channel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 9,
                column: "Channel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 10,
                column: "Channel",
                value: 2);

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(7878), 1, 1, new DateTime(2025, 11, 26, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 24, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8339), 2, 2, new DateTime(2025, 11, 25, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8344), 3, 0, new DateTime(2025, 11, 24, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 22, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8347), 4, 1, new DateTime(2025, 11, 23, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 21, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8350), 0, 2, new DateTime(2025, 11, 22, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 20, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8352), 1, 0, new DateTime(2025, 11, 21, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 19, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8354), 2, 1, new DateTime(2025, 11, 20, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 18, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8356), 3, 2, new DateTime(2025, 11, 19, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 17, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8358), 4, 0, new DateTime(2025, 11, 18, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Status", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 16, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8361), 0, 1, new DateTime(2025, 11, 17, 9, 28, 24, 323, DateTimeKind.Utc).AddTicks(8361) });
        }
    }
}
