using FitnessTracker.Context;
using FitnessTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Services
{
    public class CheatMealService
    {
        public void CreateCheatMeal(CheatMeal cheatMeal)
        {
            cheatMealDetails.CreateCheatMeal(cheatMeal);
        }

        public List<CheatMeal> GetCheatMeals()
        {
            return cheatMealDetails.GetCheatMeals();
        }

        public CheatMeal GetCheatMealById(int id)
        {
            return cheatMealDetails.GetCheatMealById(id);
        }

        public void DeleteCheatMeal(int id)
        {
            cheatMealDetails.DeleteCheatMeal(id);
        }

        public List<CheatMeal> GetWeeklyCheatMeals(DateTime startDate, DateTime endDate)
        {
            return cheatMealDetails.GetWeeklyCheatMeals(startDate, endDate);
        }

        public void EditCheatMeal(int cheatMealId, CheatMeal newCheatMeal)
        {
            cheatMealDetails.EditCheatMeal(cheatMealId, newCheatMeal);
        }
    }
}
