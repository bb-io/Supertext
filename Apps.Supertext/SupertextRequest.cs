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
        public SupertextRequest(string endpoint, Method method, string login, AuthenticationCredentialsProvider authenticationCredentialsProvider) : base(endpoint, method)
        {
            var bearer = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{login}:{authenticationCredentialsProvider.Value}"));
            this.AddHeader("Authorization", $"Basic {bearer}");
            this.AddHeader("Accept", "application/json");
        }
    }
}
