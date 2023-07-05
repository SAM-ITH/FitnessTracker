using FitnessTracker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
        public class Workout : GeneralDetails
        {
            public WorkoutTypes Exercise { get; set; }

            public User User { get; set; }

            public Dictionary<string, double> Fields { get; set; }
        }
}
