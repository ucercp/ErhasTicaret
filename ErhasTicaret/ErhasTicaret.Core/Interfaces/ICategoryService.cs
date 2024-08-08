using ErhasTicaret.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErhasTicaret.Core.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();  // GetAllAsync yerine
        Task<CategoryDTO> GetCategoryByIdAsync(string id);         // GetByIdAsync yerine
        Task AddCategoryAsync(CategoryDTO categoryDto);         // AddAsync yerine
        Task UpdateCategoryAsync(CategoryDTO categoryDto);      // UpdateAsync yerine
        Task DeleteCategoryAsync(string id);                       // DeleteAsync yerine
    }
}
