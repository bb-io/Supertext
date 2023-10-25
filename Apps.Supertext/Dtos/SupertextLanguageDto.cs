using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Dtos;

public class SupertextLanguageDto
{
    public string Code { get; set; }

    public string Title { get; set; }

    [Display("Language ID")] public int Id { get; set; }

    [Display("SDL code")] public string SdlCode { get; set; }

    [Display("Is priority language")] public bool IsPriorityLanguage { get; set; }

    [Display("Enabled target language")] public bool EnabledTargetLanguage { get; set; }

    [Display("Enabled source language")] public bool EnabledSourceLanguage { get; set; }

    [Display("Is system language")] public bool IsSystemLanguage { get; set; }
}