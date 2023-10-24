using RestSharp;

namespace Apps.Supertext;

public class SupertextClient : RestClient
{
    public SupertextClient() : base(new RestClientOptions() { ThrowOnAnyError = true, BaseUrl = new Uri("https://www.supertext.ch/api/") }) { }
}