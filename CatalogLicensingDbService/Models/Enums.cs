namespace CatalogLicensingDbService.Models
{
    public enum SoftwareStatus { Active, Retired }
    public enum LicenseTypeEnum { Perpetual, Subscription, Floating, SaasSeat }
    public enum MetricEnum { PerUser, PerDevice, PerCore, PerInstance }
    public enum ConsumptionEnum { Assigned, UsageBased, Concurrent }
    public enum EnforcementEnum { Key, Account, SSO, HardwareLock, LicenseServer }
    public enum EntitlementStatus { Active, Expired, Retired }
    public enum CapexOpex { Capex, Opex }
    public enum SupportLevel { Standard, Premium }
}
