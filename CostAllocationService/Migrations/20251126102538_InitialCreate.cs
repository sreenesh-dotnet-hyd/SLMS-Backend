using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CostAllocationService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manager_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cost_allocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntitlementId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    AllocationRule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AllocatedCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CalculatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cost_allocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cost_allocation_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "manager_id", "Name" },
                values: new object[,]
                {
                    { 1, 101, "Engineering" },
                    { 2, 102, "Finance" },
                    { 3, 103, "HR" },
                    { 4, 104, "Marketing" },
                    { 5, 105, "Sales" },
                    { 6, 106, "IT Support" },
                    { 7, 107, "Security" },
                    { 8, 108, "Infrastructure" },
                    { 9, 109, "Product" },
                    { 10, 110, "Operations" }
                });

            migrationBuilder.InsertData(
                table: "cost_allocation",
                columns: new[] { "Id", "AllocatedCost", "AllocationRule", "CalculatedAt", "DepartmentId", "EntitlementId", "Percentage" },
                values: new object[,]
                {
                    { 1, 20000m, "fixed_split", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20m },
                    { 2, 10000m, "fixed_split", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10m },
                    { 3, 30000m, "usage_based", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, 30m },
                    { 4, 15000m, "usage_based", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, 15m },
                    { 5, 25000m, "fixed_split", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, 25m },
                    { 6, 5000m, "fixed_split", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, 5m },
                    { 7, 40000m, "usage_based", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, 40m },
                    { 8, 10000m, "usage_based", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, 10m },
                    { 9, 15000m, "fixed_split", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5, 15m },
                    { 10, 5000m, "fixed_split", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 5, 5m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cost_allocation_DepartmentId",
                table: "cost_allocation",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cost_allocation");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
