using BlogApp1.Models.DTOs;

namespace BlogApp1.Models.ResponseModels
{
    public class AuthUserRM
    {
        public UserInfoDto? UserInfo { get; set; }
        public string Token { get; set; } = string.Empty;
    }
}
