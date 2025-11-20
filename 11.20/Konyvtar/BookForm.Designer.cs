namespace Konyvtar
{
    partial class BookForm
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
            lbBooks = new ListBox();
            tbTitle = new TextBox();
            tbAuthor = new TextBox();
            tbGenre = new TextBox();
            nReleasedYear = new NumericUpDown();
            addBTN = new Button();
            updateBTN = new Button();
            deleteBTN = new Button();
            searchBTN = new Button();
            cbSearch = new ComboBox();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nReleasedYear).BeginInit();
            SuspendLayout();
            // 
            // lbBooks
            // 
            lbBooks.FormattingEnabled = true;
            lbBooks.Location = new Point(544, 69);
            lbBooks.Name = "lbBooks";
            lbBooks.Size = new Size(178, 204);
            lbBooks.TabIndex = 0;
            lbBooks.SelectedIndexChanged += lbBooks_SelectedIndexChanged;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(49, 12);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(125, 27);
            tbTitle.TabIndex = 1;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(49, 45);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(125, 27);
            tbAuthor.TabIndex = 2;
            // 
            // tbGenre
            // 
            tbGenre.Location = new Point(49, 88);
            tbGenre.Name = "tbGenre";
            tbGenre.Size = new Size(125, 27);
            tbGenre.TabIndex = 3;
            // 
            // nReleasedYear
            // 
            nReleasedYear.Location = new Point(49, 132);
            nReleasedYear.Name = "nReleasedYear";
            nReleasedYear.Size = new Size(150, 27);
            nReleasedYear.TabIndex = 4;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(65, 183);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 5;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(65, 234);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(94, 29);
            updateBTN.TabIndex = 6;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Click += updateBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(65, 281);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(94, 29);
            deleteBTN.TabIndex = 7;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // searchBTN
            // 
            searchBTN.Location = new Point(65, 409);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(94, 29);
            searchBTN.TabIndex = 8;
            searchBTN.Text = "Search";
            searchBTN.UseVisualStyleBackColor = true;
            searchBTN.Click += searchBTN_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Genre", "Title", "Author" });
            cbSearch.Location = new Point(36, 326);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(151, 28);
            cbSearch.TabIndex = 9;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(49, 372);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(125, 27);
            tbSearch.TabIndex = 10;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbSearch);
            Controls.Add(cbSearch);
            Controls.Add(searchBTN);
            Controls.Add(deleteBTN);
            Controls.Add(updateBTN);
            Controls.Add(addBTN);
            Controls.Add(nReleasedYear);
            Controls.Add(tbGenre);
            Controls.Add(tbAuthor);
            Controls.Add(tbTitle);
            Controls.Add(lbBooks);
            Name = "BookForm";
            Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)nReleasedYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbBooks;
        private TextBox tbTitle;
        private TextBox tbAuthor;
        private TextBox tbGenre;
        private NumericUpDown nReleasedYear;
        private Button addBTN;
        private Button updateBTN;
        private Button deleteBTN;
        private Button searchBTN;
        private ComboBox cbSearch;
        private TextBox tbSearch;
    }
}