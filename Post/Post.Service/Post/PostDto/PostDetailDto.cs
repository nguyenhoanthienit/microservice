using Post.Service.Category.Dto;
using Post.Service.Comment.CommentDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Service.Post.PostDto
{
	public class PostDetailDto
	{
		public string Content { get; set; }
		public string Excerpt { get; set; }
		public Guid Id { get; set; }
		public bool IsPublished { get; set; }
		public DateTime LastModified { get; set; }
		public DateTime PubDate { get; set; }
		public string Slug { get; set; }
		public string Title { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public List<CommentDetailDto> Comments { get; set; }
		public List<CategoryDetailDto> CategoryDto { get; set; }
	}
}
