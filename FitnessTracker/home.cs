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

namespace FitnessTracker
{
    public partial class home : Form
    {
        private bool _isProfileLoaded;
        public home()
        {
            InitializeComponent();
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
    }
}
