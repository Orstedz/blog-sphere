using BlogSphere.Core.Domain.Content;
using BlogSphere.Core.SeedWorks;

namespace BlogSphere.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostAsync(int count);
    }
}
