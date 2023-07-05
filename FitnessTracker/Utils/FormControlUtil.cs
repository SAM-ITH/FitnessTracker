using FitnessTracker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace FitnessTracker.Utils
{
    public static class FormControlUtil
    {
        public static Control[] GetExerciseTypeControls(WorkoutTypes workoutType)
        {
            Control[] controls = null;

            switch (workoutType)
            {
                case WorkoutTypes.walking:
                case WorkoutTypes.running:
                case WorkoutTypes.cycling:
                    controls = CreateDistanceControls();
                    break;
                case WorkoutTypes.plank:
                    controls = CreateTimeControls();
                    break;
                case WorkoutTypes.benchpress:
                case WorkoutTypes.shoulderpress:
                    controls = CreateCompositeControls();
                    break;
                case WorkoutTypes.pushups:
                case WorkoutTypes.crunches:
                case WorkoutTypes.squats:
                case WorkoutTypes.lunges:
                    controls = CreateRepControls(0);
                    break;
            }

            return controls;
        }

        private static Control[] CreateCompositeControls()
        {
            // create weight label.
            Label weightLabel = new Label();
            weightLabel.Location = new Point(24, 0);
            weightLabel.Text = "Weight (kg)".ToString(CultureInfo.InvariantCulture);
            weightLabel.ForeColor = Color.Brown;
            weightLabel.Font = new Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightLabel.Name = "lblWeight";

            // create weight textBox
            TextBox weightTextBox = new TextBox();
            weightTextBox.Font = new Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightTextBox.Location = new Point(200, 0);
            weightTextBox.Size = new Size(139, 30);
            weightTextBox.Name = "txtWeight";
            weightTextBox.Tag = "Weight";

            Control[] repControls = CreateRepControls(50);

            return new Control[] { weightLabel, weightTextBox, repControls[0], repControls[1] };
        }

        private static Control[] CreateRepControls(int yAxis)
        {
            // create reps label.
            Label repsLabel = new Label();
            repsLabel.Location = new Point(24, yAxis);
            repsLabel.Text = "Reps".ToString(CultureInfo.InvariantCulture);
            repsLabel.ForeColor = Color.Brown;
            repsLabel.Font = new Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            repsLabel.Name = "lblReps";

            // create reps textBox
            TextBox repsTextBox = new TextBox();
            repsTextBox.Font = new Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            repsTextBox.Location = new Point(200, yAxis);
            repsTextBox.Size = new Size(139, 30);
            repsTextBox.Name = "txtReps";
            repsTextBox.Tag = "Rep Count";

            return new Control[] { repsLabel, repsTextBox };
        }

        private static Control[] CreateDistanceControls()
        {
            // create label.
            Label label = new Label();
            label.Location = new Point(24, 0);
            label.Text = "Distance (km)".ToString(CultureInfo.InvariantCulture);
            label.ForeColor = Color.Brown;
            label.Font = new Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Name = "lblDistance";

            // create textBox
            TextBox textBox = new TextBox();
            textBox.Font = new Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.Location = new Point(200, 0);
            textBox.Size = new Size(139, 30);
            textBox.Name = "txtDistance";
            textBox.Tag = "Distance";

            return new Control[] { label, textBox };
        }

        private static Control[] CreateTimeControls()
        {
            // create label.
            Label label = new Label();
            label.Location = new Point(24, 0);
            label.Text = "Time (minutes)".ToString(CultureInfo.InvariantCulture);
            label.ForeColor = Color.Brown;
            label.Font = new Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Name = "lblTime";

            // create textBox
            TextBox textBox = new TextBox();
            textBox.Font = new Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.Location = new Point(200, 0);
            textBox.Size = new Size(139, 30);
            textBox.Name = "txtTime";
            textBox.Tag = "Time";

            return new Control[] { label, textBox };
        }
    }
}
