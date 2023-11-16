using GoPillBox.Models;
using GoPillBox.Models.ViewModels;

namespace GoPillBox.Mappers
{
    public static class UserMapper
    {
        public static User ToModel(UserView fromView, int userId = 0)
        {
            return new User
            {
                UserId = userId,
                UserName = fromView.UserName,
                Password = fromView.Password
            };
        }
    }
}
