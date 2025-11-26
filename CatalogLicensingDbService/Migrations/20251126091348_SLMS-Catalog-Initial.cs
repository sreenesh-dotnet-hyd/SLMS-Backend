using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogLicensingDbService.Migrations
{
    /// <inheritdoc />
    public partial class SLMSCatalogInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Procurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResellerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportLevel = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procurements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareCatalogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareCatalogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LicenseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SoftwareCatalogId = table.Column<int>(type: "int", nullable: false),
                    LicenseTypeName = table.Column<int>(type: "int", nullable: false),
                    Metric = table.Column<int>(type: "int", nullable: false),
                    ConsumptionMethod = table.Column<int>(type: "int", nullable: false),
                    EnforcementType = table.Column<int>(type: "int", nullable: false),
                    VendorTerms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LicenseTypes_SoftwareCatalogs_SoftwareCatalogId",
                        column: x => x.SoftwareCatalogId,
                        principalTable: "SoftwareCatalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entitlements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    LicenseTypeId = table.Column<int>(type: "int", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatsPurchased = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActivationMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorInvoicePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitlements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entitlements_LicenseTypes_LicenseTypeId",
                        column: x => x.LicenseTypeId,
                        principalTable: "LicenseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntitlementFinances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    EntitlementId = table.Column<int>(type: "int", nullable: false),
                    CostTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostPerSeat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapexOpex = table.Column<int>(type: "int", nullable: false),
                    CostCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepreciationSchedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntitlementFinances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntitlementFinances_Entitlements_EntitlementId",
                        column: x => x.EntitlementId,
                        principalTable: "Entitlements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcurementEntitlementMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProcurementId = table.Column<int>(type: "int", nullable: false),
                    EntitlementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurementEntitlementMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcurementEntitlementMaps_Entitlements_EntitlementId",
                        column: x => x.EntitlementId,
                        principalTable: "Entitlements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcurementEntitlementMaps_Procurements_ProcurementId",
                        column: x => x.ProcurementId,
                        principalTable: "Procurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntitlementFinances_EntitlementId",
                table: "EntitlementFinances",
                column: "EntitlementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entitlements_LicenseTypeId",
                table: "Entitlements",
                column: "LicenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LicenseTypes_SoftwareCatalogId",
                table: "LicenseTypes",
                column: "SoftwareCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementEntitlementMaps_EntitlementId",
                table: "ProcurementEntitlementMaps",
                column: "EntitlementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementEntitlementMaps_ProcurementId",
                table: "ProcurementEntitlementMaps",
                column: "ProcurementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntitlementFinances");

            migrationBuilder.DropTable(
                name: "ProcurementEntitlementMaps");

            migrationBuilder.DropTable(
                name: "Entitlements");

            migrationBuilder.DropTable(
                name: "Procurements");

            migrationBuilder.DropTable(
                name: "LicenseTypes");

            migrationBuilder.DropTable(
                name: "SoftwareCatalogs");
        }
    }
}
