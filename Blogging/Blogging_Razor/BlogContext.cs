using Blogging_Razor.Mapping;
using Blogging_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace Blogging_Razor
{
    public class BlogContext:DbContext
    {
        
        public DbSet<Article> Articles { get; set; }
        public BlogContext(DbContextOptions Options):base(Options)
        {
            
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new ArticleMapping());
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
