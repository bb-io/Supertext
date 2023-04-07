using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext
{
    public class SupertextClient : RestClient
    {
        public SupertextClient() : base(new RestClientOptions() { ThrowOnAnyError = true, BaseUrl = new Uri("https://dev.supertext.ch/api/") }) { }
    }
}
