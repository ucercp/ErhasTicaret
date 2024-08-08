using ErhasTicaret.Data.Data;
using ErhasTicaret.Data.Interfaces;
using ErhasTicaret.Domain.Models;

namespace ErhasTicaret.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }
    }
}
