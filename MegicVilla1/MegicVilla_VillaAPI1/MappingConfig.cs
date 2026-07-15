using AutoMapper;
using MegicVilla_VillaAPI1.Models;
using MegicVilla_VillaAPI1.Models.Dto;
using System.Runtime;

namespace MegicVilla_VillaAPI1
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}
