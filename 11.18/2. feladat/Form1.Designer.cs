namespace _2._feladat
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
            tetelNeveTB = new TextBox();
            tetelMennyisegeN = new NumericUpDown();
            tetelegysegaraN = new NumericUpDown();
            addBTN = new Button();
            calculateBTN = new Button();
            lvBevasarloLista = new ListView();
            vegosszeglb = new Label();
            ((System.ComponentModel.ISupportInitialize)tetelMennyisegeN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tetelegysegaraN).BeginInit();
            SuspendLayout();
            // 
            // tetelNeveTB
            // 
            tetelNeveTB.Location = new Point(52, 47);
            tetelNeveTB.Name = "tetelNeveTB";
            tetelNeveTB.Size = new Size(125, 27);
            tetelNeveTB.TabIndex = 0;
            // 
            // tetelMennyisegeN
            // 
            tetelMennyisegeN.Location = new Point(52, 101);
            tetelMennyisegeN.Name = "tetelMennyisegeN";
            tetelMennyisegeN.Size = new Size(150, 27);
            tetelMennyisegeN.TabIndex = 1;
            // 
            // tetelegysegaraN
            // 
            tetelegysegaraN.Location = new Point(52, 166);
            tetelegysegaraN.Name = "tetelegysegaraN";
            tetelegysegaraN.Size = new Size(150, 27);
            tetelegysegaraN.TabIndex = 2;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(83, 242);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 3;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // calculateBTN
            // 
            calculateBTN.Location = new Point(83, 319);
            calculateBTN.Name = "calculateBTN";
            calculateBTN.Size = new Size(94, 29);
            calculateBTN.TabIndex = 4;
            calculateBTN.Text = "Calculate ";
            calculateBTN.UseVisualStyleBackColor = true;
            calculateBTN.Click += calculateBTN_Click;
            // 
            // lvBevasarloLista
            // 
            lvBevasarloLista.Location = new Point(426, 49);
            lvBevasarloLista.Name = "lvBevasarloLista";
            lvBevasarloLista.Size = new Size(243, 299);
            lvBevasarloLista.TabIndex = 5;
            lvBevasarloLista.UseCompatibleStateImageBehavior = false;
            // 
            // vegosszeglb
            // 
            vegosszeglb.AutoSize = true;
            vegosszeglb.Location = new Point(523, 367);
            vegosszeglb.Name = "vegosszeglb";
            vegosszeglb.Size = new Size(86, 20);
            vegosszeglb.TabIndex = 6;
            vegosszeglb.Text = "Végösszeg: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vegosszeglb);
            Controls.Add(lvBevasarloLista);
            Controls.Add(calculateBTN);
            Controls.Add(addBTN);
            Controls.Add(tetelegysegaraN);
            Controls.Add(tetelMennyisegeN);
            Controls.Add(tetelNeveTB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tetelMennyisegeN).EndInit();
            ((System.ComponentModel.ISupportInitialize)tetelegysegaraN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tetelNeveTB;
        private NumericUpDown tetelMennyisegeN;
        private NumericUpDown tetelegysegaraN;
        private Button addBTN;
        private Button calculateBTN;
        private ListView lvBevasarloLista;
        private Label vegosszeglb;
    }
}
