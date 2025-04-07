using Microsoft.EntityFrameworkCore;
using YellowBlog.Domain.Entities;

namespace YellowBlog.Infrastructure.Context
{
    public class YellowBlogDbContext : DbContext
    {
        public YellowBlogDbContext(DbContextOptions<YellowBlogDbContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(YellowBlogDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
