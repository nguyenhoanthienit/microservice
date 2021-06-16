using Common.ApiResponse;
using MediatR;
using Post.Data.Context;
using Post.Domain.Contracts;
using Post.Domain.Entities;
using Post.Service.Category.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Post.Service.Category.Dto;
using Microsoft.EntityFrameworkCore;

namespace Post.Service.Category.Handlers
{
	public class GetCategoryByPostIdHandler : IRequestHandler<GetCategoryByPostIdQuery, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;

		public GetCategoryByPostIdHandler(IUnitOfWork<ReadDbContext> unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<ApiResult> Handle(GetCategoryByPostIdQuery request, CancellationToken cancellationToken)
		{
			var res = await _unitOfWork.GetRepository<PostCategoryEntity>().TableNoTracking
				.Where(c => c.PostId.ToString() == request.Id)
				.Select(c => new CategoryDetailDto
				{
					Id = c.CategoryId,
					Name = c.Category.Name
				}).ToListAsync();

			return ApiResult.Succeeded(res);
		}
	}
}
