
namespace FitnessTracker
{
    partial class CheatMealForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cheatMealHeaderLbl = new System.Windows.Forms.Label();
            this.cheatMealLbl = new System.Windows.Forms.Label();
            this.cheatMealDateLbl = new System.Windows.Forms.Label();
            this.cheatMealTxt = new System.Windows.Forms.TextBox();
            this.cheatMealDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cheatMealSaveBtn = new System.Windows.Forms.Button();
            this.cheatMealErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheatMealErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cheatMealSaveBtn);
            this.panel1.Controls.Add(this.cheatMealDatePicker);
            this.panel1.Controls.Add(this.cheatMealTxt);
            this.panel1.Controls.Add(this.cheatMealDateLbl);
            this.panel1.Controls.Add(this.cheatMealLbl);
            this.panel1.Controls.Add(this.cheatMealHeaderLbl);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 490);
            this.panel1.TabIndex = 0;
            // 
            // cheatMealHeaderLbl
            // 
            this.cheatMealHeaderLbl.AutoSize = true;
            this.cheatMealHeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatMealHeaderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.cheatMealHeaderLbl.Location = new System.Drawing.Point(91, 37);
            this.cheatMealHeaderLbl.Name = "cheatMealHeaderLbl";
            this.cheatMealHeaderLbl.Size = new System.Drawing.Size(209, 24);
            this.cheatMealHeaderLbl.TabIndex = 0;
            this.cheatMealHeaderLbl.Text = "Add Your Cheat Meal";
            // 
            // cheatMealLbl
            // 
            this.cheatMealLbl.AutoSize = true;
            this.cheatMealLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.cheatMealLbl.Location = new System.Drawing.Point(32, 112);
            this.cheatMealLbl.Name = "cheatMealLbl";
            this.cheatMealLbl.Size = new System.Drawing.Size(100, 20);
            this.cheatMealLbl.TabIndex = 1;
            this.cheatMealLbl.Text = "Cheat meal";
            // 
            // cheatMealDateLbl
            // 
            this.cheatMealDateLbl.AutoSize = true;
            this.cheatMealDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.cheatMealDateLbl.Location = new System.Drawing.Point(32, 172);
            this.cheatMealDateLbl.Name = "cheatMealDateLbl";
            this.cheatMealDateLbl.Size = new System.Drawing.Size(48, 20);
            this.cheatMealDateLbl.TabIndex = 2;
            this.cheatMealDateLbl.Text = "Date";
            // 
            // cheatMealTxt
            // 
            this.cheatMealTxt.Location = new System.Drawing.Point(151, 109);
            this.cheatMealTxt.Name = "cheatMealTxt";
            this.cheatMealTxt.Size = new System.Drawing.Size(200, 26);
            this.cheatMealTxt.TabIndex = 3;
            // 
            // cheatMealDatePicker
            // 
            this.cheatMealDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatMealDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatMealDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cheatMealDatePicker.Location = new System.Drawing.Point(151, 170);
            this.cheatMealDatePicker.Name = "cheatMealDatePicker";
            this.cheatMealDatePicker.Size = new System.Drawing.Size(200, 22);
            this.cheatMealDatePicker.TabIndex = 4;
            this.cheatMealDatePicker.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // cheatMealSaveBtn
            // 
            this.cheatMealSaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.cheatMealSaveBtn.Location = new System.Drawing.Point(151, 239);
            this.cheatMealSaveBtn.Name = "cheatMealSaveBtn";
            this.cheatMealSaveBtn.Size = new System.Drawing.Size(78, 31);
            this.cheatMealSaveBtn.TabIndex = 5;
            this.cheatMealSaveBtn.Text = "Save";
            this.cheatMealSaveBtn.UseVisualStyleBackColor = true;
            this.cheatMealSaveBtn.Click += new System.EventHandler(this.cheatMealSaveBtn_Click);
            // 
            // cheatMealErrorMessage
            // 
            this.cheatMealErrorMessage.ContainerControl = this;
            // 
            // CheatMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(395, 515);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CheatMealForm";
            this.Text = "Add Cheat Meals";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheatMealErrorMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cheatMealSaveBtn;
        private System.Windows.Forms.DateTimePicker cheatMealDatePicker;
        private System.Windows.Forms.TextBox cheatMealTxt;
        private System.Windows.Forms.Label cheatMealDateLbl;
        private System.Windows.Forms.Label cheatMealLbl;
        private System.Windows.Forms.Label cheatMealHeaderLbl;
        private System.Windows.Forms.ErrorProvider cheatMealErrorMessage;
    }
}