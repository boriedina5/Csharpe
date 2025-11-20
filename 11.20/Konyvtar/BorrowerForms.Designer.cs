namespace Konyvtar
{
    partial class BorrowerForms
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
            tbName = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            addBTN = new Button();
            updateBTN = new Button();
            deleteBTN = new Button();
            lbBorrowers = new ListBox();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(31, 34);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 0;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(31, 80);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 1;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(31, 132);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(125, 27);
            tbPhone.TabIndex = 2;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(62, 212);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 3;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(62, 270);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(94, 29);
            updateBTN.TabIndex = 4;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Click += updateBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(62, 330);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(94, 29);
            deleteBTN.TabIndex = 5;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // lbBorrowers
            // 
            lbBorrowers.FormattingEnabled = true;
            lbBorrowers.Location = new Point(267, 34);
            lbBorrowers.Name = "lbBorrowers";
            lbBorrowers.Size = new Size(476, 304);
            lbBorrowers.TabIndex = 6;
            lbBorrowers.SelectedIndexChanged += lbBorrowers_SelectedIndexChanged;
            // 
            // BorrowerForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbBorrowers);
            Controls.Add(deleteBTN);
            Controls.Add(updateBTN);
            Controls.Add(addBTN);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Name = "BorrowerForms";
            Text = "BorrowerForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private Button addBTN;
        private Button updateBTN;
        private Button deleteBTN;
        private ListBox lbBorrowers;
    }
}