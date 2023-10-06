namespace Apps.Supertext.Callbacks.Payload
{
    public class FileTranslatedEvent
    {
        public string Id { get; set; }

        public string OrderName { get; set; }

        public IEnumerable<FileObj> Files { get; set; }
    }

    public class FileObj
    {
        public int CharacterCount { get; set; }
        public string Comment { get; set; }
        public string CreationDate { get; set; }
        public string DocumentType { get; set; }
        public bool IsEditable { get; set; }
        public bool IsTemplate { get; set; }
        public string LanguageCode { get; set; }
        public string LastUpdated { get; set; }
        public int LastUpdatedById { get; set; }
        public string LastUpdatedByName { get; set; }
        public int UploadedById { get; set; }
        public string UploadedByName { get; set; }
        public int WordCount { get; set; }
        public string ContentType { get; set; }
        public int DocumentTypeId { get; set; }
        public int ElementId { get; set; }
        public int ElementTypeId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string StorageConnectionStringKey { get; set; }
    }
}
