using Common.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Service.Post.Commands
{
	public class UpdatePostRequest : IRequest<ApiResult>
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
	}
}
