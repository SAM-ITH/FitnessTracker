using FitnessTracker.Models;
using FitnessTracker.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTracker.CustomComponents;

namespace FitnessTracker.CustomComponents
{
    public partial class DailyComponent : UserControl
    {
        private DailyDetail _dailyDetail;

        public DailyComponent()
        {
            InitializeComponent();
        }

        public DailyComponent(DailyDetail dailyDetail)
        {
            InitializeComponent();
            _dailyDetail = dailyDetail;
            InitializeViewMoreButtonState();
            LoadDetail();
        }

        private void InitializeViewMoreButtonState()
        {
            if (!IsContentAvailable())
            {
                viewMoreBtn.Visible = false;
            }
        }

        private void LoadDetail()
        {
            lblDate.Text = DateUtil.GetMonthAndDate(_dailyDetail.Created);

            if (!IsContentAvailable())
            {
                dailyCompMessageLbl.Text = "No workouts/cheatmeals";
            }
            else
            {
                // display the message
                int workoutCount = _dailyDetail.Workouts.Count;
                int cheatMealCount = _dailyDetail.CheatMeals.Count;
                dailyCompMessageLbl.Text = $"{workoutCount} Workouts/{cheatMealCount} CheatMeals";
            }
        }

        private void viewMoreBtn_Click(object sender, EventArgs e)
        {
            DailyViewForm dailyDetailForm = new DailyViewForm(_dailyDetail);
            dailyDetailForm.Activate();
            dailyDetailForm.ShowDialog();
        }

        private bool IsContentAvailable()
        {
            var workouts = _dailyDetail.Workouts;
            var cheatMeals = _dailyDetail.CheatMeals;
            return (workouts.Any() || cheatMeals.Any());
        }

       
    }
}
