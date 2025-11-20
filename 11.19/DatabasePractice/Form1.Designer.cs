namespace _4._feladat___ez_már_kell_a_vizsgához
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
            lbCars = new ListBox();
            brandTB = new TextBox();
            modelTB = new TextBox();
            yearN = new NumericUpDown();
            priceN = new NumericUpDown();
            addBTN = new Button();
            updateBTN = new Button();
            deleteBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)yearN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceN).BeginInit();
            SuspendLayout();
            // 
            // lbCars
            // 
            lbCars.FormattingEnabled = true;
            lbCars.Location = new Point(563, 41);
            lbCars.Name = "lbCars";
            lbCars.Size = new Size(169, 304);
            lbCars.TabIndex = 0;
            lbCars.SelectedIndexChanged += lbCras_SelectedIndexChanged;
            // 
            // brandTB
            // 
            brandTB.Location = new Point(69, 60);
            brandTB.Name = "brandTB";
            brandTB.Size = new Size(184, 27);
            brandTB.TabIndex = 1;
            // 
            // modelTB
            // 
            modelTB.Location = new Point(69, 111);
            modelTB.Name = "modelTB";
            modelTB.Size = new Size(184, 27);
            modelTB.TabIndex = 2;
            // 
            // yearN
            // 
            yearN.Location = new Point(80, 177);
            yearN.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearN.Minimum = new decimal(new int[] { 1700, 0, 0, 0 });
            yearN.Name = "yearN";
            yearN.Size = new Size(173, 27);
            yearN.TabIndex = 3;
            yearN.Value = new decimal(new int[] { 1700, 0, 0, 0 });
            // 
            // priceN
            // 
            priceN.Location = new Point(82, 232);
            priceN.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceN.Name = "priceN";
            priceN.Size = new Size(181, 27);
            priceN.TabIndex = 4;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(119, 299);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 5;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(119, 350);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(94, 29);
            updateBTN.TabIndex = 6;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Click += updateBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(119, 409);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(94, 29);
            deleteBTN.TabIndex = 7;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteBTN);
            Controls.Add(updateBTN);
            Controls.Add(addBTN);
            Controls.Add(priceN);
            Controls.Add(yearN);
            Controls.Add(modelTB);
            Controls.Add(brandTB);
            Controls.Add(lbCars);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)yearN).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCars;
        private TextBox brandTB;
        private TextBox modelTB;
        private NumericUpDown yearN;
        private NumericUpDown priceN;
        private Button addBTN;
        private Button updateBTN;
        private Button deleteBTN;
    }
}
