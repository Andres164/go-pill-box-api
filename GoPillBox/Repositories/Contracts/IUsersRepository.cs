using GoPillBox.Models.ViewModels;
using GoPillBox.Models;

namespace GoPillBox.Repositories.Contracts
{
    public interface IUsersRepository
    {
        Task<List<User>> ReadAllAsync();
        Task<User?> ReadAsync(int userId);
        Task<User?> CreateAsync(UserView newUser);
        Task<User?> UpdateAsync(int id, UserView modifiedUser); 
        Task<User?> DeleteAsync(int userId);
    }
}
