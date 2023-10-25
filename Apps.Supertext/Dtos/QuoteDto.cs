using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Dtos;

public class QuoteDto
{
    public string Currency { get; set; }

    [Display("Currency symbol")]
    public string CurrencySymbol { get; set; }

    [Display("Word count")]
    public int WordCount { get; set; }

    public List<Option> Options { get; set; }
}

public class Option
{
    public string Name { get; set; }

    public string Description { get; set; }

    [Display("Short description")]
    public string ShortDescription { get; set; }

    [Display("Order type configuration ID")]
    public int OrderTypeConfigurationId { get; set; }

    [Display("Order type ID")]
    public int OrderTypeId { get; set; }

    [Display("Delivery options")]
    public List<DeliveryOption> DeliveryOptions { get; set; }
}

public class DeliveryOption
{
    public float Price { get; set; }

    [Display("Delivery date")]
    public string DeliveryDate { get; set; }

    public string Name { get; set; }

    [Display("Delivery ID")]
    public int DeliveryId { get; set; }
}