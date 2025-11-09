using BlogSphere.Core.Domain.Content;
using BlogSphere.Core.Repositories;
using BlogSphere.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace BlogSphere.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        public PostRepository(BlogSphereContext context) : base(context)
        {
        }

        public Task<List<Post>> GetPopularPostAsync(int count)
        {
            return _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
        }
    }
}
