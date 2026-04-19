namespace _11._10._1._feladat
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
            numb1 = new NumericUpDown();
            numb2 = new NumericUpDown();
            title = new TextBox();
            operation = new TextBox();
            sum = new RadioButton();
            sub = new RadioButton();
            div = new RadioButton();
            mul = new RadioButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numb2).BeginInit();
            SuspendLayout();
            // 
            // numb1
            // 
            numb1.Location = new Point(79, 98);
            numb1.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            numb1.Name = "numb1";
            numb1.Size = new Size(150, 27);
            numb1.TabIndex = 0;
            // 
            // numb2
            // 
            numb2.Location = new Point(493, 98);
            numb2.Name = "numb2";
            numb2.Size = new Size(150, 27);
            numb2.TabIndex = 1;
            // 
            // title
            // 
            title.Location = new Point(344, 12);
            title.Name = "title";
            title.Size = new Size(69, 27);
            title.TabIndex = 2;
            title.Text = "Calculator";
            // 
            // operation
            // 
            operation.Location = new Point(306, 151);
            operation.Name = "operation";
            operation.Size = new Size(145, 27);
            operation.TabIndex = 3;
            operation.Text = "Choose an operation";
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Location = new Point(321, 230);
            sum.Name = "sum";
            sum.Size = new Size(59, 24);
            sum.TabIndex = 4;
            sum.TabStop = true;
            sum.Text = "Sum";
            sum.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            sub.AutoSize = true;
            sub.Location = new Point(321, 260);
            sub.Name = "sub";
            sub.Size = new Size(55, 24);
            sub.TabIndex = 5;
            sub.TabStop = true;
            sub.Text = "Sub";
            sub.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            div.AutoSize = true;
            div.Location = new Point(321, 290);
            div.Name = "div";
            div.Size = new Size(52, 24);
            div.TabIndex = 6;
            div.TabStop = true;
            div.Text = "Div";
            div.UseVisualStyleBackColor = true;
            // 
            // mul
            // 
            mul.AutoSize = true;
            mul.Location = new Point(321, 320);
            mul.Name = "mul";
            mul.Size = new Size(55, 24);
            mul.TabIndex = 7;
            mul.TabStop = true;
            mul.Text = "Mul";
            mul.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(334, 384);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(mul);
            Controls.Add(div);
            Controls.Add(sub);
            Controls.Add(sum);
            Controls.Add(operation);
            Controls.Add(title);
            Controls.Add(numb2);
            Controls.Add(numb1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numb2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numb1;
        private NumericUpDown numb2;
        private TextBox title;
        private TextBox operation;
        private RadioButton sum;
        private RadioButton sub;
        private RadioButton div;
        private RadioButton mul;
        private Button button1;
    }
}
