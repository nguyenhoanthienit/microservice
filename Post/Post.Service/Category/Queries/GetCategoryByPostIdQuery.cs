using Common.ApiResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Service.Category.Queries
{
	public class GetCategoryByPostIdQuery : IRequest<ApiResult>
	{
		public string Id { get; set; }
	}
}
