using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker.Extentions
{
    public static class FormsControlExtensions
    {
        public static void ResizePanel(this Panel panel, int marginBottom)
        {
            int maxDepth = int.MinValue;
            foreach (Control control in panel.Controls)
            {
                maxDepth = Math.Max(control.Location.Y, maxDepth);
            }
            // resize
            panel.Height = maxDepth + marginBottom;
        }

        public static void BringCloserTo(this Panel panel, Panel destinationPanel, int margin)
        {
            int panelLocY = panel.Location.Y;
            int destinationDepth = destinationPanel.Location.Y + destinationPanel.Size.Height;
            int xLoc = panel.Location.X;
            int yLoc = destinationDepth + margin;
            panel.Location = new Point(xLoc, yLoc);
        }

        public static void AddValidationForTextBoxes(this Panel panel)
        {
            if (panel.Controls.ContainsControl<TextBox>())
            {

            }
        }

        public static bool ContainsControl<T>(this Control.ControlCollection controls) where T : Control
        {
            foreach (Control control in controls)
            {
                if (control.GetType() == typeof(T))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
