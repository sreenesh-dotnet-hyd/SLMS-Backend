using Microsoft.EntityFrameworkCore;

namespace CatalogLicensingDbService.Models
{
   
    
        public class AppDbContext : DbContext
        {
            public DbSet<SoftwareCatalog> SoftwareCatalogs { get; set; }
            public DbSet<LicenseType> LicenseTypes { get; set; }
            public DbSet<Entitlement> Entitlements { get; set; }
            public DbSet<EntitlementFinance> EntitlementFinances { get; set; }
            public DbSet<Procurement> Procurements { get; set; }
            public DbSet<ProcurementEntitlementMap> ProcurementEntitlementMaps { get; set; }

            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }
       

        protected override void OnModelCreating(ModelBuilder model)
            {
                base.OnModelCreating(model);
            var seedCreatedAt = new DateTime(2025, 11, 26, 0, 0, 0, DateTimeKind.Utc);
            // -------------------------
            // SOFTWARE CATALOG (10 rows)
            // -------------------------
            model.Entity<SoftwareCatalog>().HasData(
                    new { Id = 1, ProductName = "Adobe Photoshop", Vendor = "Adobe", Description = "Image editing suite", Category = "Design", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 2, ProductName = "Oracle DB", Vendor = "Oracle", Description = "Enterprise RDBMS", Category = "Database", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 3, ProductName = "Jira", Vendor = "Atlassian", Description = "Project Management", Category = "PM", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 4, ProductName = "MS Office", Vendor = "Microsoft", Description = "Office Suite", Category = "Productivity", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 5, ProductName = "Figma", Vendor = "Figma Inc", Description = "UI/UX Design", Category = "Design", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 6, ProductName = "Visual Studio", Vendor = "Microsoft", Description = "Development IDE", Category = "Development", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 7, ProductName = "Postman", Vendor = "Postman Inc", Description = "API Testing Tool", Category = "Development", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 8, ProductName = "Slack", Vendor = "Slack Tech", Description = "Communication", Category = "Communication", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 9, ProductName = "AutoCAD", Vendor = "Autodesk", Description = "Engineering Design", Category = "CAD", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 10, ProductName = "VMware ESXi", Vendor = "VMware", Description = "Virtualization platform", Category = "Infrastructure", Status = SoftwareStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt}
                );

                // -------------------------
                // LICENSE TYPES (10 rows)
                // -------------------------
                model.Entity<LicenseType>().HasData(
                    new { Id = 1, SoftwareCatalogId = 1, LicenseTypeName = LicenseTypeEnum.Subscription, Metric = MetricEnum.PerUser, ConsumptionMethod = ConsumptionEnum.Assigned, EnforcementType = EnforcementEnum.SSO, VendorTerms = "Adobe ETLA", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 2, SoftwareCatalogId = 2, LicenseTypeName = LicenseTypeEnum.Perpetual, Metric = MetricEnum.PerCore, ConsumptionMethod = ConsumptionEnum.UsageBased, EnforcementType = EnforcementEnum.LicenseServer, VendorTerms = "Oracle CPU Rules", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 3, SoftwareCatalogId = 3, LicenseTypeName = LicenseTypeEnum.SaasSeat, Metric = MetricEnum.PerUser, ConsumptionMethod = ConsumptionEnum.Assigned, EnforcementType = EnforcementEnum.Account, VendorTerms = "Atlassian Cloud", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 4, SoftwareCatalogId = 4, LicenseTypeName = LicenseTypeEnum.Subscription, Metric = MetricEnum.PerUser, ConsumptionMethod = ConsumptionEnum.Assigned, EnforcementType = EnforcementEnum.SSO, VendorTerms = "Microsoft Enterprise", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 5, SoftwareCatalogId = 5, LicenseTypeName = LicenseTypeEnum.SaasSeat, Metric = MetricEnum.PerUser, ConsumptionMethod = ConsumptionEnum.Concurrent, EnforcementType = EnforcementEnum.Account, VendorTerms = "Figma Cloud", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 6, SoftwareCatalogId = 6, LicenseTypeName = LicenseTypeEnum.Perpetual, Metric = MetricEnum.PerDevice, ConsumptionMethod = ConsumptionEnum.Assigned, EnforcementType = EnforcementEnum.Key, VendorTerms = "MS VS License", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 7, SoftwareCatalogId = 7, LicenseTypeName = LicenseTypeEnum.SaasSeat, Metric = MetricEnum.PerUser, ConsumptionMethod = ConsumptionEnum.Assigned, EnforcementType = EnforcementEnum.Account, VendorTerms = "Postman Cloud", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 8, SoftwareCatalogId = 8, LicenseTypeName = LicenseTypeEnum.SaasSeat, Metric = MetricEnum.PerUser, ConsumptionMethod = ConsumptionEnum.Concurrent, EnforcementType = EnforcementEnum.SSO, VendorTerms = "Slack Cloud", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 9, SoftwareCatalogId = 9, LicenseTypeName = LicenseTypeEnum.Perpetual, Metric = MetricEnum.PerDevice, ConsumptionMethod = ConsumptionEnum.Assigned, EnforcementType = EnforcementEnum.HardwareLock, VendorTerms = "Autodesk License", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 10, SoftwareCatalogId = 10, LicenseTypeName = LicenseTypeEnum.Perpetual, Metric = MetricEnum.PerInstance, ConsumptionMethod = ConsumptionEnum.UsageBased, EnforcementType = EnforcementEnum.LicenseServer, VendorTerms = "VMware Terms", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt}
                );

                // -------------------------
                // ENTITLEMENTS (10 rows)
                // -------------------------
                model.Entity<Entitlement>().HasData(
                    new { Id = 1, LicenseTypeId = 1, Sku = "PS-100", SeatsPurchased = 50, PurchaseDate =seedCreatedAt.AddYears(-1), ExpiryDate =seedCreatedAt.AddYears(1), ActivationMethod = "SSO", VendorInvoicePath = "/inv/ps1.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 2, LicenseTypeId = 2, Sku = "ORA-CPU-01", SeatsPurchased = 4, PurchaseDate =seedCreatedAt.AddYears(-3), ExpiryDate = (DateTime?)null, ActivationMethod = "Server", VendorInvoicePath = "/inv/oracle.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 3, LicenseTypeId = 3, Sku = "JIRA-CLD", SeatsPurchased = 100, PurchaseDate =seedCreatedAt.AddMonths(-6), ExpiryDate =seedCreatedAt.AddYears(1), ActivationMethod = "Account", VendorInvoicePath = "/inv/jira1.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 4, LicenseTypeId = 4, Sku = "MS-365", SeatsPurchased = 300, PurchaseDate =seedCreatedAt.AddMonths(-9), ExpiryDate =seedCreatedAt.AddYears(1), ActivationMethod = "SSO", VendorInvoicePath = "/inv/ms1.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 5, LicenseTypeId = 5, Sku = "FGM-CLOUD", SeatsPurchased = 20, PurchaseDate =seedCreatedAt.AddMonths(-2), ExpiryDate =seedCreatedAt.AddMonths(10), ActivationMethod = "Account", VendorInvoicePath = "/inv/figma.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 6, LicenseTypeId = 6, Sku = "VS-PRO", SeatsPurchased = 10, PurchaseDate =seedCreatedAt.AddYears(-1), ExpiryDate = (DateTime?)null, ActivationMethod = "Key", VendorInvoicePath = "/inv/vs1.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 7, LicenseTypeId = 7, Sku = "POSTMAN-1", SeatsPurchased = 50, PurchaseDate =seedCreatedAt.AddMonths(-3), ExpiryDate =seedCreatedAt.AddMonths(9), ActivationMethod = "Account", VendorInvoicePath = "/inv/pm.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 8, LicenseTypeId = 8, Sku = "SLK-TEAM", SeatsPurchased = 200, PurchaseDate =seedCreatedAt.AddYears(-1), ExpiryDate =seedCreatedAt.AddYears(2), ActivationMethod = "SSO", VendorInvoicePath = "/inv/slack.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 9, LicenseTypeId = 9, Sku = "ACAD-01", SeatsPurchased = 10, PurchaseDate =seedCreatedAt.AddYears(-2), ExpiryDate = (DateTime?)null, ActivationMethod = "HW Lock", VendorInvoicePath = "/inv/acad.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 10, LicenseTypeId = 10, Sku = "VMW-ESXI", SeatsPurchased = 3, PurchaseDate =seedCreatedAt.AddYears(-1), ExpiryDate = (DateTime?)null, ActivationMethod = "Server", VendorInvoicePath = "/inv/esxi.pdf", Status = EntitlementStatus.Active, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt}
                );

                // -------------------------
                // ENTITLEMENT FINANCE (10 rows)
                // -------------------------
                model.Entity<EntitlementFinance>().HasData(
                    new { Id = 1, EntitlementId = 1, CostTotal = 600000m, CostPerSeat = 12000m, Currency = "INR", CapexOpex = CapexOpex.Capex, CostCenter = "Design", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 2, EntitlementId = 2, CostTotal = 200000m, CostPerSeat = 50000m, Currency = "USD", CapexOpex = CapexOpex.Capex, CostCenter = "IT", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 3, EntitlementId = 3, CostTotal = 150000m, CostPerSeat = 1500m, Currency = "USD", CapexOpex = CapexOpex.Opex, CostCenter = "PMO", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 4, EntitlementId = 4, CostTotal = 800000m, CostPerSeat = 2600m, Currency = "INR", CapexOpex = CapexOpex.Opex, CostCenter = "IT", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 5, EntitlementId = 5, CostTotal = 250000m, CostPerSeat = 12500m, Currency = "INR", CapexOpex = CapexOpex.Opex, CostCenter = "Design", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 6, EntitlementId = 6, CostTotal = 500000m, CostPerSeat = 50000m, Currency = "INR", CapexOpex = CapexOpex.Capex, CostCenter = "Dev", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 7, EntitlementId = 7, CostTotal = 100000m, CostPerSeat = 2000m, Currency = "USD", CapexOpex = CapexOpex.Opex, CostCenter = "QA", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 8, EntitlementId = 8, CostTotal = 300000m, CostPerSeat = 1500m, Currency = "USD", CapexOpex = CapexOpex.Opex, CostCenter = "IT", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 9, EntitlementId = 9, CostTotal = 700000m, CostPerSeat = 70000m, Currency = "INR", CapexOpex = CapexOpex.Capex, CostCenter = "Engineering", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 10, EntitlementId = 10, CostTotal = 900000m, CostPerSeat = 300000m, Currency = "USD", CapexOpex = CapexOpex.Capex, CostCenter = "Infra", DepreciationSchedule = "{}", CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt}
                );

                // -------------------------
                // PROCUREMENT (10 rows)
                // -------------------------
                model.Entity<Procurement>().HasData(
                    new { Id = 1, PurchaseOrderNumber = "PO-1001", ContractId = "CON-PS-01", InvoiceId = "INV-1001", ResellerName = "Softline India", SupportLevel = SupportLevel.Standard, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 2, PurchaseOrderNumber = "PO-2001", ContractId = "CON-ORA-01", InvoiceId = "INV-2001", ResellerName = "Redington", SupportLevel = SupportLevel.Premium, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 3, PurchaseOrderNumber = "PO-3001", ContractId = "CON-JIRA-01", InvoiceId = "INV-3001", ResellerName = "ACPL", SupportLevel = SupportLevel.Standard, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 4, PurchaseOrderNumber = "PO-4001", ContractId = "CON-MS-01", InvoiceId = "INV-4001", ResellerName = "Softcell", SupportLevel = SupportLevel.Premium, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 5, PurchaseOrderNumber = "PO-5001", ContractId = "CON-FGM-01", InvoiceId = "INV-5001", ResellerName = "Ingram", SupportLevel = SupportLevel.Standard, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 6, PurchaseOrderNumber = "PO-6001", ContractId = "CON-VS-01", InvoiceId = "INV-6001", ResellerName = "Wipro", SupportLevel = SupportLevel.Premium, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 7, PurchaseOrderNumber = "PO-7001", ContractId = "CON-PM-01", InvoiceId = "INV-7001", ResellerName = "Redington", SupportLevel = SupportLevel.Standard, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 8, PurchaseOrderNumber = "PO-8001", ContractId = "CON-SLK-01", InvoiceId = "INV-8001", ResellerName = "ACPL", SupportLevel = SupportLevel.Standard, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 9, PurchaseOrderNumber = "PO-9001", ContractId = "CON-ACAD-01", InvoiceId = "INV-9001", ResellerName = "Softcell", SupportLevel = SupportLevel.Premium, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt},
                    new { Id = 10, PurchaseOrderNumber = "PO-10001", ContractId = "CON-VMW-01", InvoiceId = "INV-10001", ResellerName = "Ingram", SupportLevel = SupportLevel.Premium, CreatedAt =seedCreatedAt, UpdatedAt = seedCreatedAt}
                );

                // -------------------------
                // PROCUREMENT–ENTITLEMENT MAP (10 rows)
                // -------------------------
                model.Entity<ProcurementEntitlementMap>().HasData(
                    new { Id = 1, ProcurementId = 1, EntitlementId = 1 },
                    new { Id = 2, ProcurementId = 2, EntitlementId = 2 },
                    new { Id = 3, ProcurementId = 3, EntitlementId = 3 },
                    new { Id = 4, ProcurementId = 4, EntitlementId = 4 },
                    new { Id = 5, ProcurementId = 5, EntitlementId = 5 },
                    new { Id = 6, ProcurementId = 6, EntitlementId = 6 },
                    new { Id = 7, ProcurementId = 7, EntitlementId = 7 },
                    new { Id = 8, ProcurementId = 8, EntitlementId = 8 },
                    new { Id = 9, ProcurementId = 9, EntitlementId = 9 },
                    new { Id = 10, ProcurementId = 10, EntitlementId = 10 }
                );
            }
        }
    
}
