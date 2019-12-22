using System.Collections.Generic;
using System.Linq;
using Movietheque.Data.Models;
using Movietheque.Models.ViewModels;

namespace Movietheque.Models.Converters
{
    public static class UserConverter
    {
        public static UserViewModel Convert(this User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Login = user.Login,
                Password = user.Password
            };
        }

        public static User Convert(this UserViewModel userViewModel)
        {
            return new User
            {
                Id = userViewModel.Id,
                Email = userViewModel.Email,
                Login = userViewModel.Login,
                Password = userViewModel.Password
            };
        }

        public static List<UserViewModel> Convert(this List<User> users)
        {
            return users.Select(user => user.Convert()).ToList();
        }
    }
}