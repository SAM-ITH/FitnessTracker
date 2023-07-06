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

namespace FitnessTracker.CustomComponents
{
    public partial class DailyWorkoutComponent : UserControl
    {
        private Workout _workout;

        public DailyWorkoutComponent()
        {
            InitializeComponent();
        }

        public DailyWorkoutComponent(Workout workout)
        {
            InitializeComponent();
            _workout = workout;
            LoadWorkout();
        }

        private void LoadWorkout()
        {
            // load workout type.
            workoutTypeLbl.Text = _workout.Exercise.ToString();
            var detailHelper = new DetailUtil(_workout);
            // load workout fields.
            int panelHeight = 0;
            int index = 0;
            foreach (var field in _workout.Fields)
            {
                var formattedValue = detailHelper.GetFieldValueForText(field.Key, field.Value);
                var fieldPanel = new ContentComponent(field.Key, formattedValue, workoutTypeLbl.ForeColor);
                if (index == 0)
                {
                    panelHeight = 0;
                }
                else
                {
                    panelHeight += fieldPanel.Height;
                }

                fieldPanel.Location = new Point(0, panelHeight);
                workoutFieldPannel.Controls.Add(fieldPanel);
                index++;
            }
        }
    }
}
