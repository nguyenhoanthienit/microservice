using Microsoft.EntityFrameworkCore;

namespace Post.Data.Context
{
	public class WriteDbContext : ApplicationContext
	{
		public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
		{
		}
	}
}
