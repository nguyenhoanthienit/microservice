using Common.ApiResponse;
using MediatR;
using Post.Data.Context;
using Post.Domain.Contracts;
using Post.Domain.Entities;
using Post.Service.Post.Dto;
using Post.Service.Post.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Post.Service.Category.Dto;
using Post.Service.Comment.Dto;

namespace Post.Service.Post.Handlers
{
	public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;

		public GetPostByIdHandler(IUnitOfWork<ReadDbContext> unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<ApiResult> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
		{
			var res = await _unitOfWork.GetRepository<PostEntity>().TableNoTracking
				.Where(c => c.Id.ToString() == request.Id)
				.Select(c => new PostDetailDto
				{
					Id = c.Id,
					Content = c.Content,
					CreatedAt = c.CreatedAt,
					CreatedBy = c.CreatedBy,
					Excerpt = c.Excerpt,
					IsPublished = c.IsPublished,
					LastModified = c.LastModified,
					Slug = c.Slug,
					Title = c.Title,
					PubDate = c.PubDate,
					UpdatedAt = c.UpdatedAt,
					UpdatedBy = c.UpdatedBy,
					Categories = c.PostCategories.Where(p => p.PostId == c.Id).Select(p => new CategoryDetailDto
					{
						Id = p.PostId,
						Name = p.Category.Name,
					}).ToList(),
					Comments = c.PostComments.Where(p => p.PostId == c.Id).Select(m => new CommentDetailDto
					{
						Id = m.Id,
						Author = m.Author,
						Content = m.Content,
						Email = m.Email,
						PubDate = m.PubDate,
						CreatedAt = m.CreatedAt,
						UpdatedAt = m.UpdatedAt
					}).ToList()
				}).SingleOrDefaultAsync();

			return ApiResult.Succeeded(res);
		}
	}
}
