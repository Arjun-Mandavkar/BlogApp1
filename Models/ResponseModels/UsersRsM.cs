using BlogApp1.Models.DTOs;

namespace BlogApp1.Models.ResponseModels
{
    public class UsersRsM
    {
        public List<UserInfoDto> Users { get; set; } = new List<UserInfoDto>();
        public int TotalUsers { get; set; }
    }
}