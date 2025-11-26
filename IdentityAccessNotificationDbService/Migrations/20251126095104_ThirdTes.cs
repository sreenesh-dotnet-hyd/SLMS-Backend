using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityAccessNotificationDbService.Migrations
{
    /// <inheritdoc />
    public partial class ThirdTes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #1", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #2", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #3", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #4", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #5", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #6", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #7", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #8", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #9", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "192.168.1.10", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Action", "CreatedAt", "EntityType", "NewValues", "OldValues" },
                values: new object[] { "Updated workflow #10", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Workflow", "{\"status\":\"Approved\"}", "{\"status\":\"Pending\"}" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 1,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 2,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 3,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 4,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 5,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 6,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 7,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 8,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 9,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 10,
                column: "type",
                value: "WorkflowUpdate");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Description" },
                values: new object[] { "VIEW_SOFTWARE", "View software catalog" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Description" },
                values: new object[] { "MANAGE_LICENSES", "Assign or revoke licenses" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Description" },
                values: new object[] { "VIEW_FINANCE", "View finance reports & allocation" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Description" },
                values: new object[] { "VIEW_AUDIT", "View audit logs" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Read-only access", "Viewer" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Manage licenses and workflows", "IT Admin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Finance and cost allocation access", "Finance Team" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "View audit logs & compliance reports", "Auditor" });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "role_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "role_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "role_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "role_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 9,
                column: "role_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 10,
                column: "role_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "IT", "john.admin@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "IT", "sanjay.it@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "Finance", "priya.finance@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "Finance", "rohan.finance@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "Audit", "meera.audit@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "Audit", "dev.audit@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "HR", "arun.viewer@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "Marketing", "tina.viewer@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "Engineering", "raj.employee@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "Engineering", "nisha.employee@company.com" });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApprovedBy", "CreatedAt", "EntityId", "Payload", "RequestedBy", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "101", "{\"license\":\"Figma\"}", 9, new DateTime(2025, 1, 1, 2, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApprovedBy", "CreatedAt", "EntityId", "Payload", "RequestedBy", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), "102", "{\"license\":\"Slack\"}", 10, new DateTime(2025, 1, 2, 3, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 1", new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.1", "{\"new\":1}", "{\"old\":1}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 2", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.2", "{\"new\":2}", "{\"old\":2}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 3", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.3", "{\"new\":3}", "{\"old\":3}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 4", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.4", "{\"new\":4}", "{\"old\":4}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 5", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.5", "{\"new\":5}", "{\"old\":5}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 6", new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.6", "{\"new\":6}", "{\"old\":6}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 7", new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.7", "{\"new\":7}", "{\"old\":7}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 8", new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.8", "{\"new\":8}", "{\"old\":8}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Action", "CreatedAt", "EntityType", "IpAddress", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 9", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), "User", "192.168.1.9", "{\"new\":9}", "{\"old\":9}" });

            migrationBuilder.UpdateData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Action", "CreatedAt", "EntityType", "NewValues", "OldValues" },
                values: new object[] { "Performed Action 10", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), "User", "{\"new\":10}", "{\"old\":10}" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 1,
                column: "type",
                value: "Notification_Type_1");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 2,
                column: "type",
                value: "Notification_Type_2");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 3,
                column: "type",
                value: "Notification_Type_3");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 4,
                column: "type",
                value: "Notification_Type_4");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 5,
                column: "type",
                value: "Notification_Type_5");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 6,
                column: "type",
                value: "Notification_Type_6");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 7,
                column: "type",
                value: "Notification_Type_7");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 8,
                column: "type",
                value: "Notification_Type_8");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 9,
                column: "type",
                value: "Notification_Type_9");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "id",
                keyValue: 10,
                column: "type",
                value: "Notification_Type_10");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Description" },
                values: new object[] { "PERM_1", "Permission #1" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Description" },
                values: new object[] { "PERM_2", "Permission #2" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Description" },
                values: new object[] { "PERM_3", "Permission #3" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Description" },
                values: new object[] { "PERM_4", "Permission #4" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
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
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Role description 1", "Role_1" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Role description 2", "Role_2" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Role description 3", "Role_3" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Role description 4", "Role_4" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 5, "Role description 5", "Role_5" },
                    { 6, "Role description 6", "Role_6" },
                    { 7, "Role description 7", "Role_7" },
                    { 8, "Role description 8", "Role_8" },
                    { 9, "Role description 9", "Role_9" },
                    { 10, "Role description 10", "Role_10" }
                });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "role_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "role_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "role_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "role_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "role_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "role_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 9,
                column: "role_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 10,
                column: "role_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D1", "user1@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D2", "user2@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D3", "user3@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D4", "user4@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D5", "user5@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D6", "user6@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D7", "user7@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D8", "user8@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D9", "user9@company.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Email" },
                values: new object[] { "D10", "user10@company.com" });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApprovedBy", "CreatedAt", "EntityId", "Payload", "RequestedBy", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), "1", "{\"workflow\":1}", 1, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "WorkFlows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApprovedBy", "CreatedAt", "EntityId", "Payload", "RequestedBy", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc), "2", "{\"workflow\":2}", 2, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "WorkFlows",
                columns: new[] { "Id", "ApprovedBy", "CreatedAt", "EntityId", "EntityType", "Payload", "RequestedBy", "Status", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), "3", "License", "{\"workflow\":3}", 3, 2, 2, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, null, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "4", "License", "{\"workflow\":4}", 4, 3, 0, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, null, new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), "5", "License", "{\"workflow\":5}", 5, 4, 1, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, null, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), "6", "License", "{\"workflow\":6}", 6, 0, 2, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, null, new DateTime(2025, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "7", "License", "{\"workflow\":7}", 7, 1, 0, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, null, new DateTime(2025, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc), "8", "License", "{\"workflow\":8}", 8, 2, 1, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, null, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), "9", "License", "{\"workflow\":9}", 9, 3, 2, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, null, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), "10", "License", "{\"workflow\":10}", 10, 4, 0, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }
    }
}
