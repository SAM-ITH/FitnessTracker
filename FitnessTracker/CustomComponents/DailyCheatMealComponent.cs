using FitnessTracker.Models;
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
    public partial class DailyCheatMealComponent : UserControl
    {
        private CheatMeal _cheatMeal;
        public DailyCheatMealComponent()
        {
            InitializeComponent();
        }

        public DailyCheatMealComponent(CheatMeal cheatMeal)
        {
            InitializeComponent();
            _cheatMeal = cheatMeal;
            LoadCheatMeal();
        }

        private void LoadCheatMeal()
        {
           
            mealLbl.Text = _cheatMeal.MealType.ToString();
            
        }
    }
}
