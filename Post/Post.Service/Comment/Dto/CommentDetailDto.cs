using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Service.Comment.Dto
{
	public class CommentDetailDto
	{
		public string Author { get; set; }
		public string Content { get; set; }
		public string Email { get; set; }
		public bool IsAdmin { get; set; }
		public DateTime PubDate { get; set; }
		public Guid Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
	}
}
