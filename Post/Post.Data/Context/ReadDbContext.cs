using Microsoft.EntityFrameworkCore;

namespace Post.Data.Context
{
	public class ReadDbContext : ApplicationContext
	{
		public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
		{
		}
	}
}
