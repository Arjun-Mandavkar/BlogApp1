using BlogApp1.Models.DTOs;

namespace BlogApp1.Models.ResponseModels
{
    public class BlogsRsM
    {
        public IEnumerable<BlogInfoDto> Blogs { get; set; } = new List<BlogInfoDto>();
        public int TotalBlogs { get; set; }
    }
}
