using System.Text;
using Blackbird.Applications.Sdk.Common.Authentication;
using RestSharp;

namespace Apps.Supertext.Api;

public class SupertextRequest : RestRequest
{
    public SupertextRequest(string endpoint, Method method, IEnumerable<AuthenticationCredentialsProvider> creds) : base(endpoint, method)
    {
        var login = creds.First(p => p.KeyName == "login").Value;
        var token = creds.First(p => p.KeyName == "apiToken").Value;

        var bearer = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{login}:{token}"));
        this.AddHeader("Authorization", $"Basic {bearer}");
        this.AddHeader("Accept", "application/json");
    }
}