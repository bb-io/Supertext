using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Dtos
{
    public class QuoteDto
    {
        public string Currency { get; set; }

        public string CurrencySymbol { get; set; }

        public int WordCount { get; set; }

        public List<Option> Options { get; set; }
    }

    public class Option
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public int OrderTypeConfigurationId { get; set; }

        public int OrderTypeId { get; set; }

        public List<DeliveryOption> DeliveryOptions { get; set; }
    }

    public class DeliveryOption
    {
        public float Price { get; set; }

        public string DeliveryDate { get; set; }

        public string Name { get; set; }

        public int DeliveryId { get; set; }
    }
}
