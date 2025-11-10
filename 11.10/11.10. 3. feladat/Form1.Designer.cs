namespace _11._10._3._feladat
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
            sights = new ListBox();
            Cities = new ComboBox();
            SuspendLayout();
            // 
            // sights
            // 
            sights.FormattingEnabled = true;
            sights.Location = new Point(472, 34);
            sights.Name = "sights";
            sights.Size = new Size(213, 244);
            sights.TabIndex = 0;
            // 
            // Cities
            // 
            Cities.FormattingEnabled = true;
            Cities.Location = new Point(56, 45);
            Cities.Name = "Cities";
            Cities.Size = new Size(151, 28);
            Cities.TabIndex = 1;
            Cities.Text = "Cities";
            Cities.SelectedIndexChanged += Cities_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cities);
            Controls.Add(sights);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox sights;
        private ComboBox Cities;
    }
}
