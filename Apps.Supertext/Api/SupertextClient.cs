using Apps.Supertext.Models.Responses;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.Supertext.Api;

public class SupertextClient : BlackBirdRestClient
{
    public SupertextClient() : base(new()
    {
        BaseUrl = new("https://www.supertext.ch/api/")
    })
    {
    }

    protected override Exception ConfigureErrorException(RestResponse response)
    {
        var error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content!)!;
        throw new PluginApplicationException(error.Message);
    }
}