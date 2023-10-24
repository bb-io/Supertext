namespace Apps.Supertext.Models.Responses;

public class UploadFileResponse
{
    public string Comment { get; set; }
    public string CreationDate { get; set; }
    public string LastUpdated { get; set; }
    public int UploadedById { get; set; }
    public string UploadedByName { get; set; }
    public int WordCount { get; set; }
    public string Type { get; set; }
    public bool IsEditable { get; set; }
    public bool IsTemplate { get; set; }
    public string ContentType { get; set; }
    public int ElementId { get; set; }
    public int ElementTypeId { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Size { get; set; }
    public int TypeId { get; set; }
}