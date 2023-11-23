using GoPillBox.Database;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace GoPillBox.Services
{
    public class UserAuthenticationService
    {
        private readonly GoPillBoxDbContext _goPillBoxDbContext;
        private readonly ILoggingService _logger;

        public UserAuthenticationService(GoPillBoxDbContext goPillBoxDbContext, ILoggingService logger) 
        {
            this._goPillBoxDbContext = goPillBoxDbContext;
            this._logger = logger;
        }

        public async Task<bool> AreCredentialsValid(UserView userCredentials)
        {
            try
            {
                User? user = await this._goPillBoxDbContext.Users.FirstOrDefaultAsync(u => u.UserName == userCredentials.UserName);
                if (user == null) 
                    return false;
                if(user.Password != userCredentials.Password) 
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }
    }
}
