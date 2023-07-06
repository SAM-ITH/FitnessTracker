
namespace FitnessTracker.CustomComponents
{
    partial class DailyCheatMealComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mealTypeLbl = new System.Windows.Forms.Label();
            this.mealLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mealTypeLbl
            // 
            this.mealTypeLbl.AutoSize = true;
            this.mealTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealTypeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.mealTypeLbl.Location = new System.Drawing.Point(74, 45);
            this.mealTypeLbl.Name = "mealTypeLbl";
            this.mealTypeLbl.Size = new System.Drawing.Size(63, 25);
            this.mealTypeLbl.TabIndex = 0;
            this.mealTypeLbl.Text = "Meal";
            // 
            // mealLbl
            // 
            this.mealLbl.AutoSize = true;
            this.mealLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.mealLbl.Location = new System.Drawing.Point(264, 45);
            this.mealLbl.Name = "mealLbl";
            this.mealLbl.Size = new System.Drawing.Size(127, 25);
            this.mealLbl.TabIndex = 1;
            this.mealLbl.Text = "Meal name";
            // 
            // DailyCheatMealComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.mealLbl);
            this.Controls.Add(this.mealTypeLbl);
            this.Name = "DailyCheatMealComponent";
            this.Size = new System.Drawing.Size(436, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealTypeLbl;
        private System.Windows.Forms.Label mealLbl;
    }
}
