namespace Trello
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
            cbBoard = new ComboBox();
            btnAddBoard = new Button();
            lbStarted = new ListBox();
            lbProgress = new ListBox();
            lbDone = new ListBox();
            btnNewCard = new Button();
            btnMoveCard = new Button();
            tbTitle = new TextBox();
            tbDescription = new TextBox();
            tbNewBoardTitle = new TextBox();
            SuspendLayout();
            // 
            // cbBoard
            // 
            cbBoard.FormattingEnabled = true;
            cbBoard.Location = new Point(40, 35);
            cbBoard.Name = "cbBoard";
            cbBoard.Size = new Size(151, 28);
            cbBoard.TabIndex = 0;
            cbBoard.SelectedIndexChanged += cbBoard_SelectedIndexChanged;
            // 
            // btnAddBoard
            // 
            btnAddBoard.Location = new Point(40, 137);
            btnAddBoard.Name = "btnAddBoard";
            btnAddBoard.Size = new Size(151, 36);
            btnAddBoard.TabIndex = 1;
            btnAddBoard.Text = "Add board";
            btnAddBoard.UseVisualStyleBackColor = true;
            btnAddBoard.Click += btnAddBoard_Click;
            // 
            // lbStarted
            // 
            lbStarted.FormattingEnabled = true;
            lbStarted.HorizontalScrollbar = true;
            lbStarted.Location = new Point(255, 313);
            lbStarted.Name = "lbStarted";
            lbStarted.ScrollAlwaysVisible = true;
            lbStarted.Size = new Size(150, 244);
            lbStarted.TabIndex = 2;
            // 
            // lbProgress
            // 
            lbProgress.FormattingEnabled = true;
            lbProgress.HorizontalScrollbar = true;
            lbProgress.Location = new Point(473, 313);
            lbProgress.Name = "lbProgress";
            lbProgress.ScrollAlwaysVisible = true;
            lbProgress.Size = new Size(152, 244);
            lbProgress.TabIndex = 3;
            // 
            // lbDone
            // 
            lbDone.FormattingEnabled = true;
            lbDone.HorizontalScrollbar = true;
            lbDone.Location = new Point(699, 313);
            lbDone.Name = "lbDone";
            lbDone.ScrollAlwaysVisible = true;
            lbDone.Size = new Size(150, 244);
            lbDone.TabIndex = 4;
            // 
            // btnNewCard
            // 
            btnNewCard.Location = new Point(648, 153);
            btnNewCard.Name = "btnNewCard";
            btnNewCard.Size = new Size(94, 29);
            btnNewCard.TabIndex = 5;
            btnNewCard.Text = "New Card";
            btnNewCard.UseVisualStyleBackColor = true;
            btnNewCard.Click += btnNewCard_Click;
            // 
            // btnMoveCard
            // 
            btnMoveCard.Location = new Point(68, 313);
            btnMoveCard.Name = "btnMoveCard";
            btnMoveCard.Size = new Size(94, 29);
            btnMoveCard.TabIndex = 6;
            btnMoveCard.Text = "Move Card";
            btnMoveCard.UseVisualStyleBackColor = true;
            btnMoveCard.Click += btnMoveCard_Click;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(648, 32);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(125, 27);
            tbTitle.TabIndex = 7;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(648, 67);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(282, 69);
            tbDescription.TabIndex = 8;
            // 
            // tbNewBoardTitle
            // 
            tbNewBoardTitle.Location = new Point(40, 89);
            tbNewBoardTitle.Name = "tbNewBoardTitle";
            tbNewBoardTitle.Size = new Size(151, 27);
            tbNewBoardTitle.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 614);
            Controls.Add(tbNewBoardTitle);
            Controls.Add(tbDescription);
            Controls.Add(tbTitle);
            Controls.Add(btnMoveCard);
            Controls.Add(btnNewCard);
            Controls.Add(lbDone);
            Controls.Add(lbProgress);
            Controls.Add(lbStarted);
            Controls.Add(btnAddBoard);
            Controls.Add(cbBoard);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbBoard;
        private Button btnAddBoard;
        private ListBox lbStarted;
        private ListBox lbProgress;
        private ListBox lbDone;
        private Button btnNewCard;
        private Button btnMoveCard;
        private TextBox tbTitle;
        private TextBox tbDescription;
        private TextBox tbNewBoardTitle;
    }
}
