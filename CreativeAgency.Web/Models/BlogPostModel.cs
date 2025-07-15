namespace CreativeAgency.Web.Models
{
    public class BlogPostModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Category { get; set; }
    }
}
