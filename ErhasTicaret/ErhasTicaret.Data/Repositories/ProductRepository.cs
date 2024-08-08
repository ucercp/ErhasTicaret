using ErhasTicaret.Data.Data;
using ErhasTicaret.Data.Interfaces;
using ErhasTicaret.Domain.Models;

namespace ErhasTicaret.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(Context context) : base(context)
        {
        }
    }
}
