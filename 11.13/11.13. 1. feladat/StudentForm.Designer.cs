namespace _11._13._1._feladat
{
    partial class StudentForm
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
            ageN = new NumericUpDown();
            submitBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)ageN).BeginInit();
            SuspendLayout();
            // 
            // nameTB
            // 
            nameTB.Location = new Point(75, 58);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 0;
            // 
            // ageN
            // 
            ageN.Location = new Point(75, 145);
            ageN.Name = "ageN";
            ageN.Size = new Size(150, 27);
            ageN.TabIndex = 1;
            // 
            // submitBTN
            // 
            submitBTN.Location = new Point(90, 266);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new Size(94, 29);
            submitBTN.TabIndex = 2;
            submitBTN.Text = "Submit";
            submitBTN.UseVisualStyleBackColor = true;
            submitBTN.Click += submitBTN_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(submitBTN);
            Controls.Add(ageN);
            Controls.Add(nameTB);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)ageN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTB;
        private NumericUpDown ageN;
        private Button submitBTN;
    }
}