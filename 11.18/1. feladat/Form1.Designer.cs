namespace _1._feladat
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
            lvTantargyjegyzek = new ListView();
            szerkesztesBTN = new Button();
            torlesBTN = new Button();
            keresesBTN = new Button();
            tanarNeveTB = new TextBox();
            SuspendLayout();
            // 
            // lvTantargyjegyzek
            // 
            lvTantargyjegyzek.Location = new Point(476, 30);
            lvTantargyjegyzek.Name = "lvTantargyjegyzek";
            lvTantargyjegyzek.Size = new Size(247, 337);
            lvTantargyjegyzek.TabIndex = 0;
            lvTantargyjegyzek.UseCompatibleStateImageBehavior = false;
            // 
            // szerkesztesBTN
            // 
            szerkesztesBTN.Location = new Point(75, 65);
            szerkesztesBTN.Name = "szerkesztesBTN";
            szerkesztesBTN.Size = new Size(150, 31);
            szerkesztesBTN.TabIndex = 1;
            szerkesztesBTN.Text = "Szerkesztés";
            szerkesztesBTN.UseVisualStyleBackColor = true;
            szerkesztesBTN.Click += szerkesztesBTN_Click;
            // 
            // torlesBTN
            // 
            torlesBTN.Location = new Point(75, 132);
            torlesBTN.Name = "torlesBTN";
            torlesBTN.Size = new Size(150, 33);
            torlesBTN.TabIndex = 2;
            torlesBTN.Text = "Törlés";
            torlesBTN.UseVisualStyleBackColor = true;
            torlesBTN.Click += torlesBTN_Click;
            // 
            // keresesBTN
            // 
            keresesBTN.Location = new Point(75, 310);
            keresesBTN.Name = "keresesBTN";
            keresesBTN.Size = new Size(150, 34);
            keresesBTN.TabIndex = 3;
            keresesBTN.Text = "Keresés";
            keresesBTN.UseVisualStyleBackColor = true;
            keresesBTN.Click += keresesBTN_Click;
            // 
            // tanarNeveTB
            // 
            tanarNeveTB.Location = new Point(44, 263);
            tanarNeveTB.Name = "tanarNeveTB";
            tanarNeveTB.Size = new Size(212, 27);
            tanarNeveTB.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tanarNeveTB);
            Controls.Add(keresesBTN);
            Controls.Add(torlesBTN);
            Controls.Add(szerkesztesBTN);
            Controls.Add(lvTantargyjegyzek);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvTantargyjegyzek;
        private Button szerkesztesBTN;
        private Button torlesBTN;
        private Button keresesBTN;
        private TextBox tanarNeveTB;
    }
}
