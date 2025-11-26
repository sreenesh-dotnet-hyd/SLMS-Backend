using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityAccessNotificationDbService.Migrations
{
    /// <inheritdoc />
    public partial class FirstTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Channel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.PermissionId });
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditLogs_Users_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RequestedBy = table.Column<int>(type: "int", nullable: false),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlows_Users_ApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlows_Users_RequestedBy",
                        column: x => x.RequestedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "id", "Channel", "type", "user_id" },
                values: new object[,]
                {
                    { 1, 1, "Notification_Type_1", 1 },
                    { 2, 2, "Notification_Type_2", 2 },
                    { 3, 3, "Notification_Type_3", 3 },
                    { 4, 0, "Notification_Type_4", 4 },
                    { 5, 1, "Notification_Type_5", 5 },
                    { 6, 2, "Notification_Type_6", 6 },
                    { 7, 3, "Notification_Type_7", 7 },
                    { 8, 0, "Notification_Type_8", 8 },
                    { 9, 1, "Notification_Type_9", 9 },
                    { 10, 2, "Notification_Type_10", 10 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { 1, "PERM_1", "Permission #1" },
                    { 2, "PERM_2", "Permission #2" },
                    { 3, "PERM_3", "Permission #3" },
                    { 4, "PERM_4", "Permission #4" },
                    { 5, "PERM_5", "Permission #5" },
                    { 6, "PERM_6", "Permission #6" },
                    { 7, "PERM_7", "Permission #7" },
                    { 8, "PERM_8", "Permission #8" },
                    { 9, "PERM_9", "Permission #9" },
                    { 10, "PERM_10", "Permission #10" }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Role description 1", "Role_1" },
                    { 2, "Role description 2", "Role_2" },
                    { 3, "Role description 3", "Role_3" },
                    { 4, "Role description 4", "Role_4" },
                    { 5, "Role description 5", "Role_5" },
                    { 6, "Role description 6", "Role_6" },
                    { 7, "Role description 7", "Role_7" },
                    { 8, "Role description 8", "Role_8" },
                    { 9, "Role description 9", "Role_9" },
                    { 10, "Role description 10", "Role_10" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "role_id", "user_id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Email", "ManagerId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D1", "user1@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D2", "user2@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3", "user3@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D4", "user4@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D5", "user5@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D6", "user6@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D7", "user7@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D8", "user8@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D9", "user9@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D10", "user10@company.com", 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "Id", "Action", "ActorId", "CreatedAt", "EntityId", "EntityType", "IpAddress", "NewValues", "OldValues", "UserAgent" },
                values: new object[,]
                {
                    { 1, "Performed Action 1", 1, new DateTime(2025, 11, 25, 9, 28, 24, 323, DateTimeKind.Utc), "1", "User", "192.168.1.1", "{\"new\":1}", "{\"old\":1}", "Mozilla/5.0" },
                    { 2, "Performed Action 2", 2, new DateTime(2025, 11, 24, 9, 28, 24, 323, DateTimeKind.Utc), "2", "User", "192.168.1.2", "{\"new\":2}", "{\"old\":2}", "Mozilla/5.0" },
                    { 3, "Performed Action 3", 3, new DateTime(2025, 11, 23, 9, 28, 24, 323, DateTimeKind.Utc), "3", "User", "192.168.1.3", "{\"new\":3}", "{\"old\":3}", "Mozilla/5.0" },
                    { 4, "Performed Action 4", 4, new DateTime(2025, 11, 22, 9, 28, 24, 323, DateTimeKind.Utc), "4", "User", "192.168.1.4", "{\"new\":4}", "{\"old\":4}", "Mozilla/5.0" },
                    { 5, "Performed Action 5", 5, new DateTime(2025, 11, 21, 9, 28, 24, 323, DateTimeKind.Utc), "5", "User", "192.168.1.5", "{\"new\":5}", "{\"old\":5}", "Mozilla/5.0" },
                    { 6, "Performed Action 6", 6, new DateTime(2025, 11, 20, 9, 28, 24, 323, DateTimeKind.Utc), "6", "User", "192.168.1.6", "{\"new\":6}", "{\"old\":6}", "Mozilla/5.0" },
                    { 7, "Performed Action 7", 7, new DateTime(2025, 11, 19, 9, 28, 24, 323, DateTimeKind.Utc), "7", "User", "192.168.1.7", "{\"new\":7}", "{\"old\":7}", "Mozilla/5.0" },
                    { 8, "Performed Action 8", 8, new DateTime(2025, 11, 18, 9, 28, 24, 323, DateTimeKind.Utc), "8", "User", "192.168.1.8", "{\"new\":8}", "{\"old\":8}", "Mozilla/5.0" },
                    { 9, "Performed Action 9", 9, new DateTime(2025, 11, 17, 9, 28, 24, 323, DateTimeKind.Utc), "9", "User", "192.168.1.9", "{\"new\":9}", "{\"old\":9}", "Mozilla/5.0" },
                    { 10, "Performed Action 10", 10, new DateTime(2025, 11, 16, 9, 28, 24, 323, DateTimeKind.Utc), "10", "User", "192.168.1.10", "{\"new\":10}", "{\"old\":10}", "Mozilla/5.0" }
                });

            migrationBuilder.InsertData(
                 table: "WorkFlows",
                 columns: new[] { "Id", "ApprovedBy", "CreatedAt", "EntityId", "EntityType", "Payload", "RequestedBy", "Status", "Type", "UpdatedAt" },
                 values: new object[,]
                 {
                    { 1, null, new DateTime(2025, 11, 25, 9, 21, 41, 804, DateTimeKind.Utc), "1", "License", "{\"workflow\":1}", 1, 1, 1, new DateTime(2025, 11, 26, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8626) },
                    { 2, null, new DateTime(2025, 11, 24, 9, 21, 41, 804, DateTimeKind.Utc), "2", "License", "{\"workflow\":2}", 2, 2, 2, new DateTime(2025, 11, 25, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8838) },
                    { 3, null, new DateTime(2025, 11, 23, 9, 21, 41, 804, DateTimeKind.Utc), "3", "License", "{\"workflow\":3}", 3, 3, 0, new DateTime(2025, 11, 24, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8842) },
                    { 4, null, new DateTime(2025, 11, 22, 9, 21, 41, 804, DateTimeKind.Utc), "4", "License", "{\"workflow\":4}", 4, 4, 1, new DateTime(2025, 11, 23, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8845) },
                    { 5, null, new DateTime(2025, 11, 21, 9, 21, 41, 804, DateTimeKind.Utc), "5", "License", "{\"workflow\":5}", 5, 0, 2, new DateTime(2025, 11, 22, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8847) },
                    { 6, null, new DateTime(2025, 11, 20, 9, 21, 41, 804, DateTimeKind.Utc), "6", "License", "{\"workflow\":6}", 6, 1, 0, new DateTime(2025, 11, 21, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8849) },
                    { 7, null, new DateTime(2025, 11, 19, 9, 21, 41, 804, DateTimeKind.Utc), "7", "License", "{\"workflow\":7}", 7, 2, 1, new DateTime(2025, 11, 20, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8850) },
                    { 8, null, new DateTime(2025, 11, 18, 9, 21, 41, 804, DateTimeKind.Utc), "8", "License", "{\"workflow\":8}", 8, 3, 2, new DateTime(2025, 11, 19, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8852) },
                    { 9, null, new DateTime(2025, 11, 17, 9, 21, 41, 804, DateTimeKind.Utc), "9", "License", "{\"workflow\":9}", 9, 4, 0, new DateTime(2025, 11, 18, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8854) },
                    { 10, null, new DateTime(2025, 11, 16, 9, 21, 41, 804, DateTimeKind.Utc), "10", "License", "{\"workflow\":10}", 10, 0, 1, new DateTime(2025, 11, 17, 9, 21, 41, 804, DateTimeKind.Utc).AddTicks(8856) }
                 });

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_ActorId",
                table: "AuditLogs",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlows_ApprovedBy",
                table: "WorkFlows",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlows_RequestedBy",
                table: "WorkFlows",
                column: "RequestedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "WorkFlows");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
