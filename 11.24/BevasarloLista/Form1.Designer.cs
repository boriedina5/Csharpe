namespace BevasarloLista
{
    partial class Main
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
            lbShoppingList = new ListBox();
            tbName = new TextBox();
            nudQuantity = new NumericUpDown();
            nudPrice = new NumericUpDown();
            btnAdd = new Button();
            btnModify = new Button();
            lAmount = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // lbShoppingList
            // 
            lbShoppingList.FormattingEnabled = true;
            lbShoppingList.Location = new Point(405, 44);
            lbShoppingList.Name = "lbShoppingList";
            lbShoppingList.Size = new Size(306, 304);
            lbShoppingList.TabIndex = 0;
            lbShoppingList.SelectedIndexChanged += lbShoppingList_SelectedIndexChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(54, 50);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(54, 99);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(150, 27);
            nudQuantity.TabIndex = 2;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 1;
            nudPrice.Location = new Point(54, 157);
            nudPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 3;
            nudPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(85, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(85, 278);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 5;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // lAmount
            // 
            lAmount.AutoSize = true;
            lAmount.Location = new Point(68, 383);
            lAmount.Name = "lAmount";
            lAmount.Size = new Size(120, 20);
            lAmount.TabIndex = 6;
            lAmount.Text = "The full amount: ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(85, 339);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(lAmount);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(nudPrice);
            Controls.Add(nudQuantity);
            Controls.Add(tbName);
            Controls.Add(lbShoppingList);
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbShoppingList;
        private TextBox tbName;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudPrice;
        private Button btnAdd;
        private Button btnModify;
        private Label lAmount;
        private Button btnDelete;
    }
}
