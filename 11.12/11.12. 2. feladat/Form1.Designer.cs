namespace _11._12._2._feladat
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
            lbAccounts = new ListBox();
            addBTN = new Button();
            amountN = new NumericUpDown();
            depositBTN = new Button();
            withdrawBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)amountN).BeginInit();
            SuspendLayout();
            // 
            // lbAccounts
            // 
            lbAccounts.FormattingEnabled = true;
            lbAccounts.Location = new Point(494, 63);
            lbAccounts.Name = "lbAccounts";
            lbAccounts.Size = new Size(265, 284);
            lbAccounts.TabIndex = 0;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(64, 46);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 1;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // amountN
            // 
            amountN.DecimalPlaces = 1;
            amountN.Location = new Point(37, 116);
            amountN.Name = "amountN";
            amountN.Size = new Size(150, 27);
            amountN.TabIndex = 2;
            // 
            // depositBTN
            // 
            depositBTN.Location = new Point(37, 173);
            depositBTN.Name = "depositBTN";
            depositBTN.Size = new Size(94, 29);
            depositBTN.TabIndex = 3;
            depositBTN.Text = "Deposit";
            depositBTN.UseVisualStyleBackColor = true;
            depositBTN.Click += depositBTN_Click;
            // 
            // withdrawBTN
            // 
            withdrawBTN.Location = new Point(157, 173);
            withdrawBTN.Name = "withdrawBTN";
            withdrawBTN.Size = new Size(94, 29);
            withdrawBTN.TabIndex = 4;
            withdrawBTN.Text = "Withdraw";
            withdrawBTN.UseVisualStyleBackColor = true;
            withdrawBTN.Click += withdrawBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(withdrawBTN);
            Controls.Add(depositBTN);
            Controls.Add(amountN);
            Controls.Add(addBTN);
            Controls.Add(lbAccounts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)amountN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbAccounts;
        private Button addBTN;
        private NumericUpDown amountN;
        private Button depositBTN;
        private Button withdrawBTN;
    }
}
