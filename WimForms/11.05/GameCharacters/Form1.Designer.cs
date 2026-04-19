namespace GameCharacters
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
            lbCharacters = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            Hp = new NumericUpDown();
            Level = new NumericUpDown();
            Dmg = new NumericUpDown();
            EnergyOrMannaC = new NumericUpDown();
            MargeC = new CheckBox();
            EnergyOrMana = new Label();
            Gomb = new Button();
            Attack = new Button();
            ((System.ComponentModel.ISupportInitialize)Hp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dmg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnergyOrMannaC).BeginInit();
            SuspendLayout();
            // 
            // lbCharacters
            // 
            lbCharacters.FormattingEnabled = true;
            lbCharacters.Location = new Point(367, 33);
            lbCharacters.Name = "lbCharacters";
            lbCharacters.Size = new Size(393, 324);
            lbCharacters.TabIndex = 0;
            lbCharacters.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // Hp
            // 
            Hp.Location = new Point(27, 98);
            Hp.Name = "Hp";
            Hp.Size = new Size(150, 27);
            Hp.TabIndex = 3;
            // 
            // Level
            // 
            Level.Location = new Point(27, 151);
            Level.Name = "Level";
            Level.Size = new Size(150, 27);
            Level.TabIndex = 4;
            // 
            // Dmg
            // 
            Dmg.Location = new Point(27, 207);
            Dmg.Name = "Dmg";
            Dmg.Size = new Size(150, 27);
            Dmg.TabIndex = 5;
            // 
            // EnergyOrMannaC
            // 
            EnergyOrMannaC.Location = new Point(27, 330);
            EnergyOrMannaC.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            EnergyOrMannaC.Name = "EnergyOrMannaC";
            EnergyOrMannaC.Size = new Size(150, 27);
            EnergyOrMannaC.TabIndex = 6;
            // 
            // MargeC
            // 
            MargeC.AutoSize = true;
            MargeC.Location = new Point(27, 255);
            MargeC.Name = "MargeC";
            MargeC.Size = new Size(81, 24);
            MargeC.TabIndex = 7;
            MargeC.Text = "Marge?";
            MargeC.UseVisualStyleBackColor = true;
            // 
            // EnergyOrMana
            // 
            EnergyOrMana.AutoSize = true;
            EnergyOrMana.Location = new Point(194, 332);
            EnergyOrMana.Name = "EnergyOrMana";
            EnergyOrMana.Size = new Size(97, 20);
            EnergyOrMana.TabIndex = 8;
            EnergyOrMana.Text = "Energy/Mana";
            EnergyOrMana.Click += EnergyOrMana_Click;
            // 
            // Gomb
            // 
            Gomb.Location = new Point(131, 397);
            Gomb.Name = "Gomb";
            Gomb.Size = new Size(94, 29);
            Gomb.TabIndex = 9;
            Gomb.Text = "Submit";
            Gomb.UseVisualStyleBackColor = true;
            Gomb.Click += Gomb_Click;
            // 
            // Attack
            // 
            Attack.Location = new Point(508, 397);
            Attack.Name = "Attack";
            Attack.Size = new Size(94, 29);
            Attack.TabIndex = 10;
            Attack.Text = "Attack";
            Attack.UseVisualStyleBackColor = true;
            Attack.Click += Attack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Attack);
            Controls.Add(Gomb);
            Controls.Add(EnergyOrMana);
            Controls.Add(MargeC);
            Controls.Add(EnergyOrMannaC);
            Controls.Add(Dmg);
            Controls.Add(Level);
            Controls.Add(Hp);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lbCharacters);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Hp).EndInit();
            ((System.ComponentModel.ISupportInitialize)Level).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dmg).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnergyOrMannaC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCharacters;
        private TextBox textBox1;
        private Label label1;
        private NumericUpDown Hp;
        private NumericUpDown Level;
        private NumericUpDown Dmg;
        private NumericUpDown EnergyOrMannaC;
        private CheckBox MargeC;
        private Label EnergyOrMana;
        private Button Gomb;
        private Button Attack;
    }
}
