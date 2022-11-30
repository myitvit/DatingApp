using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDTO>()
            .ForMember(destination => destination.PhotoUrl,
                options => options.MapFrom(
                    source => source.Photos.FirstOrDefault(x => x.IsMain).Url)
                );
            CreateMap<Photo, PhotoDTO>();
        }
    }
}