using Blogging_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace Blogging_Razor.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Article");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Title);
            builder.Property(x => x.Picture).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.PictureAlt).IsRequired().HasMaxLength(250);
            builder.Property(x => x.PictureTitle).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(10000000);
            builder.Property(x => x.Body).IsRequired();
        }
    }
}
