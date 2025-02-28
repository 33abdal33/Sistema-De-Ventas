using AutoMapper;
using Sistema_De_Ventas.DTO.Request;
using Sistema_De_Ventas.DTO.Response;
using Sistema_De_Ventas.Models;
using Sistema_De_Ventas.Models.Info;

namespace Sistema_De_Ventas.Services.Mapping_Profile
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile() 
        {
            CreateMap<ProductoInfo, ProductoResponseDto>();
            CreateMap<Producto, ProductoResponseDto>();
            CreateMap<ProductoRequestDto, Producto>();
        }

    }
}
