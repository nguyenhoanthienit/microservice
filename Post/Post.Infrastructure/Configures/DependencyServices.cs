using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Post.Data.Context;
using Post.Data.EntityFramework;
using Post.Domain.Contracts;
using Post.Infrastructure.Mediators;
using Post.Service.Post.Commands;
using Post.Service.Post.Handlers;
using Post.Service.Post.PostDto;
using Post.Service.Post.Queries;
using static Post.Service.Post.Queries.GetPostByIdQuery;

namespace Post.Infrastructure.Configures
{
	public static class DependencyServices
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			#region Orders
			services.AddService<CreatePostRequest, CreatePostHandler>();
			services.AddService<GetPostByIdQuery, GetPostByIdHandler>();
			#endregion

			return services;
		}
	}
}