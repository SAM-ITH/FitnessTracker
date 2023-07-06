
namespace FitnessTracker.CustomComponents
{
    partial class DailyComponent
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dailyCompMessageLbl = new System.Windows.Forms.Label();
            this.viewMoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblDate.Location = new System.Drawing.Point(13, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "July 4";
            // 
            // dailyCompMessageLbl
            // 
            this.dailyCompMessageLbl.AutoSize = true;
            this.dailyCompMessageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyCompMessageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(41)))));
            this.dailyCompMessageLbl.Location = new System.Drawing.Point(74, 20);
            this.dailyCompMessageLbl.Name = "dailyCompMessageLbl";
            this.dailyCompMessageLbl.Size = new System.Drawing.Size(73, 20);
            this.dailyCompMessageLbl.TabIndex = 1;
            this.dailyCompMessageLbl.Text = "Content";
            // 
            // viewMoreBtn
            // 
            this.viewMoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.viewMoreBtn.Location = new System.Drawing.Point(212, 20);
            this.viewMoreBtn.Name = "viewMoreBtn";
            this.viewMoreBtn.Size = new System.Drawing.Size(105, 28);
            this.viewMoreBtn.TabIndex = 2;
            this.viewMoreBtn.Text = "Dilay View";
            this.viewMoreBtn.UseVisualStyleBackColor = true;
            this.viewMoreBtn.Click += new System.EventHandler(this.viewMoreBtn_Click);
            // 
            // DailyComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.viewMoreBtn);
            this.Controls.Add(this.dailyCompMessageLbl);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DailyComponent";
            this.Size = new System.Drawing.Size(337, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label dailyCompMessageLbl;
        private System.Windows.Forms.Button viewMoreBtn;
    }
}
