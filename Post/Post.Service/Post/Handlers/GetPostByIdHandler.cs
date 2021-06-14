using Common.ApiResponse;
using MediatR;
using Post.Data.Context;
using Post.Domain.Contracts;
using Post.Service.Post.PostDto;
using Post.Service.Post.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Post.Service.Post.Handlers
{
	public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;

		public GetPostByIdHandler(IUnitOfWork<ReadDbContext> unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public Task<ApiResult> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
