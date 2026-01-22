namespace RecipeApp.Models
{
    partial class RecipeForm
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
            name = new TextBox();
            NUDDifficulty = new NumericUpDown();
            NUDTime = new NumericUpDown();
            save = new Button();
            clbIngredients = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)NUDDifficulty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDTime).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(27, 27);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 0;
            // 
            // NUDDifficulty
            // 
            NUDDifficulty.Location = new Point(27, 80);
            NUDDifficulty.Name = "NUDDifficulty";
            NUDDifficulty.Size = new Size(150, 27);
            NUDDifficulty.TabIndex = 1;
            // 
            // NUDTime
            // 
            NUDTime.Location = new Point(27, 128);
            NUDTime.Name = "NUDTime";
            NUDTime.Size = new Size(150, 27);
            NUDTime.TabIndex = 2;
            // 
            // save
            // 
            save.Location = new Point(58, 179);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 3;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // clbIngredients
            // 
            clbIngredients.FormattingEnabled = true;
            clbIngredients.HorizontalExtent = 300;
            clbIngredients.HorizontalScrollbar = true;
            clbIngredients.Location = new Point(331, 40);
            clbIngredients.Name = "clbIngredients";
            clbIngredients.ScrollAlwaysVisible = true;
            clbIngredients.Size = new Size(359, 202);
            clbIngredients.TabIndex = 4;
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clbIngredients);
            Controls.Add(save);
            Controls.Add(NUDTime);
            Controls.Add(NUDDifficulty);
            Controls.Add(name);
            Name = "RecipeForm";
            Text = "RecipeForm";
            ((System.ComponentModel.ISupportInitialize)NUDDifficulty).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private NumericUpDown NUDDifficulty;
        private NumericUpDown NUDTime;
        private Button save;
        private CheckedListBox clbIngredients;
    }
}