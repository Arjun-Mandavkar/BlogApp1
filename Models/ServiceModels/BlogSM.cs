namespace BlogApp1.Models.ServiceModels
{
    public class CreateBlogSM
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }

    public class UpdateBlogSM : CreateBlogSM
    {
        public string Id { get; set; } = string.Empty;
    }
    public class BlogSM : UpdateBlogSM
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
        public int Likes { get; set; }
    }
}
