namespace Apps.Supertext.Dtos;

public class SupertextLanguageDto
{
    public string Code { get; set; }

    public string Title { get; set; }

    public int Id { get; set; }

    public string SdlCode { get; set; }

    public bool IsPriorityLanguage { get; set; }

    public bool EnabledTargetLanguage { get; set; }

    public bool EnabledSourceLanguage { get; set; }

    public bool IsSystemLanguage { get; set; }
}