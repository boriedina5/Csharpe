namespace _11._10._4._feladat
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
            gameMenu = new TextBox();
            status = new Label();
            On = new Button();
            Off = new Button();
            SuspendLayout();
            // 
            // gameMenu
            // 
            gameMenu.Location = new Point(333, 31);
            gameMenu.Name = "gameMenu";
            gameMenu.Size = new Size(89, 27);
            gameMenu.TabIndex = 0;
            gameMenu.Text = "Game menu";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(313, 89);
            status.Name = "status";
            status.Size = new Size(118, 20);
            status.TabIndex = 1;
            status.Text = "Game Status: off";
            // 
            // On
            // 
            On.Location = new Point(113, 150);
            On.Name = "On";
            On.Size = new Size(94, 29);
            On.TabIndex = 2;
            On.Text = "on";
            On.UseVisualStyleBackColor = true;
            On.Click += On_Click;
            // 
            // Off
            // 
            Off.Location = new Point(552, 150);
            Off.Name = "Off";
            Off.Size = new Size(94, 29);
            Off.TabIndex = 3;
            Off.Text = "off";
            Off.UseVisualStyleBackColor = true;
            Off.Click += Off_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Off);
            Controls.Add(On);
            Controls.Add(status);
            Controls.Add(gameMenu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox gameMenu;
        private Label status;
        private Button On;
        private Button Off;
    }
}
