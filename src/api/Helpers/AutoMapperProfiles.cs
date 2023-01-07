using System.Linq;
using API.DTOs;
using API.Entities;
using API.Extensions;
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
                )
            .ForMember(destination => destination.Age, options => options.MapFrom(
                source => source.DateOfBirth.CalculateAge()
            ));

            CreateMap<Photo, PhotoDTO>();

            CreateMap<MemberUpdateDTO, AppUser>();
        }
    }
}