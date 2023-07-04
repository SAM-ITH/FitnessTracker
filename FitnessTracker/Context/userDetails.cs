using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.Models;

namespace FitnessTracker.Context
{
    public static class userDetails
    {
        private static Hashtable _users;
        private static Hashtable _userProfiles;
        private static UserProfile _currentProfile;
        private static Hashtable _workouts;
        private static bool _isUserAuthenticated = false;

        public static void InitializeUserDetails()
        {
            _users = new Hashtable
            {
                [1] = new User
                { UserId = 2, FirstName = "James", LastName = "Anthony", Age = 30, Height = 170, Weight = 65.5f, },
                [2] = new User
                { UserId = 2, FirstName = "John", LastName = "Wick", Age = 40, Height = 180, Weight = 75.5f, },
            };

            // profiles
            _userProfiles = new Hashtable
            {
                ["samith"] = new UserProfile
                { ProfileId = 1, User = (User)_users[1], UserName = "samith", Password = "samith" },
                ["JohnWick"] = new UserProfile
                { ProfileId = 2, User = (User)_users[2], UserName = "JohnWick", Password = "user@123" },
            };

            // workouts 
            _workouts = new Hashtable();

        }

        public static UserProfile CurrentProfile
        {
            get
            {
                return _currentProfile;
            }
        }

        public static bool IsUserAuthenticated
        {
            get
            {
                return _isUserAuthenticated;
            }
        }

        public static void CreateUser(UserProfile profile)
        {
            // generate the user id.
            var currentLength = _users.Count;
            var newUserId = currentLength + 1;
            profile.User.UserId = newUserId;

            // add new user
            _users.Add(newUserId, profile.User);
            // add to profile.
            _userProfiles.Add(profile.UserName, profile);

            // set the current profile.
            _currentProfile = profile;
            _isUserAuthenticated = true;
        }

        public static bool IsUserAvailableForUserName(string userName)
        {
            return _userProfiles.Contains(userName);
        }

        public static bool IsUserCredentialsValid(string userName, string password)
        {
            if (IsUserAvailableForUserName(userName))
            {
                var userProfile = (UserProfile)_userProfiles[userName];
                return userProfile?.Password == password;
            }

            return false;
        }

        public static bool Login(string userName, string password)
        {
            if (IsUserCredentialsValid(userName, password))
            {
                _currentProfile = (UserProfile)_userProfiles[userName];
                _isUserAuthenticated = true;
                return true;
            }

            return false;
        }
    }
}