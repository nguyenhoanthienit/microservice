using Common.ApiResponse;
using MediatR;
using Post.Data.Context;
using Post.Domain.Contracts;
using Post.Domain.Entities;
using Post.Service.Post.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Post.Service.Post.Handlers
{
	public class DeletePostHandler : IRequestHandler<DeletePostRequest, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;

		public DeletePostHandler(IUnitOfWork<WriteDbContext> unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<ApiResult> Handle(DeletePostRequest request, CancellationToken cancellationToken)
		{
			var repo = _unitOfWork.GetRepository<PostEntity>();
			repo.Delete(Guid.Parse(request.Id));
			await _unitOfWork.CommitAsync();
			return ApiResult.Succeeded(request.Id);
		}
	}
}
