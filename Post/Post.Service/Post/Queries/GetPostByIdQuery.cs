using MediatR;
using Post.Domain.Contracts;
using Post.Domain.Entities;
using Post.Service.Post.PostDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Post.Service.Post.Queries
{
	public class GetPostByIdQuery : IRequest<PostDetailDto>
	{
		public string Id { get; set; }
		
		public class GetPostByIdQueryHandler : IRequestHandler<GetPostByIdQuery, PostDetailDto>
		{

			private readonly IUnitOfWork _unitOfWork;

			public GetPostByIdQueryHandler(IUnitOfWork unitOfWork)
			{
				_unitOfWork = unitOfWork;
			}
			
			public Task<PostDetailDto> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
			{
				throw new NotImplementedException();
			}
		}
	}
}
