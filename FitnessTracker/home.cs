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
using FitnessTracker.Utils;
using FitnessTracker.Models;
using FitnessTracker.CustomComponents;

namespace FitnessTracker
{
    public partial class home : Form
    {
        private bool _isProfileLoaded;
        private WorkoutService _workoutService;
        private CheatMealService _cheatMealService;
        private WeeklyViewService _weeklyViewService;

        public home()
        {
            InitializeComponent();
            _workoutService = new WorkoutService();
            _cheatMealService = new CheatMealService();
            _weeklyViewService = new WeeklyViewService();
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
            else if (estop.TabPage == reportTab)
            {
                navPnlWeekLbl.Text = DateUtil.CreateWeekText(DateTime.Today);
                navPnlWeekLbl.Tag = DateTime.Today;
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

        private void leftArrowPic_Click(object sender, EventArgs e)
        {
            if (!rightArrowPic.Visible)
            {
                rightArrowPic.Visible = true;
            }
            else
            {
                var lblDate = (DateTime)navPnlWeekLbl.Tag;
                var prevWeekDay = lblDate.AddDays(-7);
                navPnlWeekLbl.Text = DateUtil.CreateWeekText(prevWeekDay);
                navPnlWeekLbl.Tag = prevWeekDay;
                LoadWeeklyDetails(prevWeekDay);
            }
        }

        private void rightArrowPic_Click(object sender, EventArgs e)
        {
            var lblDate = (DateTime)navPnlWeekLbl.Tag;
            var nextWeekDay = lblDate.AddDays(7);
            if (nextWeekDay > DateTime.Today)
            {
                rightArrowPic.Visible = false;
            }
            else
            {
                navPnlWeekLbl.Text = DateUtil.CreateWeekText(nextWeekDay);
                navPnlWeekLbl.Tag = nextWeekDay;
                LoadWeeklyDetails(nextWeekDay);
            }
        }

        private bool IsWeeklyDetailsAvailable(DateTime date)
        {
            return _weeklyViewService.WeeklyDetailsAvailable(date);
        }

        private void LoadWeeklyDetails(DateTime date)
        {
            dailyListPnl.Controls.Clear();
            if (!IsWeeklyDetailsAvailable(date))
            {
                weelyViewPnlHeaderLbl.Visible = true;
            }
            else
            {
                weelyViewPnlHeaderLbl.Visible = false;
                var weeklyDetails = _weeklyViewService.GetWeeklyDetails(date);
                AddWeeklyViewPanel(weeklyDetails);
            }
        }

        private void AddWeeklyViewPanel(List<DailyDetail> data)
        {
            int panelHeight = 0;
            int index = 0;
            foreach (var dailyDetail in data)
            {
                var dailyPanel = new DailyComponent(dailyDetail);
                if (index == 0)
                {
                    panelHeight = 0;
                }
                else
                {
                    panelHeight += dailyPanel.Height;
                }
                dailyPanel.Location = new Point(0, panelHeight);
                dailyListPnl.Controls.Add(dailyPanel);
                index++;
            }
        }
    }
}
