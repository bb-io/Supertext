using Apps.Supertext.Dtos;
using Apps.Supertext.Invocables;
using Apps.Supertext.Models.Requests;
using Apps.Supertext.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.Supertext.Actions;

[ActionList]
public class OrderActions : SupertextInvocable
{
    public OrderActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Create order from file", Description = "Create order from uploaded file")]
    public CreateOrderJsonResponse CreateOrderFile([ActionParameter] CreateOrderFromFileRequest input)
    {
        var request = new SupertextRequest("/v1.1/translation/order", Method.Post, Creds)
            .AddJsonBody(new OrderFromFileDto()
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

        var result = Client.Execute<List<OrderDto>>(request).Data;
        return new()
        {
            Orders = result
        };
    }

    [Action("Create order from json", Description = "Create order from json")]
    public CreateOrderJsonResponse CreateOrderJson([ActionParameter] CreateOrderJsonRequest input)
    {
        var request = new SupertextRequest("/v1.1/translation/order", Method.Post, Creds)
            .AddJsonBody(input);

        var result = Client.Execute<List<OrderDto>>(request).Data;
        return new()
        {
            Orders = result
        };
    }
}