using AutoMapper;
using BlogSphere.Core.Repositories;
using BlogSphere.Core.SeedWorks;
using BlogSphere.Data.Repositories;

namespace BlogSphere.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogSphereContext _context;

        public UnitOfWork(BlogSphereContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
        }

        public IPostRepository Posts { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}