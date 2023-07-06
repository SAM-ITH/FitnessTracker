
namespace FitnessTracker.CustomComponents
{
    partial class ContentComponent
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
            this.fieldLbl = new System.Windows.Forms.Label();
            this.valueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fieldLbl
            // 
            this.fieldLbl.AutoSize = true;
            this.fieldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.fieldLbl.Location = new System.Drawing.Point(3, 0);
            this.fieldLbl.Name = "fieldLbl";
            this.fieldLbl.Size = new System.Drawing.Size(57, 20);
            this.fieldLbl.TabIndex = 0;
            this.fieldLbl.Text = "label1";
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLbl.Location = new System.Drawing.Point(260, 4);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(55, 20);
            this.valueLbl.TabIndex = 1;
            this.valueLbl.Text = "Value";
            // 
            // ContentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.fieldLbl);
            this.Name = "ContentComponent";
            this.Size = new System.Drawing.Size(340, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fieldLbl;
        private System.Windows.Forms.Label valueLbl;
    }
}
