using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>().ForMember(d => d.ProcutType, o => o.MapFrom(s => s.ProcutType.Name)).
            ForMember
        }
    }
}