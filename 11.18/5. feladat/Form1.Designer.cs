namespace _5._feladat
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
            ujNevTB = new TextBox();
            ujTantargyTB = new TextBox();
            ujTanuloHozzadasaBTN = new Button();
            jegyHozzadasaBTN = new Button();
            atlagSzamolasBTN = new Button();
            jegyN = new NumericUpDown();
            lbNaplo = new ListBox();
            atlagL = new Label();
            ujJegyN = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)jegyN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ujJegyN).BeginInit();
            SuspendLayout();
            // 
            // ujNevTB
            // 
            ujNevTB.Location = new Point(72, 45);
            ujNevTB.Name = "ujNevTB";
            ujNevTB.Size = new Size(125, 27);
            ujNevTB.TabIndex = 0;
            // 
            // ujTantargyTB
            // 
            ujTantargyTB.Location = new Point(72, 111);
            ujTantargyTB.Name = "ujTantargyTB";
            ujTantargyTB.Size = new Size(125, 27);
            ujTantargyTB.TabIndex = 1;
            // 
            // ujTanuloHozzadasaBTN
            // 
            ujTanuloHozzadasaBTN.Location = new Point(51, 238);
            ujTanuloHozzadasaBTN.Name = "ujTanuloHozzadasaBTN";
            ujTanuloHozzadasaBTN.Size = new Size(200, 29);
            ujTanuloHozzadasaBTN.TabIndex = 3;
            ujTanuloHozzadasaBTN.Text = "Új tanuló hozzáadása";
            ujTanuloHozzadasaBTN.UseVisualStyleBackColor = true;
            ujTanuloHozzadasaBTN.Click += ujTanuloHozzadasaBTN_Click;
            // 
            // jegyHozzadasaBTN
            // 
            jegyHozzadasaBTN.Location = new Point(283, 238);
            jegyHozzadasaBTN.Name = "jegyHozzadasaBTN";
            jegyHozzadasaBTN.Size = new Size(172, 29);
            jegyHozzadasaBTN.TabIndex = 4;
            jegyHozzadasaBTN.Text = "Jegy hozzáadása";
            jegyHozzadasaBTN.UseVisualStyleBackColor = true;
            jegyHozzadasaBTN.Click += jegyHozzadasaBTN_Click;
            // 
            // atlagSzamolasBTN
            // 
            atlagSzamolasBTN.Location = new Point(212, 363);
            atlagSzamolasBTN.Name = "atlagSzamolasBTN";
            atlagSzamolasBTN.Size = new Size(94, 29);
            atlagSzamolasBTN.TabIndex = 5;
            atlagSzamolasBTN.Text = "Átlag";
            atlagSzamolasBTN.UseVisualStyleBackColor = true;
            atlagSzamolasBTN.Click += atlagSzamolasBTN_Click;
            // 
            // jegyN
            // 
            jegyN.Location = new Point(283, 181);
            jegyN.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            jegyN.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            jegyN.Name = "jegyN";
            jegyN.Size = new Size(150, 27);
            jegyN.TabIndex = 7;
            jegyN.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbNaplo
            // 
            lbNaplo.FormattingEnabled = true;
            lbNaplo.Location = new Point(580, 73);
            lbNaplo.Name = "lbNaplo";
            lbNaplo.Size = new Size(208, 264);
            lbNaplo.TabIndex = 8;
            // 
            // atlagL
            // 
            atlagL.AutoSize = true;
            atlagL.Location = new Point(212, 408);
            atlagL.Name = "atlagL";
            atlagL.Size = new Size(105, 20);
            atlagL.TabIndex = 9;
            atlagL.Text = "Tanuló átlaga: ";
            // 
            // ujJegyN
            // 
            ujJegyN.Location = new Point(72, 181);
            ujJegyN.Name = "ujJegyN";
            ujJegyN.Size = new Size(150, 27);
            ujJegyN.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ujJegyN);
            Controls.Add(atlagL);
            Controls.Add(lbNaplo);
            Controls.Add(jegyN);
            Controls.Add(atlagSzamolasBTN);
            Controls.Add(jegyHozzadasaBTN);
            Controls.Add(ujTanuloHozzadasaBTN);
            Controls.Add(ujTantargyTB);
            Controls.Add(ujNevTB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)jegyN).EndInit();
            ((System.ComponentModel.ISupportInitialize)ujJegyN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ujNevTB;
        private TextBox ujTantargyTB;
        private Button ujTanuloHozzadasaBTN;
        private Button jegyHozzadasaBTN;
        private Button atlagSzamolasBTN;
        private NumericUpDown jegyN;
        private ListBox lbNaplo;
        private Label atlagL;
        private NumericUpDown ujJegyN;
    }
}
