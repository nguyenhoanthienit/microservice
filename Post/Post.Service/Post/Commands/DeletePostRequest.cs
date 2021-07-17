using Common.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Service.Post.Commands
{
	public class DeletePostRequest : IRequest<ApiResult>
	{
		public string Id { get; set; }
	}
}
