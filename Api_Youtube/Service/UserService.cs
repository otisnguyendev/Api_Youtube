using Api_Youtube.Dto;
using Api_Youtube.Dto.Response;

namespace Api_Youtube.Service;

public interface UserService
{
    Task<List<UserDto>> GetAllUsersAsync();
    Task<UserDto?> GetUserByIdAsync(int id);
    Task<bool> RegisterUserAsync(RegisterDto request);
    Task<LoginResponseDto?> LoginUserAsync(string email, string password);
    Task<bool> ChangePasswordAsync(int userId, string oldPassword, string newPassword);
    Task<bool> UpdateProfileAsync(int userId, UpdateProfileDto request);
    Task<List<UserDto>> SearchUsersAsync(string keyword);
}