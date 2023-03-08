using BlogApp1.Models.DTOs;
using BlogApp1.Models.ResponseModels;

namespace BlogApp1.Controllers
{
    public interface IAuthController
    {
        public Task<ApiResponse<AuthUserRM>> Register(RegisterUserDto dto);
        public Task<ApiResponse<AuthUserRM>> Login(LoginUserDto dto);
        public Task<ApiResponse> DeleteAccount(LoginUserDto dto);
    }
}
