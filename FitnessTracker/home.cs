using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTracker.Context;
using System.Globalization;
using FitnessTracker.Services;

namespace FitnessTracker
{
    public partial class home : Form
    {
        private bool _isProfileLoaded;
        private WorkoutService _workoutService;
        private CheatMealService _cheatMealService;

        public home()
        {
            InitializeComponent();
            _workoutService = new WorkoutService();
            _cheatMealService = new CheatMealService();
            workoutCountLbl.Text = $"{_workoutService.GetWorkouts().Count}";
            cheatMealsCountLbl.Text = $"{_cheatMealService.GetCheatMeals().Count}";
        }

        private void OnTabChanged(object sender, TabControlEventArgs estop) 
        {
            var index = estop.TabPageIndex;
            if (estop.TabPage == profileTab) 
            {
                if (!_isProfileLoaded) 
                {
                    var profile = userDetails.CurrentProfile;
                    var user = profile.User;
                    fnameTxt.Text = user.FirstName;
                    lnameTxt.Text = user.LastName;
                    usernameTxt.Text = profile.UserName;
                    ageTxt.Text = user.Age.ToString(CultureInfo.InvariantCulture);
                    heightTxt.Text = user.Height.ToString(CultureInfo.InvariantCulture);
                    weightTxt.Text = user.Weight.ToString(CultureInfo.InvariantCulture);
                    _isProfileLoaded = true;
                }
            }
        }

        private void addWorkoutBtn_Click(object sender, EventArgs e)
        {
            WorkoutForm workoutform = new WorkoutForm();
            Hide();
            workoutform.Activate();
            workoutform.ShowDialog();
        }

        private void addCheatMealBtn_Click(object sender, EventArgs e)
        {
            CheatMealForm cheatMealForm = new CheatMealForm();
            Hide();
            cheatMealForm.Activate();
            cheatMealForm.ShowDialog();
        }
    }
}
