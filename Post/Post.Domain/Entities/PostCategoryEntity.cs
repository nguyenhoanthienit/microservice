using Common.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Domain.Entities
{
	public class PostCategoryEntity : ICreatedEntity, IUpdatedEntity
	{
		public Guid PostId { get; set; }
		public Guid CategoryId { get; set; }

		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }

		public virtual PostEntity Post { get; set; }
		public virtual CategoryEntity Category { get; set; }
	}
}
