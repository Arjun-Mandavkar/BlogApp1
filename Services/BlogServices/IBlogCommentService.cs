using BlogApp1.Models.Enums;
using BlogApp1.Models.ServiceModels;

namespace BlogApp1.Services.BlogServices
{
    public interface IBlogCommentService
    {
        public Task<BlogCommentSM> Create(CreateBlogCommentSM comment);
        public Task<BlogCommentSM> Update(UpdateBlogCommentSM comment);
        public Task<ServiceResult> Delete(string commentId);
        public Task<IEnumerable<BlogCommentSM>> GetAll(string blogId, BlogCommentSortBy sortBy = BlogCommentSortBy.DATE, int bucketSize = 5, int bucketNumber = 1);
        public Task<int> Count(string blogId);
    }
}
