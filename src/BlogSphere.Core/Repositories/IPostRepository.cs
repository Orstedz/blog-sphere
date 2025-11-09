using BlogSphere.Core.Domain.Content;
using BlogSphere.Core.Models;
using BlogSphere.Core.Models.Content;
using BlogSphere.Core.SeedWorks;

namespace BlogSphere.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}
