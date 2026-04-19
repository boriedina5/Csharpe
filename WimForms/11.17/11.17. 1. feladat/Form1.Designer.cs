namespace _11._17._1._feladat
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
            titleTB = new TextBox();
            genreCB = new ComboBox();
            relasedYearN = new NumericUpDown();
            AddBTN = new Button();
            lbFilms = new ListBox();
            searchBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)relasedYearN).BeginInit();
            SuspendLayout();
            // 
            // titleTB
            // 
            titleTB.Location = new Point(55, 40);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(125, 27);
            titleTB.TabIndex = 0;
            // 
            // genreCB
            // 
            genreCB.AutoCompleteCustomSource.AddRange(new string[] { "Sci-fi", "Fantasy", "Romcom" });
            genreCB.FormattingEnabled = true;
            genreCB.Items.AddRange(new object[] { "Sci-fi", "Fantasy", "Romcom" });
            genreCB.Location = new Point(55, 99);
            genreCB.Name = "genreCB";
            genreCB.Size = new Size(151, 28);
            genreCB.TabIndex = 1;
            // 
            // relasedYearN
            // 
            relasedYearN.Location = new Point(55, 163);
            relasedYearN.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            relasedYearN.Minimum = new decimal(new int[] { 1888, 0, 0, 0 });
            relasedYearN.Name = "relasedYearN";
            relasedYearN.Size = new Size(150, 27);
            relasedYearN.TabIndex = 2;
            relasedYearN.Value = new decimal(new int[] { 1888, 0, 0, 0 });
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(86, 280);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(94, 29);
            AddBTN.TabIndex = 3;
            AddBTN.Text = "Add";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // lbFilms
            // 
            lbFilms.FormattingEnabled = true;
            lbFilms.Location = new Point(459, 31);
            lbFilms.Name = "lbFilms";
            lbFilms.Size = new Size(304, 384);
            lbFilms.TabIndex = 4;
            // 
            // searchBTN
            // 
            searchBTN.Location = new Point(86, 386);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(94, 29);
            searchBTN.TabIndex = 5;
            searchBTN.Text = "Search";
            searchBTN.UseVisualStyleBackColor = true;
            searchBTN.Click += searchBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchBTN);
            Controls.Add(lbFilms);
            Controls.Add(AddBTN);
            Controls.Add(relasedYearN);
            Controls.Add(genreCB);
            Controls.Add(titleTB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)relasedYearN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTB;
        private ComboBox genreCB;
        private NumericUpDown relasedYearN;
        private Button AddBTN;
        private ListBox lbFilms;
        private Button searchBTN;
    }
}
