
namespace FitnessTracker
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.homeControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cheatMealsCountLbl = new System.Windows.Forms.Label();
            this.cheatMealsLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.workoutPnl = new System.Windows.Forms.Panel();
            this.workoutCountLbl = new System.Windows.Forms.Label();
            this.workoutLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.updateBtn = new System.Windows.Forms.Button();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.heightLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.lnameLbl = new System.Windows.Forms.Label();
            this.fnameLbl = new System.Windows.Forms.Label();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.addWorkoutBtn = new System.Windows.Forms.Button();
            this.addCheatMealBtn = new System.Windows.Forms.Button();
            this.homeControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.workoutPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.profileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeControl
            // 
            this.homeControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.homeControl.Controls.Add(this.homeTab);
            this.homeControl.Controls.Add(this.profileTab);
            this.homeControl.Controls.Add(this.reportTab);
            this.homeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeControl.Location = new System.Drawing.Point(23, 26);
            this.homeControl.Name = "homeControl";
            this.homeControl.SelectedIndex = 0;
            this.homeControl.Size = new System.Drawing.Size(766, 541);
            this.homeControl.TabIndex = 0;
            this.homeControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnTabChanged);
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.homeTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homeTab.Controls.Add(this.panel1);
            this.homeTab.Controls.Add(this.workoutPnl);
            this.homeTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.homeTab.Location = new System.Drawing.Point(4, 36);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(758, 501);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addCheatMealBtn);
            this.panel1.Controls.Add(this.cheatMealsCountLbl);
            this.panel1.Controls.Add(this.cheatMealsLbl);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(401, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 453);
            this.panel1.TabIndex = 1;
            // 
            // cheatMealsCountLbl
            // 
            this.cheatMealsCountLbl.AutoSize = true;
            this.cheatMealsCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatMealsCountLbl.Location = new System.Drawing.Point(160, 323);
            this.cheatMealsCountLbl.Name = "cheatMealsCountLbl";
            this.cheatMealsCountLbl.Size = new System.Drawing.Size(36, 37);
            this.cheatMealsCountLbl.TabIndex = 2;
            this.cheatMealsCountLbl.Text = "4";
            // 
            // cheatMealsLbl
            // 
            this.cheatMealsLbl.AutoSize = true;
            this.cheatMealsLbl.Location = new System.Drawing.Point(120, 17);
            this.cheatMealsLbl.Name = "cheatMealsLbl";
            this.cheatMealsLbl.Size = new System.Drawing.Size(119, 24);
            this.cheatMealsLbl.TabIndex = 1;
            this.cheatMealsLbl.Text = "CheatMeals";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // workoutPnl
            // 
            this.workoutPnl.Controls.Add(this.addWorkoutBtn);
            this.workoutPnl.Controls.Add(this.workoutCountLbl);
            this.workoutPnl.Controls.Add(this.workoutLbl);
            this.workoutPnl.Controls.Add(this.pictureBox1);
            this.workoutPnl.Location = new System.Drawing.Point(22, 22);
            this.workoutPnl.Name = "workoutPnl";
            this.workoutPnl.Size = new System.Drawing.Size(331, 453);
            this.workoutPnl.TabIndex = 0;
            // 
            // workoutCountLbl
            // 
            this.workoutCountLbl.AutoSize = true;
            this.workoutCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutCountLbl.Location = new System.Drawing.Point(140, 323);
            this.workoutCountLbl.Name = "workoutCountLbl";
            this.workoutCountLbl.Size = new System.Drawing.Size(36, 37);
            this.workoutCountLbl.TabIndex = 2;
            this.workoutCountLbl.Text = "4";
            // 
            // workoutLbl
            // 
            this.workoutLbl.AutoSize = true;
            this.workoutLbl.Location = new System.Drawing.Point(124, 17);
            this.workoutLbl.Name = "workoutLbl";
            this.workoutLbl.Size = new System.Drawing.Size(97, 24);
            this.workoutLbl.TabIndex = 1;
            this.workoutLbl.Text = "Workouts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // profileTab
            // 
            this.profileTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.profileTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profileTab.Controls.Add(this.updateBtn);
            this.profileTab.Controls.Add(this.heightTxt);
            this.profileTab.Controls.Add(this.weightTxt);
            this.profileTab.Controls.Add(this.ageTxt);
            this.profileTab.Controls.Add(this.usernameTxt);
            this.profileTab.Controls.Add(this.lnameTxt);
            this.profileTab.Controls.Add(this.fnameTxt);
            this.profileTab.Controls.Add(this.heightLbl);
            this.profileTab.Controls.Add(this.weightLbl);
            this.profileTab.Controls.Add(this.ageLbl);
            this.profileTab.Controls.Add(this.userNameLbl);
            this.profileTab.Controls.Add(this.lnameLbl);
            this.profileTab.Controls.Add(this.fnameLbl);
            this.profileTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.profileTab.Location = new System.Drawing.Point(4, 36);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(758, 501);
            this.profileTab.TabIndex = 1;
            this.profileTab.Text = "Profile";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(357, 437);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(157, 40);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(308, 369);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(249, 29);
            this.heightTxt.TabIndex = 11;
            // 
            // weightTxt
            // 
            this.weightTxt.Location = new System.Drawing.Point(308, 307);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(249, 29);
            this.weightTxt.TabIndex = 10;
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(308, 242);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(249, 29);
            this.ageTxt.TabIndex = 9;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(308, 175);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(249, 29);
            this.usernameTxt.TabIndex = 8;
            // 
            // lnameTxt
            // 
            this.lnameTxt.Location = new System.Drawing.Point(308, 114);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(249, 29);
            this.lnameTxt.TabIndex = 7;
            // 
            // fnameTxt
            // 
            this.fnameTxt.Location = new System.Drawing.Point(308, 57);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(249, 29);
            this.fnameTxt.TabIndex = 6;
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(112, 369);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(71, 24);
            this.heightLbl.TabIndex = 5;
            this.heightLbl.Text = "Height";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(112, 307);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(75, 24);
            this.weightLbl.TabIndex = 4;
            this.weightLbl.Text = "Weight";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(112, 242);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(48, 24);
            this.ageLbl.TabIndex = 3;
            this.ageLbl.Text = "Age";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(112, 175);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(114, 24);
            this.userNameLbl.TabIndex = 2;
            this.userNameLbl.Text = "User Name";
            // 
            // lnameLbl
            // 
            this.lnameLbl.AutoSize = true;
            this.lnameLbl.Location = new System.Drawing.Point(112, 114);
            this.lnameLbl.Name = "lnameLbl";
            this.lnameLbl.Size = new System.Drawing.Size(108, 24);
            this.lnameLbl.TabIndex = 1;
            this.lnameLbl.Text = "Last Name";
            // 
            // fnameLbl
            // 
            this.fnameLbl.AutoSize = true;
            this.fnameLbl.Location = new System.Drawing.Point(112, 57);
            this.fnameLbl.Name = "fnameLbl";
            this.fnameLbl.Size = new System.Drawing.Size(111, 24);
            this.fnameLbl.TabIndex = 0;
            this.fnameLbl.Text = "First Name";
            // 
            // reportTab
            // 
            this.reportTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.reportTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(35)))), ((int)(((byte)(5)))));
            this.reportTab.Location = new System.Drawing.Point(4, 36);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportTab.Size = new System.Drawing.Size(758, 501);
            this.reportTab.TabIndex = 2;
            this.reportTab.Text = "Reports";
            // 
            // addWorkoutBtn
            // 
            this.addWorkoutBtn.Location = new System.Drawing.Point(91, 376);
            this.addWorkoutBtn.Name = "addWorkoutBtn";
            this.addWorkoutBtn.Size = new System.Drawing.Size(140, 49);
            this.addWorkoutBtn.TabIndex = 3;
            this.addWorkoutBtn.Text = "Add Workout";
            this.addWorkoutBtn.UseVisualStyleBackColor = true;
            this.addWorkoutBtn.Click += new System.EventHandler(this.addWorkoutBtn_Click);
            // 
            // addCheatMealBtn
            // 
            this.addCheatMealBtn.Location = new System.Drawing.Point(85, 376);
            this.addCheatMealBtn.Name = "addCheatMealBtn";
            this.addCheatMealBtn.Size = new System.Drawing.Size(184, 49);
            this.addCheatMealBtn.TabIndex = 3;
            this.addCheatMealBtn.Text = "Add Cheat Meal";
            this.addCheatMealBtn.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(808, 595);
            this.Controls.Add(this.homeControl);
            this.Name = "home";
            this.Text = "Home";
            this.homeControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.workoutPnl.ResumeLayout(false);
            this.workoutPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl homeControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel workoutPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label cheatMealsCountLbl;
        private System.Windows.Forms.Label cheatMealsLbl;
        private System.Windows.Forms.Label workoutCountLbl;
        private System.Windows.Forms.Label workoutLbl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label lnameLbl;
        private System.Windows.Forms.Label fnameLbl;
        private System.Windows.Forms.Button addCheatMealBtn;
        private System.Windows.Forms.Button addWorkoutBtn;
    }
}