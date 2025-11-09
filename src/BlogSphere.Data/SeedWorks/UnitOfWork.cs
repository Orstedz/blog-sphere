using BlogSphere.Core.SeedWorks;

namespace BlogSphere.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogSphereContext _context;

        public UnitOfWork(BlogSphereContext context)
        {
            _context = context;
        }

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