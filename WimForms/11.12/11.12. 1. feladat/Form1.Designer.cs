namespace _11._12._1._feladat
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
            ibCars = new ListBox();
            add = new Button();
            update = new Button();
            delete = new Button();
            comboBox = new ComboBox();
            textBox = new TextBox();
            search = new Button();
            SuspendLayout();
            // 
            // ibCars
            // 
            ibCars.FormattingEnabled = true;
            ibCars.Location = new Point(450, 36);
            ibCars.Name = "ibCars";
            ibCars.Size = new Size(320, 344);
            ibCars.TabIndex = 0;
            // 
            // add
            // 
            add.Location = new Point(73, 41);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 1;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // update
            // 
            update.Location = new Point(73, 106);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 2;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(73, 184);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 3;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Brand", "Model", "Year" });
            comboBox.Location = new Point(63, 265);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(151, 28);
            comboBox.TabIndex = 4;
            // 
            // textBox
            // 
            textBox.Location = new Point(73, 313);
            textBox.Name = "textBox";
            textBox.Size = new Size(125, 27);
            textBox.TabIndex = 5;
            // 
            // search
            // 
            search.Location = new Point(73, 397);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 6;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(search);
            Controls.Add(textBox);
            Controls.Add(comboBox);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(add);
            Controls.Add(ibCars);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ibCars;
        private Button add;
        private Button update;
        private Button delete;
        private ComboBox comboBox;
        private TextBox textBox;
        private Button search;
    }
}
