using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Dtos;

public class OrderDto
{
    [Display("Additional information")] public string AdditionalInformation { get; set; }

    [Display("Amount")] public int Amount { get; set; }

    [Display("Amount description")] public string AmountDesc { get; set; }

    [Display("Billed date")] public string BilledDate { get; set; }

    [Display("Billing address 1")] public string BillingAddress1 { get; set; }

    [Display("Billing address 2")] public string BillingAddress2 { get; set; }

    [Display("Billing city")] public string BillingCity { get; set; }

    [Display("Billing company")] public string BillingCompany { get; set; }

    [Display("Billing country code")] public string BillingCountryCode { get; set; }

    [Display("Billing country name")] public string BillingCountryName { get; set; }

    [Display("Billing first name")] public string BillingFirstName { get; set; }

    [Display("Billing ID")] public int BillingId { get; set; }

    [Display("Billing last name")] public string BillingLastName { get; set; }

    [Display("Billing zip")] public string BillingZip { get; set; }

    [Display("Callback URL")] public string CallbackUrl { get; set; }

    [Display("Character count")] public int CharacterCount { get; set; }

    [Display("Collected date")] public string CollectedDate { get; set; }

    [Display("Company ID")] public int CompanyId { get; set; }

    [Display("Company name")] public string CompanyName { get; set; }

    [Display("Component name")] public string ComponentName { get; set; }

    [Display("Component version")] public string ComponentVersion { get; set; }

    [Display("Content type")] public string ContentType { get; set; }

    [Display("Cost center")] public string CostCenter { get; set; }

    [Display("Count")] public int Count { get; set; }

    [Display("Coupon")] public string Coupon { get; set; }

    [Display("Currency")] public string Currency { get; set; }

    [Display("Currency ID")] public int CurrencyId { get; set; }

    [Display("Currency symbol")] public string CurrencySymbol { get; set; }

    [Display("Customer company ID")] public int CustomerCompanyId { get; set; }

    [Display("Customer company name")] public string CustomerCompanyName { get; set; }

    [Display("Customer email")] public string CustomerEmail { get; set; }

    [Display("Customer first name")] public string CustomerFirstName { get; set; }

    [Display("Customer ID")] public int CustomerId { get; set; }

    [Display("Customer gender ID")] public int CustomerGenderId { get; set; }

    [Display("Customer gender description")]
    public string CustomerGenderDescription { get; set; }

    [Display("Customer last name")] public string CustomerLastName { get; set; }

    [Display("Customer phone")] public string CustomerPhone { get; set; }

    [Display("Customer pic version")] public int CustomerPicVersion { get; set; }

    [Display("Customer rating")] public int CustomerRating { get; set; }

    [Display("Deadline")] public string Deadline { get; set; }

    [Display("Delivered date")] public string DeliveredDate { get; set; }

    [Display("Delivery ID")] public int DeliveryId { get; set; }

    [Display("Display manager")] public int DisplayManager { get; set; }

    [Display("Has CID")] public bool HasCid { get; set; }

    [Display("ID")] public int Id { get; set; }

    [Display("Industry")] public string Industry { get; set; }

    [Display("Industry ID")] public int IndustryId { get; set; }

    [Display("Internal correspondence key")]
    public string InternalCorrespondenceKey { get; set; }

    [Display("Internal deadline")] public string InternalDeadline { get; set; }

    [Display("Internal deadline offset")] public string InternalDeadlineOffset { get; set; }

    [Display("Language manager ID")] public int LanguageManagerId { get; set; }

    [Display("Offer type")] public string OfferType { get; set; }

    [Display("Order date")] public string OrderDate { get; set; }

    [Display("Order name")] public string OrderName { get; set; }

    [Display("Order type")] public string OrderType { get; set; }

    [Display("Order type configuration ID")]
    public int OrderTypeConfigurationId { get; set; }

    [Display("Order type ID")] public int OrderTypeId { get; set; }

    [Display("Package store ID")] public int PackageStoreId { get; set; }

    [Display("Project ID")] public string ProjectId { get; set; }

    [Display("Payment period")] public int PaymentPeriod { get; set; }

    [Display("Person name")] public string PersonName { get; set; }

    [Display("Project manager ID")] public int ProjectManagerId { get; set; }

    [Display("Proofreading mode ID")] public int ProofreadingModeId { get; set; }

    [Display("Referrer")] public string Referrer { get; set; }

    [Display("Requested deadline")] public string RequestedDeadline { get; set; }

    [Display("Reference data")] public string ReferenceData { get; set; }

    [Display("Service type")] public string ServiceType { get; set; }

    [Display("Service type base ID")] public int ServiceTypeBaseId { get; set; }

    [Display("Service type ID")] public int ServiceTypeId { get; set; }

    [Display("Source language")] public string SourceLang { get; set; }

    [Display("Source language SDL")] public string SourceLangSdl { get; set; }

    [Display("Status")] public string Status { get; set; }

    [Display("Status group")] public int StatusGroup { get; set; }

    [Display("Status ID")] public int StatusId { get; set; }

    [Display("System name")] public string SystemName { get; set; }

    [Display("System version")] public string SystemVersion { get; set; }

    [Display("Target audience")] public string TargetAudience { get; set; }

    [Display("Target language")] public string TargetLang { get; set; }

    [Display("Target language SDL")] public string TargetLangSdl { get; set; }

    [Display("Target languages")] public List<string> TargetLanguages { get; set; }

    [Display("Tenant ID")] public int TenantId { get; set; }

    [Display("Text style")] public string TextStyle { get; set; }

    [Display("Text style ID")] public int TextStyleId { get; set; }

    [Display("Text type")] public string TextType { get; set; }

    [Display("Text type ID")] public int TextTypeId { get; set; }

    [Display("Word count")] public int WordCount { get; set; }
}