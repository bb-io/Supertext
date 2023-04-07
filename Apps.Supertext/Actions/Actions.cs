using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Authentication;
using RestSharp;
using Apps.Supertext.Models.Responses;
using Apps.Supertext.Models.Requests;
using Apps.Supertext.Dtos;

namespace Apps.Supertext.Actions
{
    [ActionList]
    public class Actions
    {
        [Action("Language mapping", Description = "Language mapping")]
        public LanguageMappingResponse GetLanguageMapping(string login, AuthenticationCredentialsProvider authenticationCredentialsProvider,
           [ActionParameter] LanguageMappingRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1/translation/languagemapping/{input.LanguageCode}", 
                Method.Get, login, authenticationCredentialsProvider);
            var languages = client.Get<MappingLanguagesWrapper<List<SupertextLanguageDto>>>(request);
            return new LanguageMappingResponse()
            {
                Languages = languages.Languages
            };
        }

        [Action("Get quote", Description = "Get quote")]
        public QuoteDto GetQuote(string login, AuthenticationCredentialsProvider authenticationCredentialsProvider,
           [ActionParameter] GetQuoteRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1/translation/quote",
                Method.Post, login, authenticationCredentialsProvider);
            request.AddJsonBody(input);
            var result = client.Execute<QuoteDto>(request).Data;
            return result;
        }

        [Action("Create order from json", Description = "Create order from json")]
        public CreateOrderJsonResponse CreateOrderJson(string login, AuthenticationCredentialsProvider authenticationCredentialsProvider,
           [ActionParameter] CreateOrderJsonRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1.1/translation/order",
                Method.Post, login, authenticationCredentialsProvider);
            request.AddJsonBody(input);
            var result = client.Execute<CreateOrderJsonResponse>(request).Data;
            return result;
        }

        [Action("Upload file", Description = "Upload file to translate")]
        public UploadFileResponse UploadFile(string login, AuthenticationCredentialsProvider authenticationCredentialsProvider,
           [ActionParameter] UploadFileRequest input)
        {
            var client = new SupertextClient();
            var request = new SupertextRequest($"/v1/files",
                Method.Post, login, authenticationCredentialsProvider);
            request.AddParameter("ElementId", 0);
            request.AddParameter("ElementTypeId", 2);
            request.AddParameter("DocumentTypeId", 1);
            request.AddFile("file", input.File, input.Filename);
            var result = client.Execute<UploadFileResponse>(request).Data;
            return result;
        }
    }
}
