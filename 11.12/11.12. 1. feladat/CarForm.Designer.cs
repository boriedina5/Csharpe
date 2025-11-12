namespace _11._12._1._feladat
{
    partial class CarForm
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
            yearN = new NumericUpDown();
            priceN = new NumericUpDown();
            brandTB = new TextBox();
            modelTB = new TextBox();
            brand = new Label();
            model = new Label();
            addCars = new Button();
            year = new Label();
            price = new Label();
            ((System.ComponentModel.ISupportInitialize)yearN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceN).BeginInit();
            SuspendLayout();
            // 
            // yearN
            // 
            yearN.Location = new Point(40, 134);
            yearN.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearN.Name = "yearN";
            yearN.Size = new Size(150, 27);
            yearN.TabIndex = 0;
            // 
            // priceN
            // 
            priceN.DecimalPlaces = 1;
            priceN.Location = new Point(40, 185);
            priceN.Name = "priceN";
            priceN.Size = new Size(150, 27);
            priceN.TabIndex = 1;
            // 
            // brandTB
            // 
            brandTB.Location = new Point(50, 22);
            brandTB.Name = "brandTB";
            brandTB.Size = new Size(125, 27);
            brandTB.TabIndex = 2;
            // 
            // modelTB
            // 
            modelTB.Location = new Point(50, 75);
            modelTB.Name = "modelTB";
            modelTB.Size = new Size(125, 27);
            modelTB.TabIndex = 3;
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Location = new Point(190, 29);
            brand.Name = "brand";
            brand.Size = new Size(48, 20);
            brand.TabIndex = 4;
            brand.Text = "Brand";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Location = new Point(190, 78);
            model.Name = "model";
            model.Size = new Size(52, 20);
            model.TabIndex = 5;
            model.Text = "Model";
            // 
            // addCars
            // 
            addCars.Location = new Point(96, 270);
            addCars.Name = "addCars";
            addCars.Size = new Size(94, 29);
            addCars.TabIndex = 6;
            addCars.Text = "Add";
            addCars.UseVisualStyleBackColor = true;
            addCars.Click += addCars_Click;
            // 
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(209, 141);
            year.Name = "year";
            year.Size = new Size(37, 20);
            year.TabIndex = 7;
            year.Text = "Year";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(209, 187);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 8;
            price.Text = "Price";
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 359);
            Controls.Add(price);
            Controls.Add(year);
            Controls.Add(addCars);
            Controls.Add(model);
            Controls.Add(brand);
            Controls.Add(modelTB);
            Controls.Add(brandTB);
            Controls.Add(priceN);
            Controls.Add(yearN);
            Name = "CarForm";
            Text = "CarForm";
            ((System.ComponentModel.ISupportInitialize)yearN).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown yearN;
        private NumericUpDown priceN;
        private TextBox brandTB;
        private TextBox modelTB;
        private Label brand;
        private Label model;
        private Button addCars;
        private Label year;
        private Label price;
    }
}