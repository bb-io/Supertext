using Apps.Supertext.Api;
using Apps.Supertext.Invocables;
using Apps.Supertext.Models.Requests;
using Apps.Supertext.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.Supertext.Actions;

[ActionList]
public class FileActions : SupertextInvocable
{
    public FileActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Upload file", Description = "Upload file to translate")]
    public async Task<UploadFileResponse> UploadFile([ActionParameter] UploadFileRequest input)
    {
        var request = new SupertextRequest("/v1/files", Method.Post, Creds)
            .AddParameter("ElementId", 0)
            .AddParameter("ElementTypeId", 2)
            .AddParameter("DocumentTypeId", 1)
            .AddFile("file", input.File.Bytes, input.File.Name);

        var result = await Client.ExecuteWithErrorHandling<List<UploadFileResponse>>(request);
        return result.First();
    }

    [Action("Download file", Description = "Download file by id and name")]
    public async Task<DownloadFileResponse> DownloadFile([ActionParameter] DownloadFileRequest input)
    {
        var endpoint = $"/../FileDownloads/File/{input.FileId}/{input.FileName}";
        var request = new SupertextRequest(endpoint, Method.Get, Creds);

        var result = await Client.ExecuteWithErrorHandling(request);

        return new()
        {
            File = new(result.RawBytes)
            {
                Name = input.FileName,
                ContentType = result.ContentType
            }
        };
    }
}