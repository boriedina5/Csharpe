namespace _11._12._3._feladat
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
            ProductsLB = new ListBox();
            WarhouseLB = new ListBox();
            addBTN = new Button();
            modifyBTN = new Button();
            deleteBTN = new Button();
            searchTB = new TextBox();
            searchBTN = new Button();
            SuspendLayout();
            // 
            // ProductsLB
            // 
            ProductsLB.FormattingEnabled = true;
            ProductsLB.Location = new Point(564, 12);
            ProductsLB.Name = "ProductsLB";
            ProductsLB.Size = new Size(224, 264);
            ProductsLB.TabIndex = 0;
            // 
            // WarhouseLB
            // 
            WarhouseLB.FormattingEnabled = true;
            WarhouseLB.Location = new Point(387, 12);
            WarhouseLB.Name = "WarhouseLB";
            WarhouseLB.Size = new Size(139, 264);
            WarhouseLB.TabIndex = 1;
            WarhouseLB.SelectedIndexChanged += WarhouseLB_SelectedIndexChanged;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(564, 306);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 2;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // modifyBTN
            // 
            modifyBTN.Location = new Point(564, 354);
            modifyBTN.Name = "modifyBTN";
            modifyBTN.Size = new Size(94, 29);
            modifyBTN.TabIndex = 3;
            modifyBTN.Text = "Modify";
            modifyBTN.UseVisualStyleBackColor = true;
            modifyBTN.Click += modifyBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(564, 398);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(94, 29);
            deleteBTN.TabIndex = 4;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // searchTB
            // 
            searchTB.Location = new Point(52, 306);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(125, 27);
            searchTB.TabIndex = 5;
            // 
            // searchBTN
            // 
            searchBTN.Location = new Point(63, 354);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(94, 29);
            searchBTN.TabIndex = 6;
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
            Controls.Add(searchTB);
            Controls.Add(deleteBTN);
            Controls.Add(modifyBTN);
            Controls.Add(addBTN);
            Controls.Add(WarhouseLB);
            Controls.Add(ProductsLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ProductsLB;
        private ListBox WarhouseLB;
        private Button addBTN;
        private Button modifyBTN;
        private Button deleteBTN;
        private TextBox searchTB;
        private Button searchBTN;
    }
}
