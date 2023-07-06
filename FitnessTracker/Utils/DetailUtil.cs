using FitnessTracker.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker.Utils
{
    public class DetailUtil
    {
        private GeneralDetails _detail;
        private Size _parentSize;

        public GeneralDetails Detail
        {
            get
            {
                return _detail;
            }
        }

        public DetailUtil(GeneralDetails detail)
        {
            _detail = detail;
        }

        public DetailUtil(GeneralDetails detail, Size size)
        {
            _detail = detail;
            _parentSize = size;
        }

        public string GetHeader()
        {
            string header = string.Empty;
            if (_detail.GetType() == typeof(Workout))
            {
                var workout = (Workout)_detail;
                header = workout.Exercise.ToString();
            }
            else if (_detail.GetType() == typeof(CheatMeal))
            {
                var cheatMeal = (CheatMeal)_detail;
                header = cheatMeal.MealType.ToString();
            }

            return header;
        }

        public Panel GetFields()
        {
            Panel panel = new Panel();
            panel.Location = new Point(0, 0);
            //panel.BackColor = Color.Blue;
            panel.Size = new Size(_parentSize.Width, _parentSize.Height);
            if (_detail.GetType() == typeof(Workout))
            {
                CreateWorkoutFields(panel);
            }
            else if (_detail.GetType() == typeof(CheatMeal))
            {
                CreateCheatMealFields(panel);
            }

            return panel;
        }

        private void CreateCheatMealFields(Panel panel)
        {
            CheatMeal cheatMeal = (CheatMeal)_detail;
            // key label
            //CreateFieldValues(panel, 0, "Amount (in grams)", cheatMeal.MealAmount);
        }

        private void CreateWorkoutFields(Panel panel)
        {
            Workout workout = (Workout)_detail;
            int index = 0;
            foreach (var fieldsKey in workout.Fields.Keys)
            {
                var keyPair = workout.Fields[fieldsKey];
                CreateFieldValues(panel, index, fieldsKey, workout.Fields[fieldsKey]);
                index++;
            }
        }

        private void CreateFieldValues(Panel panel, int margin, string key, double value)
        {
            int y = 45 * margin;
            Label keyLabel = new Label();
            keyLabel.Text = key;
            keyLabel.Location = new Point(5, y);
            keyLabel.Font = new Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            keyLabel.ForeColor = Color.Black;

            Label valueLabel = new Label();
            valueLabel.Text = GetFieldValueForText(key, value).ToString(CultureInfo.InvariantCulture);
            valueLabel.Font = new Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold,
              System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valueLabel.ForeColor = Color.Black;
            // positioning the value label correctly.
            int gap = _parentSize.Width - (keyLabel.Width + valueLabel.Width);
            int valueX = keyLabel.Width + gap;
            valueLabel.Location = new Point(valueX, y);

            panel.Controls.Add(keyLabel);
            panel.Controls.Add(valueLabel);
        }

        public string GetFieldValueForText(string key, double value)
        {
            string valueText = string.Empty;
            if (_detail.GetType() == typeof(Workout))
            {
                var workout = (Workout)_detail;
                switch (key)
                {
                    case "Weight":
                        valueText = $"{value} kg";
                        break;
                    case "Distance":
                        valueText = $"{value} km";
                        break;
                    case "Time":
                        valueText = $"{value} min";
                        break;
                    case "Reps":
                        valueText = $"{value}";
                        break;
                }
            }
            else if (_detail.GetType() == typeof(CheatMeal))
            {
                valueText = $"{value} g";
            }

            return valueText;
        }
    }
}
