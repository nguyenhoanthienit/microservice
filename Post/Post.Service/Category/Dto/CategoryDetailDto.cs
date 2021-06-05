using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Service.Category.Dto
{
	public class CategoryDetailDto
	{
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}
