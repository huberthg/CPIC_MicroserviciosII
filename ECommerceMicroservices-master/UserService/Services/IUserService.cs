using UserService.DTOs;

namespace UserService.Services
{
    public interface IUserService
    {
        Task<UserDto> RegisterAsync(RegisterDto dto);
        Task<UserDto?> ValidateCredentialsAsync(string email, string password);
        Task<UserDto?> GetUserByIdAsync(int id);
        Task<List<UserDto>> GetAllUsersAsync();
        Task<bool> ValidateEmailGDPRAsync(int userId);
        Task<decimal?> GetUserDiscountAsync(int userId);

        Task<UserDto?> CreateUserAsync(CreateUserDto dto);
        Task<UserDto?> UpdateUserAsync(int id, UpdateUserDto dto);

        Task<bool> DeleteUserAsync(int id);
    }
}
