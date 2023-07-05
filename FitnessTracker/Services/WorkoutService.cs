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

        public Workout GetWorkoutById(int id)
        {
            return workoutDetails.GetWorkoutById(id);
        }

        public void DeleteWorkout(int workoutId)
        {
            workoutDetails.DeleteWorkout(workoutId);
        }

        public List<Workout> GetWeeklyWorkouts(DateTime startDate, DateTime endDate)
        {
            return workoutDetails.GetWeeklyWorkouts(startDate, endDate);
        }

        public void EditWorkout(int workoutId, Workout newWorkout)
        {
            workoutDetails.EditWorkout(workoutId, newWorkout);
        }
    }
}
