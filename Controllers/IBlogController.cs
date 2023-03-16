using BlogApp1.Models.DTOs;
using BlogApp1.Models.RequestModels;
using BlogApp1.Models.ResponseModels;

namespace BlogApp1.Controllers
{
    /// <summary>
    /// Controller for blog crud operations
    /// </summary>
    public interface IBlogController
    {
        public Task<ApiResponse<BlogsRsM>> GetPaginatedBlogs(GetAllBlogsReM info);
        public Task<ApiResponse<BlogDto>> Get(string Id);
        public Task<ApiResponse<BlogDto>> Create(CreateBlogReM info);
        public Task<ApiResponse<BlogDto>> Update(UpdateBlogReM info);
        public Task<ApiResponse> Delete(string Id);
        public Task<ApiResponse> RolesAction(BlogUserRolesReM info);    //Assign and revoke roles
        public Task<ApiResponse<IEnumerable<BlogUserInfoDto>>> GetBlogUsers(string blogId);
    }
}
