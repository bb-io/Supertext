namespace Apps.Supertext.Models.Requests
{
    public class CreateOrderFromFileRequest
    {
        public string CallbackUrl { get; set; }
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
        public string TargetLanguage { get; set; }
        public string FileId { get; set; }
        public string FileComment { get; set; }
    }
}
