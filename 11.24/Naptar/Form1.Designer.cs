namespace Naptar
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
            lbEvents = new ListBox();
            tbTitle = new TextBox();
            tbDescription = new TextBox();
            dateTimePicker = new DateTimePicker();
            btnAdd = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dateTimePickerSearch = new DateTimePicker();
            SuspendLayout();
            // 
            // lbEvents
            // 
            lbEvents.FormattingEnabled = true;
            lbEvents.Location = new Point(471, 28);
            lbEvents.Name = "lbEvents";
            lbEvents.Size = new Size(303, 304);
            lbEvents.TabIndex = 0;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(43, 51);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(125, 27);
            tbTitle.TabIndex = 1;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(43, 117);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(125, 27);
            tbDescription.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(43, 84);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(55, 201);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 5;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(55, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(578, 409);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePickerSearch
            // 
            dateTimePickerSearch.Location = new Point(513, 358);
            dateTimePickerSearch.Name = "dateTimePickerSearch";
            dateTimePickerSearch.Size = new Size(250, 27);
            dateTimePickerSearch.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker);
            Controls.Add(tbDescription);
            Controls.Add(tbTitle);
            Controls.Add(lbEvents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbEvents;
        private TextBox tbTitle;
        private TextBox tbDescription;
        private DateTimePicker dateTimePicker;
        private Button btnAdd;
        private Button btnModify;
        private Button btnDelete;
        private Button btnSearch;
        private DateTimePicker dateTimePickerSearch;
    }
}
