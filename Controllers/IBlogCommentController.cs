using BlogApp1.Models.DTOs;
using BlogApp1.Models.RequestModels;
using BlogApp1.Models.ResponseModels;

namespace BlogApp1.Controllers
{
    public interface IBlogCommentController
    {
        public Task<ApiResponse<BlogCommentsRsM>> GetComments(GetAllBlogCommentsReM info);
        public Task<ApiResponse<BlogCommentDto>> Create(CreateBlogCommentReM comment);
        public Task<ApiResponse<BlogCommentDto>> Update(UpdateBlogCommentReM comment);
        public Task<ApiResponse> Delete(string commentId);
    }
}
