namespace MJGalary.Web.Client
{
    public class MessageResponse
    {
        public string Id { get; set; }
        public string ImageId { get; set; }
        public string Prompt { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}
