using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class UserProfile
    {
        public int ProfileId { get; set; }

        public User User { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

    }
}
