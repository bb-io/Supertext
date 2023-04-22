using Blackbird.Applications.Sdk.Common.Authentication;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext
{
    public class SupertextRequest : RestRequest
    {
        public SupertextRequest(string endpoint, Method method, IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders) : base(endpoint, method)
        {
            var login = authenticationCredentialsProviders.First(p => p.KeyName == "login").Value;
            var token = authenticationCredentialsProviders.First(p => p.KeyName == "apiToken").Value;

            var bearer = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{login}:{token}"));
            this.AddHeader("Authorization", $"Basic {bearer}");
            this.AddHeader("Accept", "application/json");
        }
    }
}
