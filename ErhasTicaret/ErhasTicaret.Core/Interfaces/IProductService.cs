using ErhasTicaret.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErhasTicaret.Core.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(string id);
        Task AddProductAsync(ProductDTO productDto);
        Task UpdateAsync(ProductDTO productDto);
        Task DeleteAsync(string id);
    }
}
