using ErhasTicaret.Core.DTOs;
using ErhasTicaret.Core.Interfaces;
using ErhasTicaret.Data.Interfaces;
using ErhasTicaret.Domain.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErhasTicaret.Services.Services
{
    public class BasketService : IBasketService
    {
        private readonly IGenericRepository<BasketItem> _basketRepository;
        private readonly IMapper _mapper;

        public BasketService(IGenericRepository<BasketItem> basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BasketDTO>> GetAllBasketItemsAsync()
        {
            var basketItems = await _basketRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BasketDTO>>(basketItems);
        }

        public async Task<BasketDTO> GetBasketItemByIdAsync(string id)
        {
            var basketItem = await _basketRepository.GetByIdAsync(id);
            return _mapper.Map<BasketDTO>(basketItem);
        }

        public async Task AddBasketItemAsync(BasketDTO basketDto)
        {
            var basketItem = _mapper.Map<BasketItem>(basketDto);
            await _basketRepository.AddAsync(basketItem);
        }

        public async Task UpdateBasketItemAsync(BasketDTO basketDto)
        {
            var basketItem = _mapper.Map<BasketItem>(basketDto);
            await _basketRepository.UpdateAsync(basketItem);
        }

        public async Task DeleteBasketItemAsync(string id)
        {
            var basketItem = await _basketRepository.GetByIdAsync(id);
            if (basketItem != null)
            {
                await _basketRepository.DeleteAsync(basketItem);
            }
        }
    }
}
