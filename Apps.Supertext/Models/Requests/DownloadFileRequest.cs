using Blackbird.Applications.Sdk.Common;

namespace Apps.Supertext.Models.Requests;

public class DownloadFileRequest
{
    [Display("File ID")]
    public string FileId { get; set; }
    
    [Display("File name")]
    public string FileName { get; set; }
}