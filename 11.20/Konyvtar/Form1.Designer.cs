namespace Konyvtar
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
            lbLoans = new ListBox();
            booksBTN = new Button();
            borrowersBTN = new Button();
            cbBooks = new ComboBox();
            cbBorrower = new ComboBox();
            dateTimePicker = new DateTimePicker();
            addBTN = new Button();
            SuspendLayout();
            // 
            // lbLoans
            // 
            lbLoans.FormattingEnabled = true;
            lbLoans.Location = new Point(551, 58);
            lbLoans.Name = "lbLoans";
            lbLoans.Size = new Size(214, 304);
            lbLoans.TabIndex = 0;
            // 
            // booksBTN
            // 
            booksBTN.Location = new Point(61, 40);
            booksBTN.Name = "booksBTN";
            booksBTN.Size = new Size(94, 29);
            booksBTN.TabIndex = 1;
            booksBTN.Text = "Books";
            booksBTN.UseVisualStyleBackColor = true;
            booksBTN.Click += booksBTN_Click;
            // 
            // borrowersBTN
            // 
            borrowersBTN.Location = new Point(61, 91);
            borrowersBTN.Name = "borrowersBTN";
            borrowersBTN.Size = new Size(94, 29);
            borrowersBTN.TabIndex = 2;
            borrowersBTN.Text = "Borrowers";
            borrowersBTN.UseVisualStyleBackColor = true;
            borrowersBTN.Click += borrowersBTN_Click;
            // 
            // cbBooks
            // 
            cbBooks.FormattingEnabled = true;
            cbBooks.Location = new Point(369, 58);
            cbBooks.Name = "cbBooks";
            cbBooks.Size = new Size(151, 28);
            cbBooks.TabIndex = 4;
            // 
            // cbBorrower
            // 
            cbBorrower.FormattingEnabled = true;
            cbBorrower.Location = new Point(369, 105);
            cbBorrower.Name = "cbBorrower";
            cbBorrower.Size = new Size(151, 28);
            cbBorrower.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(280, 152);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(420, 204);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 7;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addBTN);
            Controls.Add(dateTimePicker);
            Controls.Add(cbBorrower);
            Controls.Add(cbBooks);
            Controls.Add(borrowersBTN);
            Controls.Add(booksBTN);
            Controls.Add(lbLoans);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbLoans;
        private Button booksBTN;
        private Button borrowersBTN;
        private ComboBox cbBooks;
        private ComboBox cbBorrower;
        private DateTimePicker dateTimePicker;
        private Button addBTN;
    }
}
