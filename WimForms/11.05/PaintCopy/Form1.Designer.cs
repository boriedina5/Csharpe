namespace PaintCopy
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
            btnColor = new Button();
            btnClear = new Button();
            btnSave = new Button();
            LineThickness = new NumericUpDown();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)LineThickness).BeginInit();
            SuspendLayout();
            // 
            // btnColor
            // 
            btnColor.Location = new Point(53, 35);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(94, 29);
            btnColor.TabIndex = 0;
            btnColor.Text = "btnColor";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(53, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "btnClear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(53, 137);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // LineThickness
            // 
            LineThickness.Location = new Point(53, 204);
            LineThickness.Name = "LineThickness";
            LineThickness.Size = new Size(150, 27);
            LineThickness.TabIndex = 3;
            LineThickness.ValueChanged += LineThickness_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LineThickness);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnColor);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)LineThickness).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnColor;
        private Button btnClear;
        private Button btnSave;
        private NumericUpDown LineThickness;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
    }
}
