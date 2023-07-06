using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.Utils;
using FitnessTracker.Models;


namespace FitnessTracker.Services
{
    public class WeeklyViewService
    {
        private WorkoutService _workoutService;
        private CheatMealService _cheatMealService;

        public WeeklyViewService()
        {
            _workoutService = new WorkoutService();
            _cheatMealService = new CheatMealService();
        }

        public bool WeeklyDetailsAvailable(DateTime today)
        {
            var (startDate, endDate) = DateUtil.GetStartEndWeekDates(today);
            var inBetweenDates = DateUtil.GetInBetweenDates(today);
            var weeklyWorkouts = _workoutService.GetWeeklyWorkouts(startDate, endDate);
            var weeklyCheatMeals = _cheatMealService.GetWeeklyCheatMeals(startDate, endDate);

            return (weeklyWorkouts.Any() || weeklyCheatMeals.Any());
        }

        public List<DailyDetail> GetWeeklyDetails(DateTime today)
        {
            var (startDate, endDate) = DateUtil.GetStartEndWeekDates(today);
            var inBetweenDates = DateUtil.GetInBetweenDates(today);
            var weeklyWorkouts = _workoutService.GetWeeklyWorkouts(startDate, endDate);
            var weeklyCheatMeals = _cheatMealService.GetWeeklyCheatMeals(startDate, endDate);

            var weeklyWorkoutGroup = weeklyWorkouts.GroupBy(wk => wk.Created).ToList();
            var weeklyCheatMeaLlGroupList = weeklyCheatMeals.GroupBy(cm => cm.Created).ToList();
            var weeklyDetails = new List<DailyDetail>();
            var workoutDict = GetDateTimeDict(weeklyWorkoutGroup, weeklyWorkouts);
            var cheatMealDict = GetDateTimeDict(weeklyCheatMeaLlGroupList, weeklyCheatMeals);

            foreach (var date in inBetweenDates)
            {
                var dailyDetail = new DailyDetail
                {
                    Created = date,
                    Workouts = GetItemsFromDict(workoutDict, date),
                    CheatMeals = GetItemsFromDict(cheatMealDict, date)
                };
                weeklyDetails.Add(dailyDetail);
            }
            return weeklyDetails;
        }

        private Dictionary<DateTime, List<T>> GetDateTimeDict<T>(List<IGrouping<DateTime, T>> groups, List<T> items) where T : GeneralDetails
        {
            var dict = new Dictionary<DateTime, List<T>>();

            foreach (var group in groups)
            {
                var list = items.Where(item => item.Created == group.Key).ToList();
                dict.Add(group.Key, list);
            }

            return dict;
        }

        private List<T> GetItemsFromDict<T>(Dictionary<DateTime, List<T>> dict, DateTime key)
        {
            if (dict.ContainsKey(key))
            {
                return dict[key];
            }

            return new List<T>();
        }
    }
}
