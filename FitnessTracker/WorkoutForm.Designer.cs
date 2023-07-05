
namespace FitnessTracker
{
    partial class WorkoutForm
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
            this.workoutSaveBtn = new System.Windows.Forms.Button();
            this.workoutDatePnl = new System.Windows.Forms.Panel();
            this.workoutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.workoutDateLbl = new System.Windows.Forms.Label();
            this.workoutControlPnl = new System.Windows.Forms.Panel();
            this.workoutTypesCombo = new System.Windows.Forms.ComboBox();
            this.workoutLbl = new System.Windows.Forms.Label();
            this.workoutErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.workoutDatePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.workoutSaveBtn);
            this.panel1.Controls.Add(this.workoutDatePnl);
            this.panel1.Controls.Add(this.workoutControlPnl);
            this.panel1.Controls.Add(this.workoutTypesCombo);
            this.panel1.Controls.Add(this.workoutLbl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 511);
            this.panel1.TabIndex = 0;
            // 
            // workoutSaveBtn
            // 
            this.workoutSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutSaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.workoutSaveBtn.Location = new System.Drawing.Point(198, 328);
            this.workoutSaveBtn.Name = "workoutSaveBtn";
            this.workoutSaveBtn.Size = new System.Drawing.Size(91, 29);
            this.workoutSaveBtn.TabIndex = 4;
            this.workoutSaveBtn.Text = "Save";
            this.workoutSaveBtn.UseVisualStyleBackColor = true;
            this.workoutSaveBtn.Click += new System.EventHandler(this.workoutSaveBtn_Click);
            // 
            // workoutDatePnl
            // 
            this.workoutDatePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.workoutDatePnl.Controls.Add(this.workoutDatePicker);
            this.workoutDatePnl.Controls.Add(this.workoutDateLbl);
            this.workoutDatePnl.Location = new System.Drawing.Point(2, 256);
            this.workoutDatePnl.Margin = new System.Windows.Forms.Padding(2);
            this.workoutDatePnl.Name = "workoutDatePnl";
            this.workoutDatePnl.Size = new System.Drawing.Size(347, 29);
            this.workoutDatePnl.TabIndex = 3;
            this.workoutDatePnl.Visible = false;
            // 
            // workoutDatePicker
            // 
            this.workoutDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.workoutDatePicker.Location = new System.Drawing.Point(216, 6);
            this.workoutDatePicker.Name = "workoutDatePicker";
            this.workoutDatePicker.Size = new System.Drawing.Size(125, 20);
            this.workoutDatePicker.TabIndex = 6;
            this.workoutDatePicker.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // workoutDateLbl
            // 
            this.workoutDateLbl.AutoSize = true;
            this.workoutDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.workoutDateLbl.Location = new System.Drawing.Point(23, 6);
            this.workoutDateLbl.Name = "workoutDateLbl";
            this.workoutDateLbl.Size = new System.Drawing.Size(48, 20);
            this.workoutDateLbl.TabIndex = 0;
            this.workoutDateLbl.Text = "Date";
            // 
            // workoutControlPnl
            // 
            this.workoutControlPnl.AutoSize = true;
            this.workoutControlPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.workoutControlPnl.Location = new System.Drawing.Point(2, 148);
            this.workoutControlPnl.Margin = new System.Windows.Forms.Padding(2);
            this.workoutControlPnl.Name = "workoutControlPnl";
            this.workoutControlPnl.Size = new System.Drawing.Size(341, 103);
            this.workoutControlPnl.TabIndex = 2;
            // 
            // workoutTypesCombo
            // 
            this.workoutTypesCombo.FormattingEnabled = true;
            this.workoutTypesCombo.Location = new System.Drawing.Point(200, 99);
            this.workoutTypesCombo.Name = "workoutTypesCombo";
            this.workoutTypesCombo.Size = new System.Drawing.Size(121, 21);
            this.workoutTypesCombo.TabIndex = 1;
            this.workoutTypesCombo.SelectedIndexChanged += new System.EventHandler(this.workoutTypesCombo_SelectedIndexChanged);
            // 
            // workoutLbl
            // 
            this.workoutLbl.AutoSize = true;
            this.workoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.workoutLbl.Location = new System.Drawing.Point(22, 100);
            this.workoutLbl.Name = "workoutLbl";
            this.workoutLbl.Size = new System.Drawing.Size(119, 20);
            this.workoutLbl.TabIndex = 0;
            this.workoutLbl.Text = "Workout Type";
            // 
            // workoutErrorMessage
            // 
            this.workoutErrorMessage.ContainerControl = this;
            // 
            // WorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(395, 515);
            this.Controls.Add(this.panel1);
            this.Name = "WorkoutForm";
            this.Text = "WorkoutForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.workoutDatePnl.ResumeLayout(false);
            this.workoutDatePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutErrorMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button workoutSaveBtn;
        private System.Windows.Forms.Panel workoutDatePnl;
        private System.Windows.Forms.DateTimePicker workoutDatePicker;
        private System.Windows.Forms.Label workoutDateLbl;
        private System.Windows.Forms.Panel workoutControlPnl;
        private System.Windows.Forms.ComboBox workoutTypesCombo;
        private System.Windows.Forms.Label workoutLbl;
        private System.Windows.Forms.ErrorProvider workoutErrorMessage;
    }
}