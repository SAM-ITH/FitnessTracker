using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class DailyDetail
    {
        public DateTime Created { get; set; }

        public List<Workout> Workouts { get; set; }

        public List<CheatMeal> CheatMeals { get; set; }
    }
}
