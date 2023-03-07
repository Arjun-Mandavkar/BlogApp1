using BlogApp1.Models.Common;

namespace BlogApp1.Models.ResponseModels
{
    public class ApiResponseData<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
        public IEnumerable<Message>? Messages { get; set; }
    }
}
