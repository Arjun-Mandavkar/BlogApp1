using BlogApp1.Models.Common;

namespace BlogApp1.Models.ResponseModels
{
    public class ApiResponse
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<Message>? Messages { get; set; }
    }

    public class ApiResponse<T> : ApiResponse
    {
        public T? Data { get; set; }
    }
}
