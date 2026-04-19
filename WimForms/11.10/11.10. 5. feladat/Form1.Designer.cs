namespace _11._10._5._feladat
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
            title = new Label();
            number = new TextBox();
            minititle = new Label();
            submit = new Button();
            label1 = new Label();
            Solve = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(336, 31);
            title.Name = "title";
            title.Size = new Size(127, 20);
            title.TabIndex = 0;
            title.Tag = "";
            title.Text = "Guess the number";
            // 
            // number
            // 
            number.Location = new Point(338, 129);
            number.Name = "number";
            number.Size = new Size(125, 27);
            number.TabIndex = 1;
            // 
            // minititle
            // 
            minititle.AutoSize = true;
            minititle.Location = new Point(338, 106);
            minititle.Name = "minititle";
            minititle.Size = new Size(123, 20);
            minititle.TabIndex = 2;
            minititle.Text = "Enter the number";
            // 
            // submit
            // 
            submit.Location = new Point(354, 219);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 3;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 60);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 4;
            label1.Text = "1-100";
            // 
            // Solve
            // 
            Solve.Location = new Point(220, 285);
            Solve.Name = "Solve";
            Solve.Size = new Size(370, 29);
            Solve.TabIndex = 5;
            Solve.Text = "Most már igazán megmutathatnád a megoldást";
            Solve.UseVisualStyleBackColor = true;
            Solve.Click += Solve_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Solve);
            Controls.Add(label1);
            Controls.Add(submit);
            Controls.Add(minititle);
            Controls.Add(number);
            Controls.Add(title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox number;
        private Label minititle;
        private Button submit;
        private Label label1;
        private Button Solve;
    }
}
