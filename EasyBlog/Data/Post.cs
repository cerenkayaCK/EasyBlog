namespace EasyBlog.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string? Image { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
