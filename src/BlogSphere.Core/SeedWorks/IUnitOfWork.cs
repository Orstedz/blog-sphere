using BlogSphere.Core.Repositories;

namespace BlogSphere.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }

        Task<int> CompleteAsync();
    }
}
