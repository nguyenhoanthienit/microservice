using AutoMapper;
using Post.Domain.Entities;
using Post.Service.Post.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.Infrastructure.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Post
			CreateMap<CreatePostRequest, PostEntity>();

		}
	}
}