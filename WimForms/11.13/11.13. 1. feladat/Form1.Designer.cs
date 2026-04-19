namespace _11._13._1._feladat
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
            lbStudents = new ListBox();
            addBTN = new Button();
            modifyBTN = new Button();
            deleteBTN = new Button();
            gradeBTN = new Button();
            searchBTN = new Button();
            searchTB = new TextBox();
            gradeN = new NumericUpDown();
            avarageL = new Label();
            minL = new Label();
            maxL = new Label();
            ((System.ComponentModel.ISupportInitialize)gradeN).BeginInit();
            SuspendLayout();
            // 
            // lbStudents
            // 
            lbStudents.FormattingEnabled = true;
            lbStudents.Location = new Point(505, 43);
            lbStudents.Name = "lbStudents";
            lbStudents.Size = new Size(222, 304);
            lbStudents.TabIndex = 0;
            lbStudents.SelectedIndexChanged += lbStudents_SelectedIndexChanged;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(65, 43);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 1;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // modifyBTN
            // 
            modifyBTN.Location = new Point(65, 95);
            modifyBTN.Name = "modifyBTN";
            modifyBTN.Size = new Size(94, 29);
            modifyBTN.TabIndex = 2;
            modifyBTN.Text = "Modify";
            modifyBTN.UseVisualStyleBackColor = true;
            modifyBTN.Click += modifyBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(65, 155);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(94, 29);
            deleteBTN.TabIndex = 3;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // gradeBTN
            // 
            gradeBTN.Location = new Point(65, 275);
            gradeBTN.Name = "gradeBTN";
            gradeBTN.Size = new Size(94, 29);
            gradeBTN.TabIndex = 4;
            gradeBTN.Text = "Grade";
            gradeBTN.UseVisualStyleBackColor = true;
            gradeBTN.Click += gradeBTN_Click;
            // 
            // searchBTN
            // 
            searchBTN.Location = new Point(65, 378);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(94, 29);
            searchBTN.TabIndex = 5;
            searchBTN.Text = "Search";
            searchBTN.UseVisualStyleBackColor = true;
            searchBTN.Click += searchBTN_Click;
            // 
            // searchTB
            // 
            searchTB.Location = new Point(65, 345);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(125, 27);
            searchTB.TabIndex = 6;
            // 
            // gradeN
            // 
            gradeN.Location = new Point(65, 227);
            gradeN.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            gradeN.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            gradeN.Name = "gradeN";
            gradeN.Size = new Size(150, 27);
            gradeN.TabIndex = 7;
            gradeN.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // avarageL
            // 
            avarageL.AutoSize = true;
            avarageL.Location = new Point(505, 378);
            avarageL.Name = "avarageL";
            avarageL.Size = new Size(64, 20);
            avarageL.TabIndex = 8;
            avarageL.Text = "Avarage";
            // 
            // minL
            // 
            minL.AutoSize = true;
            minL.Location = new Point(602, 378);
            minL.Name = "minL";
            minL.Size = new Size(34, 20);
            minL.TabIndex = 9;
            minL.Text = "Min";
            // 
            // maxL
            // 
            maxL.AutoSize = true;
            maxL.Location = new Point(677, 378);
            maxL.Name = "maxL";
            maxL.Size = new Size(37, 20);
            maxL.TabIndex = 10;
            maxL.Text = "Max";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maxL);
            Controls.Add(minL);
            Controls.Add(avarageL);
            Controls.Add(gradeN);
            Controls.Add(searchTB);
            Controls.Add(searchBTN);
            Controls.Add(gradeBTN);
            Controls.Add(deleteBTN);
            Controls.Add(modifyBTN);
            Controls.Add(addBTN);
            Controls.Add(lbStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gradeN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbStudents;
        private Button addBTN;
        private Button modifyBTN;
        private Button deleteBTN;
        private Button gradeBTN;
        private Button searchBTN;
        private TextBox searchTB;
        private NumericUpDown gradeN;
        private Label avarageL;
        private Label minL;
        private Label maxL;
    }
}
