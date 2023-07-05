using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTracker.Services;
using FitnessTracker.Context;
using FitnessTracker.Extentions;
using FitnessTracker.Utils;
using FitnessTracker.Models;
using FitnessTracker.Models.Enums;


namespace FitnessTracker
{
    public partial class WorkoutForm : Form
    {
        private WorkoutService _workoutService;

        public WorkoutForm()
        {
            InitializeComponent();
            LoadWorkoutTypes();
            _workoutService = new WorkoutService();
        }

        private void LoadWorkoutTypes()
        {
            workoutTypesCombo.Items.Add(string.Empty);
            workoutTypesCombo.Items.AddRange(EnumUtil.LoadItems<WorkoutTypes>());
        }

        private void workoutTypesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = workoutTypesCombo.SelectedItem;
            if (!string.IsNullOrEmpty(item.ToString()))
            {
                WorkoutTypes workoutType = (WorkoutTypes)item;
                workoutControlPnl.Controls.Clear();
                workoutControlPnl.Controls.AddRange(FormControlUtil.GetExerciseTypeControls(workoutType));
                AppendValidationForTextBoxes();
                // resize the panel (extension method)
                workoutControlPnl.ResizePanel(5);
                workoutControlPnl.Show();

                // bring the date panel closer to workout panel (extension method).
                workoutDatePnl.BringCloserTo(workoutControlPnl, 10);
                workoutDatePnl.Show();
            }
            else
            {
                workoutControlPnl.Controls.Clear();
                workoutControlPnl.Hide();
                workoutDatePnl.Hide();
            }
        }

        private void CreateWorkout()
        {
            WorkoutTypes exercise = (WorkoutTypes)workoutTypesCombo.SelectedItem;
            DateTime workoutDate = workoutDatePicker.Value;
            Workout workout = new Workout
            {
                Exercise = exercise,
                User = userDetails.CurrentProfile.User,
                Created = workoutDate
            };

            GetAdditionalFieldData(workout);
            _workoutService.CreateWorkout(workout);
        }

        private void GetAdditionalFieldData(Workout workout)
        {
            var fields = new Dictionary<string, double>();
            switch (workout.Exercise)
            {
                case WorkoutTypes.walking:
                case WorkoutTypes.running:
                case WorkoutTypes.cycling:
                    CreateDistanceFields(fields);
                    break;
                case WorkoutTypes.plank:
                    CreateTimeFields(fields);
                    break;
                case WorkoutTypes.benchpress:
                case WorkoutTypes.shoulderpress:
                    CreateCompositeControls(fields);
                    break;
                case WorkoutTypes.pushups:
                case WorkoutTypes.crunches:
                case WorkoutTypes.squats:
                case WorkoutTypes.lunges:
                    CreateRepControls(fields);
                    break;
            }
        }

        #region Creating Fields
        private void CreateDistanceFields(Dictionary<string, double> fields)
        {
            var controls = workoutControlPnl.Controls.Find("txtDistance", false).First();
            if (controls is TextBox txtBox)
            {
                fields.Add("Distance", double.Parse(txtBox.Text));
            }
        }

        private void CreateTimeFields(Dictionary<string, double> fields)
        {
            var controls = workoutControlPnl.Controls.Find("txtTime", false).First();
            if (controls is TextBox txtBox)
            {
                fields.Add("Time", double.Parse(txtBox.Text));
            }
        }
        private void CreateCompositeControls(Dictionary<string, double> fields)
        {
            var weightControl = workoutControlPnl.Controls.Find("txtWeight", false).First();
            if (weightControl is TextBox txtBox)
            {
                fields.Add("Weight", double.Parse(txtBox.Text));
            }

            CreateRepControls(fields);
        }
        private void CreateRepControls(Dictionary<string, double> fields)
        {
            var repsControl = workoutControlPnl.Controls.Find("txtReps", false).First();
            if (repsControl is TextBox txtBox)
            {
                fields.Add("Reps", double.Parse(txtBox.Text));
            }
        }
        #endregion

        #region Workout TextBox Validation

        private void AppendValidationForTextBoxes()
        {
            /*foreach (Control control in pnlWorkoutControls.Controls)
            {
              if (control.GetType() == typeof(TextBox))
              {
                control.Validating += WorkoutText_Validate;
              }
            }*/
        }

        private bool ValidateAdditionalFields()
        {
            foreach (Control control in workoutControlPnl.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = control as TextBox;
                    int number;
                    if (string.IsNullOrWhiteSpace(txtBox.Text))
                    {
                        workoutErrorMessage.SetError(txtBox, $"{txtBox.Tag} can not be empty.");
                        return false;
                    }
                    if (!int.TryParse(txtBox.Text, out number))
                    {
                        workoutErrorMessage.SetError(txtBox, $"{txtBox.Tag} can not be empty.");
                        return false;
                    }
                    if (number < 0)
                    {
                        workoutErrorMessage.SetError(txtBox, $"{txtBox.Tag} can not be empty.");
                        return false;
                    }
                    else
                    {
                        workoutErrorMessage.SetError(txtBox, string.Empty);
                    }
                }
            }

            return true;
        }

        private void WorkoutText_Validate(object sender, CancelEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            int number;
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                e.Cancel = true;
                //txtBox.Focus();
                workoutErrorMessage.SetError(txtBox, $"{txtBox.Tag} can not be empty.");
            }
            else if (!int.TryParse(txtBox.Text, out number))
            {
                e.Cancel = true;
                //txtBox.Focus();
                workoutErrorMessage.SetError(txtBox, $"{txtBox.Tag} can not be empty.");
            }
            else if (number < 0)
            {
                e.Cancel = true;
                //txtBox.Focus();
                workoutErrorMessage.SetError(txtBox, $"{txtBox.Tag} should be a positive number.");
            }
            else
            {
                e.Cancel = false;
                workoutErrorMessage.SetError(txtBox, string.Empty);
            }
        }
        #endregion

        private void WorkoutTypes_Validated(object sender, CancelEventArgs e)
        {
            var item = workoutTypesCombo.SelectedItem;
            if (string.IsNullOrEmpty(item.ToString()))
            {
                e.Cancel = true;
                workoutErrorMessage.SetError(workoutTypesCombo, "Please select a workout type.");
            }
            else
            {
                e.Cancel = false;
                workoutErrorMessage.SetError(workoutTypesCombo, string.Empty);
            }
        }

        private void workoutSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && ValidateAdditionalFields())
            {
                CreateWorkout();
                home Home = new home();
                Hide();
                Home.Activate();
                Home.ShowDialog();
            }
        }
    }
}
