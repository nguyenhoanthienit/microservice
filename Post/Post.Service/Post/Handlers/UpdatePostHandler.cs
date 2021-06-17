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
using System.Linq;
using Post.Service.Post.Dto;

namespace Post.Service.Post.Handlers
{
	public class UpdatePostHandler : IRequestHandler<UpdatePostRequest, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;

		public UpdatePostHandler(IUnitOfWork<WriteDbContext> unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<ApiResult> Handle(UpdatePostRequest request, CancellationToken cancellationToken)
		{
			//var repo = _unitOfWork.GetRepository<PostEntity>();
			//var post = await repo.SingleOrDefaultAsync<PostEntity>(c => c.Id.ToString() == request.Id);
			throw new NotImplementedException();
		}
	}
}
