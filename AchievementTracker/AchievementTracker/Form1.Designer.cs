namespace AchievementTracker
{
    partial class AchievementTrackerApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clbRegisteredGoal = new CheckedListBox();
            lblAppTitle = new Label();
            lblCelFelvetele = new Label();
            tbGoal = new TextBox();
            lblGoal = new Label();
            lblPoint = new Label();
            btnAddGoal = new Button();
            lblYourPoints = new Label();
            lblNeedingPoint = new Label();
            pbAchieveLevel = new ProgressBar();
            lbAchievements = new ListBox();
            NUDPoint = new NumericUpDown();
            tbDescription = new TextBox();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)NUDPoint).BeginInit();
            SuspendLayout();
            // 
            // clbRegisteredGoal
            // 
            clbRegisteredGoal.FormattingEnabled = true;
            clbRegisteredGoal.Location = new Point(26, 306);
            clbRegisteredGoal.Name = "clbRegisteredGoal";
            clbRegisteredGoal.Size = new Size(245, 356);
            clbRegisteredGoal.TabIndex = 0;
            clbRegisteredGoal.SelectedIndexChanged += clbRegisteredGoal_SelectedIndexChanged;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Location = new Point(291, 9);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(146, 20);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Achievement Tracker";
            // 
            // lblCelFelvetele
            // 
            lblCelFelvetele.AutoSize = true;
            lblCelFelvetele.Location = new Point(69, 57);
            lblCelFelvetele.Name = "lblCelFelvetele";
            lblCelFelvetele.Size = new Size(130, 20);
            lblCelFelvetele.TabIndex = 2;
            lblCelFelvetele.Text = "Register your goal";
            // 
            // tbGoal
            // 
            tbGoal.Location = new Point(26, 89);
            tbGoal.Name = "tbGoal";
            tbGoal.Size = new Size(125, 27);
            tbGoal.TabIndex = 3;
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Location = new Point(176, 92);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(40, 20);
            lblGoal.TabIndex = 5;
            lblGoal.Text = "Goal";
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Location = new Point(176, 140);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(46, 20);
            lblPoint.TabIndex = 6;
            lblPoint.Text = "Point ";
            // 
            // btnAddGoal
            // 
            btnAddGoal.Location = new Point(85, 256);
            btnAddGoal.Name = "btnAddGoal";
            btnAddGoal.Size = new Size(94, 29);
            btnAddGoal.TabIndex = 7;
            btnAddGoal.Text = "Add Goal";
            btnAddGoal.UseVisualStyleBackColor = true;
            btnAddGoal.Click += btnAddGoal_Click;
            // 
            // lblYourPoints
            // 
            lblYourPoints.AutoSize = true;
            lblYourPoints.Location = new Point(404, 57);
            lblYourPoints.Name = "lblYourPoints";
            lblYourPoints.Size = new Size(88, 20);
            lblYourPoints.TabIndex = 8;
            lblYourPoints.Text = "Your Points: ";
            // 
            // lblNeedingPoint
            // 
            lblNeedingPoint.AutoSize = true;
            lblNeedingPoint.Location = new Point(404, 96);
            lblNeedingPoint.Name = "lblNeedingPoint";
            lblNeedingPoint.Size = new Size(259, 20);
            lblNeedingPoint.TabIndex = 9;
            lblNeedingPoint.Text = "Needing Points for next achievement: ";
            // 
            // pbAchieveLevel
            // 
            pbAchieveLevel.Location = new Point(404, 195);
            pbAchieveLevel.Name = "pbAchieveLevel";
            pbAchieveLevel.Size = new Size(259, 29);
            pbAchieveLevel.TabIndex = 10;
            pbAchieveLevel.Click += pbAchieveLevel_Click;
            // 
            // lbAchievements
            // 
            lbAchievements.FormattingEnabled = true;
            lbAchievements.Location = new Point(410, 317);
            lbAchievements.Name = "lbAchievements";
            lbAchievements.Size = new Size(253, 264);
            lbAchievements.TabIndex = 11;
            // 
            // NUDPoint
            // 
            NUDPoint.Location = new Point(26, 140);
            NUDPoint.Name = "NUDPoint";
            NUDPoint.Size = new Size(125, 27);
            NUDPoint.TabIndex = 12;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(26, 195);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(125, 27);
            tbDescription.TabIndex = 13;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(176, 202);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description";
            // 
            // AchievementTrackerApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 705);
            Controls.Add(lblDescription);
            Controls.Add(tbDescription);
            Controls.Add(NUDPoint);
            Controls.Add(lbAchievements);
            Controls.Add(pbAchieveLevel);
            Controls.Add(lblNeedingPoint);
            Controls.Add(lblYourPoints);
            Controls.Add(btnAddGoal);
            Controls.Add(lblPoint);
            Controls.Add(lblGoal);
            Controls.Add(tbGoal);
            Controls.Add(lblCelFelvetele);
            Controls.Add(lblAppTitle);
            Controls.Add(clbRegisteredGoal);
            Name = "AchievementTrackerApp";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NUDPoint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbRegisteredGoal;
        private Label lblAppTitle;
        private Label lblCelFelvetele;
        private TextBox tbGoal;
        private Label lblGoal;
        private Label lblPoint;
        private Button btnAddGoal;
        private Label lblYourPoints;
        private Label lblNeedingPoint;
        private ProgressBar pbAchieveLevel;
        private ListBox lbAchievements;
        private NumericUpDown NUDPoint;
        private TextBox tbDescription;
        private Label lblDescription;
    }
}
