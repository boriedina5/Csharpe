namespace Dbgyakorlas
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
            btnReadCustomers = new Button();
            lbProducts = new ListBox();
            btnReadProducts = new Button();
            lbOrders = new ListBox();
            lbOrderDetails = new ListBox();
            btnReadOrders = new Button();
            btnReadOrderDetails = new Button();
            lbCustomers = new ListBox();
            btnExportCustomers = new Button();
            btnExportProducts = new Button();
            btnExportOrders = new Button();
            btnExportOrderDetails = new Button();
            btnExportAll = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnReadCustomers
            // 
            btnReadCustomers.Location = new Point(461, 24);
            btnReadCustomers.Name = "btnReadCustomers";
            btnReadCustomers.Size = new Size(127, 29);
            btnReadCustomers.TabIndex = 2;
            btnReadCustomers.Text = "Read customers";
            btnReadCustomers.UseVisualStyleBackColor = true;
            btnReadCustomers.Click += btnReadCustomers_Click;
            // 
            // lbProducts
            // 
            lbProducts.FormattingEnabled = true;
            lbProducts.HorizontalScrollbar = true;
            lbProducts.Location = new Point(12, 28);
            lbProducts.Name = "lbProducts";
            lbProducts.ScrollAlwaysVisible = true;
            lbProducts.Size = new Size(199, 144);
            lbProducts.TabIndex = 4;
            // 
            // btnReadProducts
            // 
            btnReadProducts.Location = new Point(231, 143);
            btnReadProducts.Name = "btnReadProducts";
            btnReadProducts.Size = new Size(130, 29);
            btnReadProducts.TabIndex = 5;
            btnReadProducts.Text = "Read Products";
            btnReadProducts.UseVisualStyleBackColor = true;
            btnReadProducts.Click += btnReadProducts_Click;
            // 
            // lbOrders
            // 
            lbOrders.FormattingEnabled = true;
            lbOrders.HorizontalScrollbar = true;
            lbOrders.Location = new Point(23, 245);
            lbOrders.Name = "lbOrders";
            lbOrders.ScrollAlwaysVisible = true;
            lbOrders.Size = new Size(218, 164);
            lbOrders.TabIndex = 6;
            // 
            // lbOrderDetails
            // 
            lbOrderDetails.FormattingEnabled = true;
            lbOrderDetails.HorizontalScrollbar = true;
            lbOrderDetails.Location = new Point(581, 245);
            lbOrderDetails.Name = "lbOrderDetails";
            lbOrderDetails.ScrollAlwaysVisible = true;
            lbOrderDetails.Size = new Size(284, 164);
            lbOrderDetails.TabIndex = 7;
            // 
            // btnReadOrders
            // 
            btnReadOrders.Location = new Point(247, 245);
            btnReadOrders.Name = "btnReadOrders";
            btnReadOrders.Size = new Size(138, 29);
            btnReadOrders.TabIndex = 8;
            btnReadOrders.Text = "Read Orders";
            btnReadOrders.UseVisualStyleBackColor = true;
            btnReadOrders.Click += btnReadOrders_Click;
            // 
            // btnReadOrderDetails
            // 
            btnReadOrderDetails.Location = new Point(448, 380);
            btnReadOrderDetails.Name = "btnReadOrderDetails";
            btnReadOrderDetails.Size = new Size(127, 29);
            btnReadOrderDetails.TabIndex = 9;
            btnReadOrderDetails.Text = "Read Orders Details";
            btnReadOrderDetails.UseVisualStyleBackColor = true;
            btnReadOrderDetails.Click += btnReadOrderDetails_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.FormattingEnabled = true;
            lbCustomers.Location = new Point(594, 24);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(271, 144);
            lbCustomers.TabIndex = 10;
            // 
            // btnExportCustomers
            // 
            btnExportCustomers.Location = new Point(291, 24);
            btnExportCustomers.Name = "btnExportCustomers";
            btnExportCustomers.Size = new Size(164, 29);
            btnExportCustomers.TabIndex = 11;
            btnExportCustomers.Text = "Export Customers";
            btnExportCustomers.UseVisualStyleBackColor = true;
            btnExportCustomers.Click += btnExportCustomers_Click;
            // 
            // btnExportProducts
            // 
            btnExportProducts.Location = new Point(376, 143);
            btnExportProducts.Name = "btnExportProducts";
            btnExportProducts.Size = new Size(141, 29);
            btnExportProducts.TabIndex = 12;
            btnExportProducts.Text = "Export Products";
            btnExportProducts.UseVisualStyleBackColor = true;
            btnExportProducts.Click += btnExportProducts_Click;
            // 
            // btnExportOrders
            // 
            btnExportOrders.Location = new Point(391, 245);
            btnExportOrders.Name = "btnExportOrders";
            btnExportOrders.Size = new Size(126, 29);
            btnExportOrders.TabIndex = 13;
            btnExportOrders.Text = "Export Orders";
            btnExportOrders.UseVisualStyleBackColor = true;
            btnExportOrders.Click += btnExportOrders_Click;
            // 
            // btnExportOrderDetails
            // 
            btnExportOrderDetails.Location = new Point(275, 380);
            btnExportOrderDetails.Name = "btnExportOrderDetails";
            btnExportOrderDetails.Size = new Size(167, 29);
            btnExportOrderDetails.TabIndex = 14;
            btnExportOrderDetails.Text = "Export Order Details";
            btnExportOrderDetails.UseVisualStyleBackColor = true;
            btnExportOrderDetails.Click += btnExportOrderDetails_Click;
            // 
            // btnExportAll
            // 
            btnExportAll.Location = new Point(391, 485);
            btnExportAll.Name = "btnExportAll";
            btnExportAll.Size = new Size(94, 29);
            btnExportAll.TabIndex = 15;
            btnExportAll.Text = "Export All";
            btnExportAll.UseVisualStyleBackColor = true;
            btnExportAll.Click += btnExportAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 598);
            Controls.Add(btnExportAll);
            Controls.Add(btnExportOrderDetails);
            Controls.Add(btnExportOrders);
            Controls.Add(btnExportProducts);
            Controls.Add(btnExportCustomers);
            Controls.Add(lbCustomers);
            Controls.Add(btnReadOrderDetails);
            Controls.Add(btnReadOrders);
            Controls.Add(lbOrderDetails);
            Controls.Add(lbOrders);
            Controls.Add(btnReadProducts);
            Controls.Add(lbProducts);
            Controls.Add(btnReadCustomers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnReadCustomers;
        private Label label1;
        private ListBox lbProducts;
        private Button btnReadProducts;
        private ListBox lbOrders;
        private ListBox lbOrderDetails;
        private Button btnReadOrders;
        private Button btnReadOrderDetails;
        private ListBox lbCustomers;
        private Button btnExportCustomers;
        private Button btnExportProducts;
        private Button btnExportOrders;
        private Button btnExportOrderDetails;
        private Button btnExportAll;
        private SaveFileDialog saveFileDialog1;
    }
}
