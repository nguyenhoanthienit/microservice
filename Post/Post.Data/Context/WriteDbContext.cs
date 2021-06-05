using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Data.Context
{
	public class WriteDbContext : ApplicationContext
	{
		public WriteDbContext(DbContextOptions options) : base(options)
		{
		}
	}
}
