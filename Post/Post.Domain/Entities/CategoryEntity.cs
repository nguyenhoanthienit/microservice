using Common.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Domain.Entities
{
	public class CategoryEntity : IBaseEntity<Guid>, ICreatedEntity, IUpdatedEntity
	{
		public CategoryEntity()
		{
			PostCategories = new HashSet<PostCategoryEntity>();
		}
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public Guid Id { get; set; }
		public string Name { get; set; }
		public virtual ICollection<PostCategoryEntity> PostCategories { get; set; }
	}
}
