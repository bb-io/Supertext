using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Models.Requests
{
    public class GetQuoteRequest
    {
        public string ContentType { get; set; }

        public string Currency { get; set; }

        public string SourceLang { get; set; }

        public List<string> TargetLanguages { get; set; }

        public int WordCount { get; set; }
    }
}
