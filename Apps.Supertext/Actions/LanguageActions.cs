using Apps.Supertext.Api;
using Blackbird.Applications.Sdk.Common;
using RestSharp;
using Apps.Supertext.Models.Responses;
using Apps.Supertext.Models.Requests;
using Apps.Supertext.Dtos;
using Apps.Supertext.Invocables;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.Supertext.Actions;

[ActionList]
public class LanguageActions : SupertextInvocable
{
    public LanguageActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get language mapping", Description = "Get language mapping by language code")]
    public async Task<LanguageMappingResponse> GetLanguageMapping([ActionParameter] LanguageMappingRequest input)
    {
        var endpoint = $"/v1/translation/languagemapping/{input.LanguageCode}";
        var request = new SupertextRequest(endpoint, Method.Get, Creds);

        var languages =
            await Client.ExecuteWithErrorHandling<MappingLanguagesWrapper<List<SupertextLanguageDto>>>(request);

        return new()
        {
            Languages = languages.Languages
        };
    }
}