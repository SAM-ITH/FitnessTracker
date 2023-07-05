using FitnessTracker.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Context
{
    public static class cheatMealDetails
    {
        private static Hashtable _cheatMeals;

        public static void InitializeCheatMealDetails()
        {
            _cheatMeals = new Hashtable();
        }

        public static void CreateCheatMeal(CheatMeal cheatMeal)
        {
            string userName = userDetails.CurrentProfile.UserName;
            if (_cheatMeals.ContainsKey(userName))
            {
                var cheatMeals = (List<CheatMeal>)_cheatMeals[userName];
                int newCheatMealId = cheatMeals.Count + 1;
                cheatMeal.Id = newCheatMealId;
                cheatMeals.Add(cheatMeal);
                _cheatMeals[userName] = cheatMeals;
            }
            else
            {
                cheatMeal.Id = 1;
                var cheatMeals = new List<CheatMeal> { cheatMeal };
                _cheatMeals.Add(userName, cheatMeals);
            }
        }

        public static List<CheatMeal> GetCheatMeals()
        {
            string userName = userDetails.CurrentProfile.UserName;
            if (_cheatMeals.ContainsKey(userName))
            {
                return (List<CheatMeal>)_cheatMeals[userName];
            }

            return new List<CheatMeal>();
        }

        public static CheatMeal GetCheatMealById(int id)
        {
            var userName = userDetails.CurrentProfile.UserName;
            if (_cheatMeals.ContainsKey(userName))
            {
                var cheatMeals = (List<CheatMeal>)_cheatMeals[userName];
                return cheatMeals.First(cm => cm.Id == id);
            }

            return null;
        }

        public static void DeleteCheatMeal(int id)
        {
            string userName = userDetails.CurrentProfile.UserName;
            if (_cheatMeals.ContainsKey(userName))
            {
                var cheatMeals = (List<CheatMeal>)_cheatMeals[userName];
                cheatMeals.RemoveAll(cm => cm.Id == id);
                _cheatMeals[userName] = cheatMeals;
            }
        }
    }
}
