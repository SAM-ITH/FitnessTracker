using FitnessTracker.Models;
using FitnessTracker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class CheatMealForm : Form
    {
        private CheatMealService _cheatMealService;

        public CheatMealForm()
        {
            InitializeComponent();
            _cheatMealService = new CheatMealService();
            cheatMealDatePicker.MaxDate = DateTime.Now;
            //cmbCheatMealTypes.Items.AddRange(EnumHelper.LoadItems<MealType>());
        }

        private void cheatMealSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                CreateCheatMeal();
                LoadDashboard();
            }
        }

        private void CreateCheatMeal()
        {
            //MealType cheatMealType = (MealType)cmbCheatMealTypes.SelectedItem;
            //double grams = double.Parse(txtAmount.Text);
            String cheatMealType = cheatMealTxt.Text;
            DateTime date = cheatMealDatePicker.Value;

            CheatMeal cheatMeal = new CheatMeal
            {
                MealType = cheatMealType,
                //Gram = grams,
                Created = date
            };

            _cheatMealService.CreateCheatMeal(cheatMeal);
        }

        private void LoadDashboard()
        {
            home Home = new home();
            Hide();
            Home.Activate();
            Home.ShowDialog();
        }

        //Field Validations
        /*
        private void cmbCheatMealTypes_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (string.IsNullOrEmpty(cmb.SelectedItem.ToString()))
            {
                e.Cancel = true;
                cmb.Focus();
                CheatMealErrorHandler.SetError(cmb, "Please select a meal type.");
            }
            else
            {
                e.Cancel = false;
                CheatMealErrorHandler.SetError(cmb, string.Empty);
            }
        }
        */

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                e.Cancel = true;
                txtBox.Focus();
                cheatMealErrorMessage.SetError(txtBox, "Please provide the meal type");
            }
            else
            {
                e.Cancel = false;
                cheatMealErrorMessage.SetError(txtBox, string.Empty);
            }
        }
    }
}
