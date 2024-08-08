using ErhasTicaret.Data.Data;
using ErhasTicaret.Data.Interfaces;
using ErhasTicaret.Domain.Models;

namespace ErhasTicaret.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(Context context) : base(context)
        {
        }
    }
}
