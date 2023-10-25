using Apps.Supertext.Api;
using Apps.Supertext.Dtos;
using Apps.Supertext.Invocables;
using Apps.Supertext.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.Supertext.Actions;

[ActionList]
public class QuoteActions : SupertextInvocable
{
    public QuoteActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get quote", Description = "Get quote")]
    public Task<QuoteDto> GetQuote([ActionParameter] GetQuoteRequest input)
    {
        var request = new SupertextRequest("/v1/translation/quote", Method.Post, Creds)
            .AddJsonBody(input);

        return Client.ExecuteWithErrorHandling<QuoteDto>(request);
    }
}