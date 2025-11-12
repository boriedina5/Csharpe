namespace _11._12._3._feladat
{
    partial class ProductForm
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
            priceN = new NumericUpDown();
            quantityN = new NumericUpDown();
            productNameTB = new TextBox();
            submitBTN = new Button();
            WarehouseCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)priceN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityN).BeginInit();
            SuspendLayout();
            // 
            // priceN
            // 
            priceN.DecimalPlaces = 1;
            priceN.Location = new Point(44, 150);
            priceN.Name = "priceN";
            priceN.Size = new Size(150, 27);
            priceN.TabIndex = 0;
            // 
            // quantityN
            // 
            quantityN.Location = new Point(44, 205);
            quantityN.Name = "quantityN";
            quantityN.Size = new Size(150, 27);
            quantityN.TabIndex = 1;
            // 
            // productNameTB
            // 
            productNameTB.Location = new Point(44, 97);
            productNameTB.Name = "productNameTB";
            productNameTB.Size = new Size(125, 27);
            productNameTB.TabIndex = 2;
            // 
            // submitBTN
            // 
            submitBTN.Location = new Point(75, 257);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new Size(94, 29);
            submitBTN.TabIndex = 3;
            submitBTN.Text = "Submit";
            submitBTN.UseVisualStyleBackColor = true;
            submitBTN.Click += submitBTN_Click;
            // 
            // WarehouseCB
            // 
            WarehouseCB.FormattingEnabled = true;
            WarehouseCB.Location = new Point(43, 44);
            WarehouseCB.Name = "WarehouseCB";
            WarehouseCB.Size = new Size(151, 28);
            WarehouseCB.TabIndex = 4;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 339);
            Controls.Add(WarehouseCB);
            Controls.Add(submitBTN);
            Controls.Add(productNameTB);
            Controls.Add(quantityN);
            Controls.Add(priceN);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)priceN).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown priceN;
        private NumericUpDown quantityN;
        private TextBox productNameTB;
        private Button submitBTN;
        private ComboBox WarehouseCB;
    }
}