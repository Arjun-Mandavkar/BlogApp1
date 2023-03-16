using BlogApp1.Models.ResponseModels;

namespace BlogApp1.Controllers
{
    public interface IBlogReactionController
    {
        public Task<ApiResponse<bool>> IsLiked(string blogId);
        public Task<ApiResponse> ToggleLike(string blogId);
    }
}
