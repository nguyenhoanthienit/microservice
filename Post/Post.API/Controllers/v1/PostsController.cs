using Common.Constants;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Post.Infrastructure.ApiRoute;
using Post.Service.Post.Commands;
using Post.Service.Post.Queries;
using System;
using System.Threading.Tasks;

namespace Post.API.Controllers.v1
{
	[ApiVersion("1.0")]
	[Route("api/v{version:apiVersion}/[controller]")]
	[ApiController]
	public class PostsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public PostsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost(ApiRoutes.Post.CREATE)]
		public async Task<IActionResult> CreateAsync(CreatePostRequest request)
		{
			return await _mediator.Send(request);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetPostById(string id)
		{
			try
			{
				return Ok(await _mediator.Send(new GetPostByIdQuery { Id = id }));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return StatusCode(400);
			}
		}
	}
}
