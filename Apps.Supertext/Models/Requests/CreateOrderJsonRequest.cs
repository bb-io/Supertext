using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Models.Requests;

public class CreateOrderJsonRequest
{
    [Display("Callback URL")] public string CallbackUrl { get; set; }

    [Display("Content type")] public string ContentType { get; set; }

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

    [Display("Target languages")] public List<string> TargetLanguages { get; set; }

    public List<Group> Groups { get; set; }
}

public class Group
{
    public string Context { get; set; }

    [Display("Group ID")] public string GroupId { get; set; }

    public List<Item> Items { get; set; }
}

public class Item
{
    public string Comment { get; set; }

    public string Content { get; set; }

    public string Context { get; set; }

    [Display("Item ID")] public string Id { get; set; }

    [Display("Max length")] public string MaxLength { get; set; }
}