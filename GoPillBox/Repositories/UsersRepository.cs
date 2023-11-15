using GoPillBox.Database;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace GoPillBox.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly GoPillBoxDbContext _dbContext;

        public UsersRepository(GoPillBoxDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public async Task<List<User>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> ReadAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User?> CreateAsync(UserView newUser)
        {
            throw new NotImplementedException();
        }

        public Task<User?> DeleteAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User?> UpdateAsync(int id, UserView modifiedUser)
        {
            throw new NotImplementedException();
        }
    }
}
