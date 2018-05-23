using AutoMapper;
using CoreApp.Core.Concrete;

namespace CoreApp.WebUI.Models
{
    public class ScoutMappingProfile : Profile
    {
        public ScoutMappingProfile()
        {
            CreateMap<Scout, ScoutViewModel>()
                .ReverseMap();
        }
    }
}
