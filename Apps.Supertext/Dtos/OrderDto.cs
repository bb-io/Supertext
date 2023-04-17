using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Dtos
{
    public class OrderDto
    {
        public string AdditionalInformation { get; set; }
        public int Amount { get; set; }
        public string AmountDesc { get; set; }
        public string BilledDate { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingCompany { get; set; }
        public string BillingCountryCode { get; set; }
        public string BillingCountryName { get; set; }
        public string BillingFirstName { get; set; }
        public int BillingId { get; set; }
        public string BillingLastName { get; set; }
        public string BillingZip { get; set; }
        public string CallbackUrl { get; set; }
        public int CharacterCount { get; set; }
        public string CollectedDate { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ComponentName { get; set; }
        public string ComponentVersion { get; set; }
        public string ContentType { get; set; }
        public string CostCenter { get; set; }
        public int Count { get; set; }
        public string Coupon { get; set; }
        public string Currency { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencySymbol { get; set; }
        public int CustomerCompanyId { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerFirstName { get; set; }
        public int CustomerId { get; set; }
        public int CustomerGenderId { get; set; }
        public string CustomerGenderDescription { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }
        public int CustomerPicVersion { get; set; }
        public int CustomerRating { get; set; }
        public string Deadline { get; set; }
        public string DeliveredDate { get; set; }
        public int DeliveryId { get; set; }
        public int DisplayManager { get; set; }
        public bool HasCid { get; set; }
        public int Id { get; set; }
        public string Industry { get; set; }
        public int IndustryId { get; set; }
        public string InternalCorrespondenceKey { get; set; }
        public string InternalDeadline { get; set; }
        public string InternalDeadlineOffset { get; set; }
        public int LanguageManagerId { get; set; }
        public string OfferType { get; set; }
        public string OrderDate { get; set; }
        public string OrderName { get; set; }
        public string OrderType { get; set; }
        public int OrderTypeConfigurationId { get; set; }
        public int OrderTypeId { get; set; }
        public int PackageStoreId { get; set; }
        public string ProjectId { get; set; }
        public int PaymentPeriod { get; set; }
        public string PersonName { get; set; }
        public double Price { get; set; }
        public int ProjectManagerId { get; set; }
        public int ProofreadingModeId { get; set; }
        public string Referrer { get; set; }
        public string RequestedDeadline { get; set; }
        public string ReferenceData { get; set; }
        public string ServiceType { get; set; }
        public int ServiceTypeBaseId { get; set; }
        public int ServiceTypeId { get; set; }
        public string SourceLang { get; set; }
        public string SourceLangSdl { get; set; }
        public string SourceLanguage { get; set; }
        public string Status { get; set; }
        public int StatusGroup { get; set; }
        public int StatusId { get; set; }
        public string SystemName { get; set; }
        public string SystemVersion { get; set; }
        public string TargetAudience { get; set; }
        public string TargetLang { get; set; }
        public string TargetLanguage { get; set; }
        public string TargetLangSdl { get; set; }
        public List<string> TargetLanguages { get; set; }
        public int TenantId { get; set; }
        public string TextStyle { get; set; }
        public int TextStyleId { get; set; }
        public string TextType { get; set; }
        public int TextTypeId { get; set; }
        public int WordCount { get; set; }
    }
}
