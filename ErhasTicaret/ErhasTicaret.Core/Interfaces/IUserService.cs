using ErhasTicaret.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErhasTicaret.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(string id);
        Task AddUserAsync(UserDTO userDto);
        Task UpdateUserAsync(UserDTO userDto);
        Task DeleteUserAsync(string id);
        Task<UserDTO> GetUserProfileAsync(string id);
     
    }
}
