using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Models.Responses;

public class UploadFileResponse
{
    [Display("Comment")]
    public string Comment { get; set; }

    [Display("Creation date")]
    public string CreationDate { get; set; }

    [Display("Last updated")]
    public string LastUpdated { get; set; }

    [Display("Uploaded by ID")]
    public int UploadedById { get; set; }

    [Display("Uploaded by name")]
    public string UploadedByName { get; set; }

    [Display("Word count")]
    public int WordCount { get; set; }

    [Display("Type")]
    public string Type { get; set; }

    [Display("Is editable")]
    public bool IsEditable { get; set; }

    [Display("Is template")]
    public bool IsTemplate { get; set; }

    [Display("Content type")]
    public string ContentType { get; set; }

    [Display("Element ID")]
    public int ElementId { get; set; }

    [Display("Element type ID")]
    public int ElementTypeId { get; set; }

    [Display("ID")]
    public int Id { get; set; }

    [Display("Name")]
    public string Name { get; set; }

    [Display("Size")]
    public int Size { get; set; }

    [Display("Type ID")]
    public int TypeId { get; set; }
}