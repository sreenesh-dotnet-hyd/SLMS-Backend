using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CatalogLicensingDbService.Migrations
{
    /// <inheritdoc />
    public partial class catalogsecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SKU",
                table: "Entitlements",
                newName: "Sku");

            migrationBuilder.InsertData(
                table: "Procurements",
                columns: new[] { "Id", "ContractId", "CreatedAt", "InvoiceId", "PurchaseOrderNumber", "ResellerName", "SupportLevel", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "CON-PS-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-1001", "PO-1001", "Softline India", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "CON-ORA-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-2001", "PO-2001", "Redington", 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "CON-JIRA-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-3001", "PO-3001", "ACPL", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "CON-MS-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-4001", "PO-4001", "Softcell", 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "CON-FGM-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-5001", "PO-5001", "Ingram", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, "CON-VS-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-6001", "PO-6001", "Wipro", 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, "CON-PM-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-7001", "PO-7001", "Redington", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, "CON-SLK-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-8001", "PO-8001", "ACPL", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, "CON-ACAD-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-9001", "PO-9001", "Softcell", 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, "CON-VMW-01", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INV-10001", "PO-10001", "Ingram", 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "SoftwareCatalogs",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "ProductName", "Status", "UpdatedAt", "Vendor" },
                values: new object[,]
                {
                    { 1, "Design", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Image editing suite", "Adobe Photoshop", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Adobe" },
                    { 2, "Database", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Enterprise RDBMS", "Oracle DB", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Oracle" },
                    { 3, "PM", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Project Management", "Jira", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Atlassian" },
                    { 4, "Productivity", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Office Suite", "MS Office", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Microsoft" },
                    { 5, "Design", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "UI/UX Design", "Figma", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Figma Inc" },
                    { 6, "Development", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Development IDE", "Visual Studio", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Microsoft" },
                    { 7, "Development", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "API Testing Tool", "Postman", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Postman Inc" },
                    { 8, "Communication", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Communication", "Slack", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Slack Tech" },
                    { 9, "CAD", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Engineering Design", "AutoCAD", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Autodesk" },
                    { 10, "Infrastructure", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Virtualization platform", "VMware ESXi", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "VMware" }
                });

            migrationBuilder.InsertData(
                table: "LicenseTypes",
                columns: new[] { "Id", "ConsumptionMethod", "CreatedAt", "EnforcementType", "LicenseTypeName", "Metric", "SoftwareCatalogId", "UpdatedAt", "VendorTerms" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 2, 1, 0, 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Adobe ETLA" },
                    { 2, 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 4, 0, 2, 2, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Oracle CPU Rules" },
                    { 3, 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 1, 3, 0, 3, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Atlassian Cloud" },
                    { 4, 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 2, 1, 0, 4, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Microsoft Enterprise" },
                    { 5, 2, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 1, 3, 0, 5, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Figma Cloud" },
                    { 6, 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 0, 0, 1, 6, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "MS VS License" },
                    { 7, 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 1, 3, 0, 7, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Postman Cloud" },
                    { 8, 2, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 2, 3, 0, 8, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Slack Cloud" },
                    { 9, 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 3, 0, 1, 9, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Autodesk License" },
                    { 10, 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 4, 0, 3, 10, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "VMware Terms" }
                });

            migrationBuilder.InsertData(
                table: "Entitlements",
                columns: new[] { "Id", "ActivationMethod", "CreatedAt", "ExpiryDate", "LicenseTypeId", "PurchaseDate", "SeatsPurchased", "Sku", "Status", "UpdatedAt", "VendorInvoicePath" },
                values: new object[,]
                {
                    { 1, "SSO", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 50, "PS-100", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/ps1.pdf" },
                    { 2, "Server", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, 2, new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 4, "ORA-CPU-01", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/oracle.pdf" },
                    { 3, "Account", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Utc), 100, "JIRA-CLD", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/jira1.pdf" },
                    { 4, "SSO", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 300, "MS-365", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/ms1.pdf" },
                    { 5, "Account", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc), 20, "FGM-CLOUD", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/figma.pdf" },
                    { 6, "Key", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, 6, new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 10, "VS-PRO", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/vs1.pdf" },
                    { 7, "Account", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 8, 26, 0, 0, 0, 0, DateTimeKind.Utc), 7, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Utc), 50, "POSTMAN-1", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/pm.pdf" },
                    { 8, "SSO", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2027, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 8, new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 200, "SLK-TEAM", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/slack.pdf" },
                    { 9, "HW Lock", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, 9, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 10, "ACAD-01", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/acad.pdf" },
                    { 10, "Server", new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), null, 10, new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), 3, "VMW-ESXI", 0, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "/inv/esxi.pdf" }
                });

            migrationBuilder.InsertData(
                table: "EntitlementFinances",
                columns: new[] { "Id", "CapexOpex", "CostCenter", "CostPerSeat", "CostTotal", "CreatedAt", "Currency", "DepreciationSchedule", "EntitlementId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 0, "Design", 12000m, 600000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INR", "{}", 1, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 0, "IT", 50000m, 200000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "USD", "{}", 2, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 1, "PMO", 1500m, 150000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "USD", "{}", 3, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, 1, "IT", 2600m, 800000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INR", "{}", 4, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, 1, "Design", 12500m, 250000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INR", "{}", 5, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, 0, "Dev", 50000m, 500000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INR", "{}", 6, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, 1, "QA", 2000m, 100000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "USD", "{}", 7, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, 1, "IT", 1500m, 300000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "USD", "{}", 8, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, 0, "Engineering", 70000m, 700000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "INR", "{}", 9, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, 0, "Infra", 300000m, 900000m, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), "USD", "{}", 10, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ProcurementEntitlementMaps",
                columns: new[] { "Id", "EntitlementId", "ProcurementId" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EntitlementFinances",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProcurementEntitlementMaps",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Entitlements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Procurements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LicenseTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SoftwareCatalogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Entitlements",
                newName: "SKU");
        }
    }
}
