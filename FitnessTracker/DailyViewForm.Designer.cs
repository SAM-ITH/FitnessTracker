
namespace FitnessTracker
{
    partial class DailyViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.daliViewHeaderLbl = new System.Windows.Forms.Label();
            this.detailsTab = new System.Windows.Forms.TabControl();
            this.WorkoutsTab = new System.Windows.Forms.TabPage();
            this.CheatMealsTab = new System.Windows.Forms.TabPage();
            this.detailsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // daliViewHeaderLbl
            // 
            this.daliViewHeaderLbl.AutoSize = true;
            this.daliViewHeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daliViewHeaderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.daliViewHeaderLbl.Location = new System.Drawing.Point(276, 39);
            this.daliViewHeaderLbl.Name = "daliViewHeaderLbl";
            this.daliViewHeaderLbl.Size = new System.Drawing.Size(148, 33);
            this.daliViewHeaderLbl.TabIndex = 0;
            this.daliViewHeaderLbl.Text = "Summary";
            // 
            // detailsTab
            // 
            this.detailsTab.Controls.Add(this.WorkoutsTab);
            this.detailsTab.Controls.Add(this.CheatMealsTab);
            this.detailsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTab.Location = new System.Drawing.Point(12, 85);
            this.detailsTab.Name = "detailsTab";
            this.detailsTab.SelectedIndex = 0;
            this.detailsTab.Size = new System.Drawing.Size(718, 365);
            this.detailsTab.TabIndex = 1;
            // 
            // WorkoutsTab
            // 
            this.WorkoutsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.WorkoutsTab.Location = new System.Drawing.Point(4, 29);
            this.WorkoutsTab.Name = "WorkoutsTab";
            this.WorkoutsTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorkoutsTab.Size = new System.Drawing.Size(710, 332);
            this.WorkoutsTab.TabIndex = 0;
            this.WorkoutsTab.Text = "Workouts";
            // 
            // CheatMealsTab
            // 
            this.CheatMealsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.CheatMealsTab.Location = new System.Drawing.Point(4, 29);
            this.CheatMealsTab.Name = "CheatMealsTab";
            this.CheatMealsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CheatMealsTab.Size = new System.Drawing.Size(710, 332);
            this.CheatMealsTab.TabIndex = 1;
            this.CheatMealsTab.Text = "Cheat Meals";
            // 
            // DailyViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(742, 462);
            this.Controls.Add(this.detailsTab);
            this.Controls.Add(this.daliViewHeaderLbl);
            this.Name = "DailyViewForm";
            this.Text = "DailyViewForm";
            this.detailsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daliViewHeaderLbl;
        private System.Windows.Forms.TabControl detailsTab;
        private System.Windows.Forms.TabPage WorkoutsTab;
        private System.Windows.Forms.TabPage CheatMealsTab;
    }
}