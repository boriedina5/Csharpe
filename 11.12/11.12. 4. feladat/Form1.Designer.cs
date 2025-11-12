namespace _11._12._4._feladat
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
            searchBTN = new Button();
            studentNameTB = new TextBox();
            SuspendLayout();
            // 
            // lbStudents
            // 
            lbStudents.FormattingEnabled = true;
            lbStudents.Location = new Point(562, 21);
            lbStudents.Name = "lbStudents";
            lbStudents.Size = new Size(226, 304);
            lbStudents.TabIndex = 0;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(215, 39);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 1;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // modifyBTN
            // 
            modifyBTN.Location = new Point(215, 104);
            modifyBTN.Name = "modifyBTN";
            modifyBTN.Size = new Size(94, 29);
            modifyBTN.TabIndex = 2;
            modifyBTN.Text = "Modify";
            modifyBTN.UseVisualStyleBackColor = true;
            modifyBTN.Click += modifyBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(215, 168);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(94, 33);
            deleteBTN.TabIndex = 3;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // searchBTN
            // 
            searchBTN.Location = new Point(215, 350);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(94, 29);
            searchBTN.TabIndex = 4;
            searchBTN.Text = "Search";
            searchBTN.UseVisualStyleBackColor = true;
            searchBTN.Click += searchBTN_Click;
            // 
            // studentNameTB
            // 
            studentNameTB.Location = new Point(203, 294);
            studentNameTB.Name = "studentNameTB";
            studentNameTB.Size = new Size(125, 27);
            studentNameTB.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studentNameTB);
            Controls.Add(searchBTN);
            Controls.Add(deleteBTN);
            Controls.Add(modifyBTN);
            Controls.Add(addBTN);
            Controls.Add(lbStudents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbStudents;
        private Button addBTN;
        private Button modifyBTN;
        private Button deleteBTN;
        private Button searchBTN;
        private TextBox studentNameTB;
    }
}
