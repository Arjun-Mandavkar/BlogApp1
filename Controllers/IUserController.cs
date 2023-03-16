using BlogApp1.Models.DTOs;
using BlogApp1.Models.RequestModels;
using BlogApp1.Models.ResponseModels;

namespace BlogApp1.Controllers
{
    public interface IUserController
    {
        public Task<ApiResponse<UsersRsM>> GetPaginatedUsers(GetAllUsersReM info);
        public Task<ApiResponse<UserInfoDto>> Get(string Id);   //Id can be guid or email
        public Task<ApiResponse<UserInfoDto>> Create(CreateUserReM userInfo);
        public Task<ApiResponse<UserInfoDto>> Update(UpdateUserReM userInfo);
        public Task<ApiResponse<UserInfoDto>> Delete(string Id);    //Id can be guid or email
        public Task<ApiResponse> RolesAction(UserRolesReM info);    //Assign and revoke roles
    }
}
