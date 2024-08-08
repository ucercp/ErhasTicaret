using ErhasTicaret.Core.DTOs;
using ErhasTicaret.Core.Interfaces;
using ErhasTicaret.Data.Interfaces;
using ErhasTicaret.Domain.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using ErhasTicaret.Services.Interfaces;

namespace ErhasTicaret.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO> GetUserByIdAsync(string id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task AddUserAsync(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userRepository.AddAsync(user);
        }

        public async Task UpdateUserAsync(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(string id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            await _userRepository.DeleteAsync(user);
        }

        public async Task<UserDTO> GetUserProfileAsync(string id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

    

        public async Task<UserDTO> GetByIdAsync(string id)
        {
            // Kullanıcıyı ID'ye göre veritabanından alma
            var user = await _userRepository.GetByIdAsync(id);

            // Kullanıcı bulunamadıysa hata fırlatma
            if (user == null)
            {
                throw new KeyNotFoundException($"ID {id} ile kullanıcı bulunamadı.");
            }

            // Kullanıcıyı DTO'ya dönüştürme
            var userDto = new UserDTO
            {
                UserId = user.UserId,
                UserName = user.UserName,
                UserRole = user.UserRole
                // Diğer gerekli alanlar burada eklenebilir
            };

            return userDto;
        }

    }
}
