using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Models.Requests
{
    public class CreateOrderFromFileRequest
    {
        public string CallbackUrl { get; set; }
        public string ContentType { get; set; }
        public int DeliveryId { get; set; }
        public string OrderName { get; set; }
        public string AdditionalInformation { get; set; }
        public int OrderTypeId { get; set; }
        public string ReferenceData { get; set; }
        public string Referrer { get; set; }
        public string SystemName { get; set; }
        public string SystemVersion { get; set; }
        public string ComponentName { get; set; }
        public string ComponentVersion { get; set; }
        public string SourceLang { get; set; }
        public IEnumerable<string> TargetLanguages { get; set; }
        public IEnumerable<FileItem> Files { get; set; }
    }

    public class FileItem
    {
        public string ID { get; set; }
        public string Comment { get; set; }
    }
}
