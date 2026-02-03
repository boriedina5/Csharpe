namespace FormAppGyakorlas
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
            cbCategory = new ComboBox();
            button1 = new Button();
            lbExercies = new ListBox();
            SuspendLayout();
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Derék", "Térd", "Boka" });
            cbCategory.Location = new Point(38, 49);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(211, 28);
            cbCategory.TabIndex = 0;
            cbCategory.Tag = "";
            // 
            // button1
            // 
            button1.Location = new Point(59, 113);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 1;
            button1.Text = "Submit Category";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbExercies
            // 
            lbExercies.FormattingEnabled = true;
            lbExercies.Location = new Point(461, 38);
            lbExercies.Name = "lbExercies";
            lbExercies.Size = new Size(305, 304);
            lbExercies.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbExercies);
            Controls.Add(button1);
            Controls.Add(cbCategory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbCategory;
        private Button button1;
        private ListBox lbExercies;
    }
}
