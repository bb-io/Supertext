using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Models.Requests;

public class LanguageMappingRequest
{
    [Display("Language code")]
    public string LanguageCode { get; set; }
}