using Common.ApiResponse;
using MediatR;
using Post.Domain.Contracts;
using Post.Domain.Entities;
using Post.Service.Post.PostDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Post.Service.Post.Queries
{
	public class GetPostByIdQuery : IRequest<ApiResult>
	{
		public string Id { get; set; }
	}
}
