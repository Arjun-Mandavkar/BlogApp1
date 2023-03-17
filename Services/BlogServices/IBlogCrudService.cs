using BlogApp1.Models.DTOs;
using BlogApp1.Models.Enums;
using BlogApp1.Models.ServiceModels;

namespace BlogApp1.Services.BlogServices
{
    public interface IBlogCrudService
    {
        public Task<BlogSM> Get(int blogId);
        public Task<IEnumerable<BlogSM>> GetAll(BlogSortBy sortBy = BlogSortBy.DATE, int pageSize = 10, int pageNumber = 1);
        public Task<int> GetCount();
        public Task<BlogSM> Create(CreateBlogSM blog);
        public Task<BlogSM> Update(UpdateBlogSM blog);
        public Task<ServiceResult> Delete(int blogId);
    }
}
