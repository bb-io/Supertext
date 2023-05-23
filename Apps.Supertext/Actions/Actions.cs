using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Authentication;
using RestSharp;
using Apps.Supertext.Models.Responses;
using Apps.Supertext.Models.Requests;
using Apps.Supertext.Dtos;
using Blackbird.Applications.Sdk.Common.Actions;

namespace Apps.Supertext.Actions
{
    [ActionList]
    public class Actions
    {
        [Action("Language mapping", Description = "Language mapping")]
        public LanguageMappingResponse GetLanguageMapping(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
           [ActionParameter] LanguageMappingRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1/translation/languagemapping/{input.LanguageCode}", 
                Method.Get, authenticationCredentialsProviders);
            var languages = client.Get<MappingLanguagesWrapper<List<SupertextLanguageDto>>>(request);
            return new LanguageMappingResponse()
            {
                Languages = languages.Languages
            };
        }

        [Action("Get quote", Description = "Get quote")]
        public QuoteDto GetQuote(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
           [ActionParameter] GetQuoteRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1/translation/quote",
                Method.Post, authenticationCredentialsProviders);
            request.AddJsonBody(input);
            var result = client.Execute<QuoteDto>(request).Data;
            return result;
        }

        [Action("Create order from json", Description = "Create order from json")]
        public CreateOrderJsonResponse CreateOrderJson(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
           [ActionParameter] CreateOrderJsonRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1.1/translation/order",
                Method.Post, authenticationCredentialsProviders);
            request.AddJsonBody(input);
            var result = client.Execute<List<OrderDto>>(request).Data;
            return new CreateOrderJsonResponse
            {
                Orders = result
            };
        }

        [Action("Upload file", Description = "Upload file to translate")]
        public UploadFileResponse UploadFile(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
           [ActionParameter] UploadFileRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1/files",
                Method.Post, authenticationCredentialsProviders);
            request.AddParameter("ElementId", 0);
            request.AddParameter("ElementTypeId", 2);
            request.AddParameter("DocumentTypeId", 1);
            request.AddFile("file", input.File, input.Filename);
            var result = client.Execute<List<UploadFileResponse>>(request).Data;
            return result.First();
        }

        [Action("Download file", Description = "Download file by id and name")]
        public DownloadFileResponse DownloadFile(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
           [ActionParameter] DownloadFileRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/../FileDownloads/File/{input.FileId}/{input.FileName}",
                Method.Get, authenticationCredentialsProviders);
           
            var resultData = client.Get(request).RawBytes;
            return new DownloadFileResponse()
            {
                FileName = input.FileName,
                File = resultData
            };
        }

        [Action("Create order from file", Description = "Create order from uploaded file")]
        public CreateOrderJsonResponse CreateOrderFile(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
           [ActionParameter] CreateOrderFromFileRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1.1/translation/order",
                Method.Post, authenticationCredentialsProviders);
            request.AddJsonBody(new OrderFromFileDto()
            {
                CallbackUrl = input.CallbackUrl,
                DeliveryId = input.DeliveryId,
                OrderName = input.OrderName,
                AdditionalInformation = input.AdditionalInformation,
                OrderTypeId = input.OrderTypeId,
                ReferenceData = input.ReferenceData,
                Referrer = input.Referrer,
                SystemName = input.SystemName,
                SystemVersion = input.SystemVersion,
                ComponentName = input.ComponentName,
                ComponentVersion = input.ComponentVersion,
                SourceLang = input.SourceLang,
                TargetLanguages = new[] { input.TargetLanguage },
                Files = new[] { new FileItem() { ID = input.FileId, Comment = input.FileComment } }
            });
            var result = client.Execute<List<OrderDto>>(request).Data;
            return new CreateOrderJsonResponse
            {
                Orders = result
            };
        }
    }
}
