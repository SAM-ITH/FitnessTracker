using FitnessTracker.Context;
using FitnessTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Services
{
    public class WorkoutService
    {
        public void CreateWorkout(Workout workout)
        {
            workoutDetails.CreateWorkout(workout);
        }

        public List<Workout> GetWorkouts()
        {
            return workoutDetails.GetWorkouts();
        }
    }
}
