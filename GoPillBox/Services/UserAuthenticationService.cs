using GoPillBox.Database;
using GoPillBox.Models.ViewModels;

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

        public async bool AreCredentialsValid(UserView userCredentials)
        {
            try
            {
                var user = await this._goPillBoxDbContext.Users.FindAsync(userCredentials);
            }
            catch (Exception ex)
            {
                this._logger.LogException(ex);
                throw;
            }
        }
    }
}
