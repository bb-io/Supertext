using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Models.Responses
{
    public class CreateOrderJsonResponse
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime Deadline { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }
        public int DeliveryId { get; set; }
        public string OrderTitle { get; set; }
        public int OrderTypeId { get; set; }
        public string ReferenceData { get; set; }
        public string SourceLang { get; set; }
        public string TargetLang { get; set; }
        public string Status { get; set; }
    }
}
