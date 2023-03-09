namespace BlogApp1.Models.RequestModels
{
    public class CreateBlogReM
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }

    public class UpdateBlogReM : CreateBlogReM
    {
        public string Id { get; set; } = string.Empty;
    }
}
