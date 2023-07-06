
namespace FitnessTracker.CustomComponents
{
    partial class DailyWorkoutComponent
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
            this.workoutTypeLbl = new System.Windows.Forms.Label();
            this.workoutFieldPannel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // workoutTypeLbl
            // 
            this.workoutTypeLbl.AutoSize = true;
            this.workoutTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutTypeLbl.Location = new System.Drawing.Point(18, 20);
            this.workoutTypeLbl.Name = "workoutTypeLbl";
            this.workoutTypeLbl.Size = new System.Drawing.Size(87, 24);
            this.workoutTypeLbl.TabIndex = 0;
            this.workoutTypeLbl.Text = "Workout";
            // 
            // workoutFieldPannel
            // 
            this.workoutFieldPannel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.workoutFieldPannel.Location = new System.Drawing.Point(21, 52);
            this.workoutFieldPannel.Name = "workoutFieldPannel";
            this.workoutFieldPannel.Size = new System.Drawing.Size(312, 94);
            this.workoutFieldPannel.TabIndex = 1;
            // 
            // DailyWorkoutComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.workoutFieldPannel);
            this.Controls.Add(this.workoutTypeLbl);
            this.Name = "DailyWorkoutComponent";
            this.Size = new System.Drawing.Size(364, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workoutTypeLbl;
        private System.Windows.Forms.Panel workoutFieldPannel;
    }
}
