namespace BlazorDocs.Database
{
    public class Doc : IIdentify
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}