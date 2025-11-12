namespace _11._12._2._feladat
{
    partial class BankForm
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
            accountNumberTB = new TextBox();
            ownerTB = new TextBox();
            accountNumberL = new Label();
            ownerL = new Label();
            balanceN = new NumericUpDown();
            submitBTN = new Button();
            balanceL = new Label();
            ((System.ComponentModel.ISupportInitialize)balanceN).BeginInit();
            SuspendLayout();
            // 
            // accountNumberTB
            // 
            accountNumberTB.Location = new Point(76, 35);
            accountNumberTB.Name = "accountNumberTB";
            accountNumberTB.Size = new Size(125, 27);
            accountNumberTB.TabIndex = 0;
            // 
            // ownerTB
            // 
            ownerTB.Location = new Point(76, 101);
            ownerTB.Name = "ownerTB";
            ownerTB.Size = new Size(125, 27);
            ownerTB.TabIndex = 1;
            // 
            // accountNumberL
            // 
            accountNumberL.AutoSize = true;
            accountNumberL.Location = new Point(237, 38);
            accountNumberL.Name = "accountNumberL";
            accountNumberL.Size = new Size(118, 20);
            accountNumberL.TabIndex = 2;
            accountNumberL.Text = "Account number";
            // 
            // ownerL
            // 
            ownerL.AutoSize = true;
            ownerL.Location = new Point(237, 108);
            ownerL.Name = "ownerL";
            ownerL.Size = new Size(52, 20);
            ownerL.TabIndex = 3;
            ownerL.Text = "Owner";
            // 
            // balanceN
            // 
            balanceN.Location = new Point(76, 194);
            balanceN.Name = "balanceN";
            balanceN.Size = new Size(150, 27);
            balanceN.TabIndex = 4;
            // 
            // submitBTN
            // 
            submitBTN.Location = new Point(107, 296);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new Size(94, 29);
            submitBTN.TabIndex = 5;
            submitBTN.Text = "Submit";
            submitBTN.UseVisualStyleBackColor = true;
            submitBTN.Click += submitBTN_Click;
            // 
            // balanceL
            // 
            balanceL.AutoSize = true;
            balanceL.Location = new Point(248, 201);
            balanceL.Name = "balanceL";
            balanceL.Size = new Size(61, 20);
            balanceL.TabIndex = 6;
            balanceL.Text = "Balance";
            // 
            // BankForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(balanceL);
            Controls.Add(submitBTN);
            Controls.Add(balanceN);
            Controls.Add(ownerL);
            Controls.Add(accountNumberL);
            Controls.Add(ownerTB);
            Controls.Add(accountNumberTB);
            Name = "BankForm";
            Text = "BankForm";
            ((System.ComponentModel.ISupportInitialize)balanceN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox accountNumberTB;
        private TextBox ownerTB;
        private Label accountNumberL;
        private Label ownerL;
        private NumericUpDown balanceN;
        private Button submitBTN;
        private Label balanceL;
    }
}