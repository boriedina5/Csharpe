namespace _11._12._4._feladat
{
    partial class AddStudents
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
            nameTB = new TextBox();
            nameL = new Label();
            ageN = new NumericUpDown();
            ageL = new Label();
            gradeN = new NumericUpDown();
            gradeL = new Label();
            submitBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)ageN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradeN).BeginInit();
            SuspendLayout();
            // 
            // nameTB
            // 
            nameTB.Location = new Point(30, 41);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 0;
            // 
            // nameL
            // 
            nameL.AutoSize = true;
            nameL.Location = new Point(187, 44);
            nameL.Name = "nameL";
            nameL.Size = new Size(49, 20);
            nameL.TabIndex = 1;
            nameL.Text = "Name";
            // 
            // ageN
            // 
            ageN.Location = new Point(30, 105);
            ageN.Name = "ageN";
            ageN.Size = new Size(150, 27);
            ageN.TabIndex = 2;
            ageN.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // ageL
            // 
            ageL.AutoSize = true;
            ageL.Location = new Point(187, 107);
            ageL.Name = "ageL";
            ageL.Size = new Size(36, 20);
            ageL.TabIndex = 3;
            ageL.Text = "Age";
            // 
            // gradeN
            // 
            gradeN.Location = new Point(30, 182);
            gradeN.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            gradeN.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            gradeN.Name = "gradeN";
            gradeN.Size = new Size(150, 27);
            gradeN.TabIndex = 4;
            gradeN.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gradeL
            // 
            gradeL.AutoSize = true;
            gradeL.Location = new Point(187, 189);
            gradeL.Name = "gradeL";
            gradeL.Size = new Size(49, 20);
            gradeL.TabIndex = 5;
            gradeL.Text = "Grade";
            // 
            // submitBTN
            // 
            submitBTN.Location = new Point(158, 303);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new Size(94, 29);
            submitBTN.TabIndex = 6;
            submitBTN.Text = "Submit";
            submitBTN.UseVisualStyleBackColor = true;
            submitBTN.Click += submitBTN_Click;
            // 
            // AddStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(submitBTN);
            Controls.Add(gradeL);
            Controls.Add(gradeN);
            Controls.Add(ageL);
            Controls.Add(ageN);
            Controls.Add(nameL);
            Controls.Add(nameTB);
            Name = "AddStudents";
            Text = "AddStudents";
            ((System.ComponentModel.ISupportInitialize)ageN).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradeN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTB;
        private Label nameL;
        private NumericUpDown ageN;
        private Label ageL;
        private NumericUpDown gradeN;
        private Label gradeL;
        private Button submitBTN;
    }
}