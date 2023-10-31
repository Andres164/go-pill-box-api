using GoPillBox.Models.ViewModels;
using GoPillBox.Models;

namespace GoPillBox.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<List<User>> ReadAllAsync();
        Task<User?> ReadAsync(int userId);
        Task<User?> CreateAsync(UserView newUser);
        Task UpdateAsync(UserView modifiedUser);
        Task DeleteAsync(int userId);
    }
}
