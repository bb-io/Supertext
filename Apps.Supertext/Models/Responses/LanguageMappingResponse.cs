using Apps.Supertext.Dtos;

namespace Apps.Supertext.Models.Responses;

public class LanguageMappingResponse
{
    public IEnumerable<SupertextLanguageDto> Languages { get; set; }
}