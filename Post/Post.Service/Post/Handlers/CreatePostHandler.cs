﻿using AutoMapper;
using Common.ApiResponse;
using Common.ErrorResult;
using MediatR;
using Microsoft.Extensions.Logging;
using Post.Data.Context;
using Post.Domain.Contracts;
using Post.Domain.Entities;
using Post.Service.Post.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Post.Service.Post.Handlers
{
	public class CreatePostHandler : IRequestHandler<CreatePostRequest, ApiResult>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILogger _logger;

		public CreatePostHandler(IUnitOfWork<WriteDbContext> unitOfWork, IMapper mapper, ILogger<CreatePostHandler> logger)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<ApiResult> Handle(CreatePostRequest request, CancellationToken cancellationToken)
		{

			try
			{
				var post = _mapper.Map<PostEntity>(request);
				post.Id = Guid.NewGuid();

				await _unitOfWork.GetRepository<PostEntity>().InsertAsync(post, cancellationToken);
				await _unitOfWork.CommitAsync();

				return ApiResult.Succeeded();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.ToString());
				return ApiResult.Failed(HttpCode.InternalServerError);
			}
		}
	}
}
