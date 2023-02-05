using AutoMapper;

namespace ApplicationTotalSystem.Profiles
{
	using ApplicationTotalSystem.Dto.Products;
	using DomainTotoalSystem.Entities;

	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			//CreateMap<User, UserViewModel>()
			//    .ForMember(dest => dest.UserName, i => i.MapFrom(src => src.FirstName + " " + src.LastName))
			//    .ForMember(dest => dest.Age, i =>
			//    {
			//        i.PreCondition(src => src.Age > 21);
			//        i.MapFrom(src => src.Age);
			//    });
			//CreateMap<User, UserViewModel>()
			//    .ForMember(dest => dest.UserName, i => i.MapFrom(src => src.FirstName + " " + src.LastName))
			//    .ForMember(dest => dest.Age, i => i.MapFrom(src => src.Age > 21 ? src.Age : -1))
			//    .ReverseMap();
			//CreateMap<User, UserViewModel>();
			//CreateMap<UserViewModel, User>();	
			CreateMap<Product, ProductListDto>().ReverseMap();
		}


	}
}
