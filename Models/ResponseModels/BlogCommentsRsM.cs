using BlogApp1.Models.DTOs;

namespace BlogApp1.Models.ResponseModels
{
    public class BlogCommentsRsM
    {
        public IEnumerable<BlogCommentDto> Comments = new List<BlogCommentDto>();
        public int TotalComments;
    }
}
