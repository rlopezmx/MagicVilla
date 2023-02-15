using AutoMapper;
using MagucVilla_API.Modelos;
using MagucVilla_API.Modelos.Dto;

namespace MagucVilla_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();

            CreateMap<Villa, VillaCreateDto>().ReverseMap();
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();

            CreateMap<Productos, ProductosDto>().ReverseMap();

        }    

    }
}
