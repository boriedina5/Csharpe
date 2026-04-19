namespace beolvFormApp
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            BTNSearch = new Button();
            BTNOrder = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(469, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(292, 324);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // BTNSearch
            // 
            BTNSearch.Location = new Point(73, 93);
            BTNSearch.Name = "BTNSearch";
            BTNSearch.Size = new Size(94, 29);
            BTNSearch.TabIndex = 2;
            BTNSearch.Text = "Keresés";
            BTNSearch.UseVisualStyleBackColor = true;
            BTNSearch.Click += BTNSearch_Click;
            // 
            // BTNOrder
            // 
            BTNOrder.Location = new Point(136, 365);
            BTNOrder.Name = "BTNOrder";
            BTNOrder.Size = new Size(94, 29);
            BTNOrder.TabIndex = 3;
            BTNOrder.Text = "ABC";
            BTNOrder.UseVisualStyleBackColor = true;
            BTNOrder.Click += BTNOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNOrder);
            Controls.Add(BTNSearch);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button BTNSearch;
        private Button BTNOrder;
    }
}
