using AutoMapper;
using AdminLayout.Models;
using System.Security.Claims;
using AdminLayout.Areas.Admin.Models;

namespace AdminLayout
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));

            CreateMap<ExternalLoginModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email))
                .ForMember(u => u.FirstName, opt => opt.MapFrom(x => x.Principal.FindFirst(ClaimTypes.Surname).Value))
                .ForMember(u => u.LastName, opt => opt.MapFrom(x => x.Principal.FindFirst(ClaimTypes.GivenName).Value));
        }
    }
}
