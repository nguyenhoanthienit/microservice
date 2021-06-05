using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Post.Domain.Contracts;
using Post.Domain.Entities;

namespace Post.Data.Context
{
	public abstract class ApplicationContext : DbContext, IApplicationDbContext
	{
		public ApplicationContext(DbContextOptions options) : base(options) { }


		public virtual DbSet<PostEntity> Posts { get; set; }
		public virtual DbSet<CommentEntity> Comments { get; set; }
		public virtual DbSet<CategoryEntity> Categories { get; set; }
		public virtual DbSet<PostCategoryEntity> PostCategories { get; set; }


		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.HasPostgresExtension("unaccent");

			builder.Entity<CommentEntity>(entity =>
			{
				entity.HasKey(e => e.Id);
				entity.HasOne(n => n.Post)
				.WithMany(n => n.PostComments)
				.HasForeignKey(n => n.PostId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			builder.Entity<CategoryEntity>(entity =>
			{
				entity.HasKey(e => e.Id);
			});

			builder.Entity<PostCategoryEntity>(entity =>
			{
				entity.HasKey(e => new { e.PostId, e.CategoryId });

				entity.HasOne(e => e.Post)
				.WithMany(e => e.PostCategories)
				.HasForeignKey(e => e.PostId)
				.OnDelete(DeleteBehavior.Cascade);

				entity.HasOne(e => e.Category)
				.WithMany(e => e.PostCategories)
				.HasForeignKey(e => e.CategoryId)
				.OnDelete(DeleteBehavior.Cascade);
			});
		}
	}
}
