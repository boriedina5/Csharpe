namespace QuizzApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lQuestion = new Label();
            rbtnA = new RadioButton();
            rbtnB = new RadioButton();
            rbtnC = new RadioButton();
            rbtnD = new RadioButton();
            btnNext = new Button();
            lProgress = new Label();
            lFeedBack = new Label();
            quizTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lQuestion
            // 
            lQuestion.AutoSize = true;
            lQuestion.Location = new Point(131, 54);
            lQuestion.Name = "lQuestion";
            lQuestion.Size = new Size(68, 20);
            lQuestion.TabIndex = 0;
            lQuestion.Text = "Question";
            // 
            // rbtnA
            // 
            rbtnA.AutoSize = true;
            rbtnA.Location = new Point(113, 116);
            rbtnA.Name = "rbtnA";
            rbtnA.Size = new Size(40, 24);
            rbtnA.TabIndex = 1;
            rbtnA.TabStop = true;
            rbtnA.Text = "A";
            rbtnA.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            rbtnB.AutoSize = true;
            rbtnB.Location = new Point(113, 160);
            rbtnB.Name = "rbtnB";
            rbtnB.Size = new Size(39, 24);
            rbtnB.TabIndex = 2;
            rbtnB.TabStop = true;
            rbtnB.Text = "B";
            rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            rbtnC.AutoSize = true;
            rbtnC.Location = new Point(113, 207);
            rbtnC.Name = "rbtnC";
            rbtnC.Size = new Size(39, 24);
            rbtnC.TabIndex = 3;
            rbtnC.TabStop = true;
            rbtnC.Text = "C";
            rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnD
            // 
            rbtnD.AutoSize = true;
            rbtnD.Location = new Point(113, 253);
            rbtnD.Name = "rbtnD";
            rbtnD.Size = new Size(41, 24);
            rbtnD.TabIndex = 4;
            rbtnD.TabStop = true;
            rbtnD.Text = "D";
            rbtnD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(113, 320);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 27);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lProgress
            // 
            lProgress.AutoSize = true;
            lProgress.Location = new Point(113, 384);
            lProgress.Name = "lProgress";
            lProgress.Size = new Size(31, 20);
            lProgress.TabIndex = 6;
            lProgress.Text = "0/5";
            // 
            // lFeedBack
            // 
            lFeedBack.AutoSize = true;
            lFeedBack.Location = new Point(113, 422);
            lFeedBack.Name = "lFeedBack";
            lFeedBack.Size = new Size(79, 20);
            lFeedBack.TabIndex = 7;
            lFeedBack.Text = "Feedback: ";
            // 
            // quizTimer
            // 
            quizTimer.Tick += quizTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 493);
            Controls.Add(lFeedBack);
            Controls.Add(lProgress);
            Controls.Add(btnNext);
            Controls.Add(rbtnD);
            Controls.Add(rbtnC);
            Controls.Add(rbtnB);
            Controls.Add(rbtnA);
            Controls.Add(lQuestion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lQuestion;
        private RadioButton rbtnA;
        private RadioButton rbtnB;
        private RadioButton rbtnC;
        private RadioButton rbtnD;
        private Button btnNext;
        private Label lProgress;
        private Label lFeedBack;
        private System.Windows.Forms.Timer quizTimer;
    }
}
