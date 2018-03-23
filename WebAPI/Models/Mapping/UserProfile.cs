using AutoMapper;
using System;
using WebAPI.Data.Models;

namespace WebAPI.Models.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterModel, User>()
                 .ForMember(dst => dst.UserID, opt => opt.Ignore())
                 .ForMember(dst => dst.PrefixID, opt => opt.Ignore())
                 .ForMember(dst => dst.Prefix, opt => opt.Ignore())
                 .ForMember(dst => dst.MiddleName, opt => opt.Ignore())
                 .ForMember(dst => dst.SuffixID, opt => opt.Ignore())
                 .ForMember(dst => dst.Suffix, opt => opt.Ignore())
                 .ForMember(dst => dst.NormalizedUsername, opt => opt.MapFrom(src => src.Username.ToUpper()))
                 .ForMember(dst => dst.NormalizedEmail, opt => opt.MapFrom(src => src.Email.ToUpper()))
                 .ForMember(dst => dst.PasswordHash, opt => opt.MapFrom(src => src.Password))
                 .ForMember(dst => dst.CreatedOn, opt => opt.UseValue(DateTime.UtcNow))
                 .ForMember(dst => dst.UpdatedOn, opt => opt.Ignore());
        }
    }
}
