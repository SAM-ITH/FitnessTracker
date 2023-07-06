using FitnessTracker.Context;
using FitnessTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Services
{
    public class UserService
    {
        public void CreateUser(UserProfile profile)
        {
            userDetails.CreateUser(profile);
        }

        public bool IsUsernameExist(string username)
        {
            return userDetails.IsUserAvailableForUserName(username);
        }

        public void Logout()
        {
            userDetails.Logout();
        }

        public string GetUserFirstName()
        {
            return userDetails.GetUserFirstName();
        }

        public UserProfile GetUserProfile()
        {
            return userDetails.CurrentProfile;
        }
    }
}
