namespace FutasWinFormApp
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
            TbSearchByName = new TextBox();
            BtnSearch = new Button();
            BtnCFBP = new Button();
            BtnOrderByTime = new Button();
            btnDefaultView = new Button();
            lbContestant = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // TbSearchByName
            // 
            TbSearchByName.Location = new Point(36, 91);
            TbSearchByName.Name = "TbSearchByName";
            TbSearchByName.Size = new Size(125, 27);
            TbSearchByName.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(51, 124);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(94, 29);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Keresés";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnCFBP
            // 
            BtnCFBP.Location = new Point(36, 220);
            BtnCFBP.Name = "BtnCFBP";
            BtnCFBP.Size = new Size(173, 29);
            BtnCFBP.TabIndex = 3;
            BtnCFBP.Text = "Budapesti futók";
            BtnCFBP.UseVisualStyleBackColor = true;
            BtnCFBP.Click += BtnCFBP_Click;
            // 
            // BtnOrderByTime
            // 
            BtnOrderByTime.Location = new Point(36, 267);
            BtnOrderByTime.Name = "BtnOrderByTime";
            BtnOrderByTime.Size = new Size(173, 29);
            BtnOrderByTime.TabIndex = 4;
            BtnOrderByTime.Text = "Rendezés idő szerint";
            BtnOrderByTime.UseVisualStyleBackColor = true;
            BtnOrderByTime.Click += BtnOrderByTime_Click;
            // 
            // btnDefaultView
            // 
            btnDefaultView.Location = new Point(51, 311);
            btnDefaultView.Name = "btnDefaultView";
            btnDefaultView.Size = new Size(142, 29);
            btnDefaultView.TabIndex = 5;
            btnDefaultView.Text = "Összes adat";
            btnDefaultView.UseVisualStyleBackColor = true;
            btnDefaultView.Click += btnDefaultView_Click;
            // 
            // lbContestant
            // 
            lbContestant.FormattingEnabled = true;
            lbContestant.Location = new Point(434, 49);
            lbContestant.Name = "lbContestant";
            lbContestant.Size = new Size(311, 324);
            lbContestant.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 8;
            label1.Text = "Futóverseny eredmények";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 9;
            label2.Text = "Keresés név szerint";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 10;
            label3.Text = "Szűrés";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbContestant);
            Controls.Add(btnDefaultView);
            Controls.Add(BtnOrderByTime);
            Controls.Add(BtnCFBP);
            Controls.Add(BtnSearch);
            Controls.Add(TbSearchByName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox TbSearchByName;
        private Button BtnSearch;
        private Button BtnCFBP;
        private Button BtnOrderByTime;
        private Button btnDefaultView;
        private ListBox lbContestant;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
