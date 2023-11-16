using GoPillBox.Database;
using GoPillBox.Mappers;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using GoPillBox.Services;
using Microsoft.EntityFrameworkCore;

namespace GoPillBox.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly GoPillBoxDbContext _dbContext;
        private readonly ILoggingService _logger;

        public UsersRepository(GoPillBoxDbContext dbContext, ILoggingService logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }


        public async Task<List<User>> ReadAllAsync()
        {
            try
            {
                List<User> users = await this._dbContext.Users.ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<User?> ReadAsync(int userId)
        {
            try
            {
                User? user = await this._dbContext.Users.FindAsync(userId);
                return user;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<User?> CreateAsync(UserView newUser)
        {
            try
            {
                User newUserModel = UserMapper.ToModel(newUser);
                var createdUser = await this._dbContext.AddAsync(newUserModel);
                await this._dbContext.SaveChangesAsync();
                if(createdUser == null)
                    return null;
                return createdUser.Entity;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public async Task<User?> DeleteAsync(int userId)
        {
            try
            {
                User userToDelete = new User { UserId = userId };
                var deletedUser = this._dbContext.Users.Remove(userToDelete);
                await this._dbContext.SaveChangesAsync();
                if(deletedUser == null) return null;
                return deletedUser.Entity;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }

        public Task<User?> UpdateAsync(int id, UserView modifiedUser)
        {
            try
            {
                User updatedUser = UserMapper.ToModel(modifiedUser, id);
                this._dbContext.Users.Attach(updatedUser);
                this._dbContext.
                this._dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }
    }
}
