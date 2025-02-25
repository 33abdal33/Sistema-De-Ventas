using Sistema_De_Ventas.DTO.Request;
using Sistema_De_Ventas.DTO.Response;
using Sistema_De_Ventas.Services.Interfaces;

namespace Sistema_De_Ventas.Services.Implementation
{
    public class ProductoServices : IProductoServices
    {
        public ProductoServices( )
        {
            
        }
        public Task<BaseResponseGeneric<int>> AddAsync(ProductoRequestDto request)
        {
            throw new NotImplementedException();
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
