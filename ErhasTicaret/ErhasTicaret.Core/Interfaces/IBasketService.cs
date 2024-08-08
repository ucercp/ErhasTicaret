using ErhasTicaret.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErhasTicaret.Core.Interfaces
{
    public interface IBasketService
    {
        Task<IEnumerable<BasketDTO>> GetAllBasketItemsAsync();
        Task<BasketDTO> GetBasketItemByIdAsync(string id);
        Task AddBasketItemAsync(BasketDTO basketDto);
        Task UpdateBasketItemAsync(BasketDTO basketDto);
        Task DeleteBasketItemAsync(string id);
    }
}
