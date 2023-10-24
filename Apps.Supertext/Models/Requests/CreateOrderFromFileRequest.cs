using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Models.Requests;

public class CreateOrderFromFileRequest
{
    [Display("Callback URL")] public string CallbackUrl { get; set; }

    [Display("Delivery ID")] public int DeliveryId { get; set; }

    [Display("Order name")] public string OrderName { get; set; }

    [Display("Additional information")] public string AdditionalInformation { get; set; }

    [Display("Order type ID")] public int OrderTypeId { get; set; }

    [Display("Reference data")] public string ReferenceData { get; set; }

    public string Referrer { get; set; }

    [Display("System name")] public string SystemName { get; set; }

    [Display("System version")] public string SystemVersion { get; set; }

    [Display("Component name")] public string ComponentName { get; set; }

    [Display("Component version")] public string ComponentVersion { get; set; }

    [Display("Source language")] public string SourceLang { get; set; }

    [Display("Target language")] public string TargetLanguage { get; set; }

    [Display("File ID")] public string FileId { get; set; }

    [Display("File comment")] public string FileComment { get; set; }
}