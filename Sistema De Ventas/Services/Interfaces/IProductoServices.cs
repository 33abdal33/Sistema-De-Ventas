using Sistema_De_Ventas.DTO.Request;
using Sistema_De_Ventas.DTO.Response;

namespace Sistema_De_Ventas.Services.Interfaces
{
    public interface IProductoServices
    {
        Task<BaseResponseGeneric<ProductoResponseDto>> GetAsync(int id);
        Task<BaseResponseGeneric<int>> AddAsync(ProductoRequestDto request);
        Task<BaseResponse> UpdateAsync(int id, ProductoRequestDto request);
        Task<BaseResponse> DeleteAsync(int id);
    }
}
