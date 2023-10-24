using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Models.Requests;

public class GetQuoteRequest
{
    [Display("Content type")]
    public string ContentType { get; set; }

    public string Currency { get; set; }

    [Display("Source language")]
    public string SourceLang { get; set; }

    [Display("Target languages")]
    public IEnumerable<string> TargetLanguages { get; set; }

    [Display("Word count")]
    public int WordCount { get; set; }
}