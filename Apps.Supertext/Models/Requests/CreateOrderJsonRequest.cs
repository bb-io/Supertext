using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Models.Requests
{
    public class CreateOrderJsonRequest
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
        public List<string> TargetLanguages { get; set; }
        public List<Group> Groups { get; set; }
    }

    public class Group
    {
        public string Context { get; set; }
        public string GroupId { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public string Comment { get; set; }
        public string Content { get; set; }
        public string Context { get; set; }
        public string Id { get; set; }
        public string MaxLength { get; set; }
    }
}
