namespace BlogApp1.Models.DataModels
{
    public class Blog
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
        public string LastModifiedBy { get; set; } = string.Empty;
        public int Likes { get; set; }
    }
}
