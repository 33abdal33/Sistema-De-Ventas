using AutoMapper;
using Sistema_De_Ventas.DTO.Request;
using Sistema_De_Ventas.DTO.Response;
using Sistema_De_Ventas.Models;
using Sistema_De_Ventas.Repository;
using Sistema_De_Ventas.Services.Interfaces;

namespace Sistema_De_Ventas.Services.Implementation
{
    public class ProductoServices : IProductoServices
    {
        private readonly IProductoRepository repository;
        private readonly ILogger<ProductoServices> logger;
        private readonly IMapper mapper;

        public ProductoServices( IProductoRepository repository , ILogger<ProductoServices> logger, IMapper mapper)
        {
            this.repository = repository;
            this.logger = logger;
            this.mapper = mapper;
        }
        public async Task<BaseResponseGeneric<int>> AddAsync(ProductoRequestDto request)
        {
            var response = new BaseResponseGeneric<int>();
            Producto entity = new();
            try
            {
                entity = mapper.Map<Producto>(request);
                response.Data = await repository.AddAsync(entity);
                response.Success = true;
            }
            catch(Exception ex)
            {
                response.ErrorMessage = "Ocurrio un error al añadir un producto";
                logger.LogError(ex, "{ErrorMessage] {Message}", response.ErrorMessage, ex.Message);
            }

            return response;
        }

        public Task<BaseResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseGeneric<ProductoResponseDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse> UpdateAsync(int id, ProductoRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
