using ErhasTicaret.Data.Data;
using ErhasTicaret.Data.Interfaces;
using ErhasTicaret.Domain.Models;

namespace ErhasTicaret.Data.Repositories
{
    public class BasketRepository : GenericRepository<BasketItem>, IBasketRepository
    {
        public BasketRepository(Context context) : base(context)
        {
        }
    }
}
