namespace _11._10._2._feladat
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
            pictureBox = new PictureBox();
            message = new Label();
            submit = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(244, 138);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(412, 266);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(351, 30);
            message.Name = "message";
            message.Size = new Size(120, 20);
            message.TabIndex = 1;
            message.Text = "Upload a picture";
            // 
            // submit
            // 
            submit.Location = new Point(362, 80);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 2;
            submit.Text = "Upload";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submit);
            Controls.Add(message);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label message;
        private Button submit;
        private OpenFileDialog openFileDialog1;
    }
}
