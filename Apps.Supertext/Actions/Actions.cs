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
    }
}
