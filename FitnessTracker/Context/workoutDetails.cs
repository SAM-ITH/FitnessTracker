using FitnessTracker.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Context
{
        public static class workoutDetails
        {
            private static Hashtable _workouts;

            public static void InitializeWorkoutDetails()
            {
                _workouts = new Hashtable();
            }

            public static void CreateWorkout(Workout workout)
            {
                var userName = userDetails.CurrentProfile.UserName;
                if (_workouts.ContainsKey(userName))
                {
                    // get workout list.
                    var workoutList = (List<Workout>)_workouts[userName];
                    workoutList.Add(workout);
                    _workouts[userName] = workoutList;
                }
                else
                {
                    List<Workout> workouts = new List<Workout> { workout };
                    _workouts.Add(userName, workouts);
                }
            }

            public static List<Workout> GetWorkouts()
            {
                var userName = userDetails.CurrentProfile.UserName;
                if (_workouts.ContainsKey(userName))
                {
                    return (List<Workout>)_workouts[userName];
                }

                return new List<Workout>();
            }
        }
}
