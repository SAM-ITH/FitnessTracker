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
    public partial class ContentComponent : UserControl
    {
        private string _key;
        private string _value;
        private Color _txtColor;

        public ContentComponent()
        {
            InitializeComponent();
        }

        public ContentComponent(string key, string value, Color txtColor)
        {
            InitializeComponent();
            _key = key;
            _value = value;
            _txtColor = txtColor;
            LoadControl();
        }

        private void LoadControl()
        {
            fieldLbl.Text = _key;
            fieldLbl.ForeColor = _txtColor;

            valueLbl.Text = _value;
            valueLbl.ForeColor = _txtColor;
        }
    }
}
