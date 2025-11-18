namespace _11._17._2._feladat
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
            nameTB = new TextBox();
            positionTB = new TextBox();
            salaryN = new NumericUpDown();
            lbEmployee = new ListBox();
            addBTN = new Button();
            calculateAvarageSalaryBTN = new Button();
            avarageSalaryL = new Label();
            ((System.ComponentModel.ISupportInitialize)salaryN).BeginInit();
            SuspendLayout();
            // 
            // nameTB
            // 
            nameTB.Location = new Point(52, 66);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 0;
            // 
            // positionTB
            // 
            positionTB.Location = new Point(52, 141);
            positionTB.Name = "positionTB";
            positionTB.Size = new Size(125, 27);
            positionTB.TabIndex = 1;
            // 
            // salaryN
            // 
            salaryN.Location = new Point(52, 208);
            salaryN.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            salaryN.Name = "salaryN";
            salaryN.Size = new Size(150, 27);
            salaryN.TabIndex = 2;
            // 
            // lbEmployee
            // 
            lbEmployee.FormattingEnabled = true;
            lbEmployee.Location = new Point(439, 66);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(151, 224);
            lbEmployee.TabIndex = 3;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(83, 296);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 4;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // calculateAvarageSalaryBTN
            // 
            calculateAvarageSalaryBTN.Location = new Point(69, 343);
            calculateAvarageSalaryBTN.Name = "calculateAvarageSalaryBTN";
            calculateAvarageSalaryBTN.Size = new Size(133, 64);
            calculateAvarageSalaryBTN.TabIndex = 5;
            calculateAvarageSalaryBTN.Text = "Calculate Avarage Salary";
            calculateAvarageSalaryBTN.UseVisualStyleBackColor = true;
            calculateAvarageSalaryBTN.Click += calculateAvarageSalaryBTN_Click;
            // 
            // avarageSalaryL
            // 
            avarageSalaryL.AutoSize = true;
            avarageSalaryL.Location = new Point(448, 315);
            avarageSalaryL.Name = "avarageSalaryL";
            avarageSalaryL.Size = new Size(115, 20);
            avarageSalaryL.TabIndex = 6;
            avarageSalaryL.Text = "Avarage Salary: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(avarageSalaryL);
            Controls.Add(calculateAvarageSalaryBTN);
            Controls.Add(addBTN);
            Controls.Add(lbEmployee);
            Controls.Add(salaryN);
            Controls.Add(positionTB);
            Controls.Add(nameTB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)salaryN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTB;
        private TextBox positionTB;
        private NumericUpDown salaryN;
        private ListBox lbEmployee;
        private Button addBTN;
        private Button calculateAvarageSalaryBTN;
        private Label avarageSalaryL;
    }
}
