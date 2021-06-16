using Common.ApiResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Post.Service.Category.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.API.Controllers.v1
{
	[ApiVersion("1.0")]
	[Route("api/v{version:apiVersion}/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CategoriesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategoryByPostId(string id)
		{
			try
			{
				return Ok(await _mediator.Send(new GetCategoryByPostIdQuery { Id = id }));
			}
			catch(Exception ex)
			{
				return ApiResult.Failed(Common.ErrorResult.ErrorCode.BAD_REQUEST);
			}
		}
	}
}
