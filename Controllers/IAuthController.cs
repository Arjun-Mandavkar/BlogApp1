using BlogApp1.Models.RequestModels;
using BlogApp1.Models.ResponseModels;

namespace BlogApp1.Controllers
{
    public interface IAuthController
    {
        public Task<ApiResponse<AuthUserRsM>> Register(RegisterUserReM userInfo);
        public Task<ApiResponse<AuthUserRsM>> Login(LoginUserReM credentials);
        public Task<ApiResponse> DeleteAccount(LoginUserReM credentials);
    }
}