using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BlogSphere.Data
{
    public class TeduBlogContextFactory : IDesignTimeDbContextFactory<BlogSphereContext>
    {
        public BlogSphereContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var builder = new DbContextOptionsBuilder<BlogSphereContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new BlogSphereContext(builder.Options);
        }
    }
}
