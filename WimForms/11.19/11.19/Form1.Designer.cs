namespace _11._19
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
            lbFeladatkezelo = new ListBox();
            rendezesBTN = new Button();
            rendezesCB = new ComboBox();
            SuspendLayout();
            // 
            // lbFeladatkezelo
            // 
            lbFeladatkezelo.FormattingEnabled = true;
            lbFeladatkezelo.Location = new Point(516, 43);
            lbFeladatkezelo.Name = "lbFeladatkezelo";
            lbFeladatkezelo.Size = new Size(249, 244);
            lbFeladatkezelo.TabIndex = 0;
            lbFeladatkezelo.SelectedValueChanged += lbFeladatkezelo_SelectedValueChanged;
            // 
            // rendezesBTN
            // 
            rendezesBTN.Location = new Point(86, 245);
            rendezesBTN.Name = "rendezesBTN";
            rendezesBTN.Size = new Size(147, 42);
            rendezesBTN.TabIndex = 1;
            rendezesBTN.Text = "Rendezés";
            rendezesBTN.UseVisualStyleBackColor = true;
            rendezesBTN.Click += rendezesBTN_Click;
            // 
            // rendezesCB
            // 
            rendezesCB.AutoCompleteCustomSource.AddRange(new string[] { "Határidő", "Priorítás" });
            rendezesCB.FormattingEnabled = true;
            rendezesCB.Items.AddRange(new object[] { "Határidő", "Priorítás" });
            rendezesCB.Location = new Point(86, 174);
            rendezesCB.Name = "rendezesCB";
            rendezesCB.Size = new Size(151, 28);
            rendezesCB.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rendezesCB);
            Controls.Add(rendezesBTN);
            Controls.Add(lbFeladatkezelo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbFeladatkezelo;
        private Button rendezesBTN;
        private ComboBox rendezesCB;
    }
}
