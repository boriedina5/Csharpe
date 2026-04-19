namespace RecipeApp
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
            lbIngredients = new ListBox();
            label1 = new Label();
            btnSaveIngredient = new Button();
            lbKamra = new Label();
            btnAddPantry = new Button();
            lbPantry = new ListBox();
            btnRemoveFromPantry = new Button();
            lbReceptek = new Label();
            lbAjanlasok = new Label();
            lbReceipes = new ListBox();
            btnAddReceipe = new Button();
            lbRecommendations = new ListBox();
            btnRefreshRecommendations = new Button();
            cbIngredients = new ComboBox();
            SuspendLayout();
            // 
            // lbIngredients
            // 
            lbIngredients.FormattingEnabled = true;
            lbIngredients.HorizontalExtent = 400;
            lbIngredients.HorizontalScrollbar = true;
            lbIngredients.Location = new Point(12, 59);
            lbIngredients.Name = "lbIngredients";
            lbIngredients.ScrollAlwaysVisible = true;
            lbIngredients.Size = new Size(150, 104);
            lbIngredients.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Hozzávalók";
            // 
            // btnSaveIngredient
            // 
            btnSaveIngredient.Location = new Point(168, 96);
            btnSaveIngredient.Name = "btnSaveIngredient";
            btnSaveIngredient.Size = new Size(146, 35);
            btnSaveIngredient.TabIndex = 2;
            btnSaveIngredient.Text = "Save Ingredint";
            btnSaveIngredient.UseVisualStyleBackColor = true;
            btnSaveIngredient.Click += btnSaveIngredient_Click;
            // 
            // lbKamra
            // 
            lbKamra.AutoSize = true;
            lbKamra.Location = new Point(23, 200);
            lbKamra.Name = "lbKamra";
            lbKamra.Size = new Size(52, 20);
            lbKamra.TabIndex = 4;
            lbKamra.Text = "Kamra";
            // 
            // btnAddPantry
            // 
            btnAddPantry.Location = new Point(23, 236);
            btnAddPantry.Name = "btnAddPantry";
            btnAddPantry.Size = new Size(139, 29);
            btnAddPantry.TabIndex = 5;
            btnAddPantry.Text = "Add to pantry";
            btnAddPantry.UseVisualStyleBackColor = true;
            btnAddPantry.Click += btnAddPantry_Click;
            // 
            // lbPantry
            // 
            lbPantry.FormattingEnabled = true;
            lbPantry.HorizontalExtent = 400;
            lbPantry.HorizontalScrollbar = true;
            lbPantry.Location = new Point(23, 284);
            lbPantry.Name = "lbPantry";
            lbPantry.ScrollAlwaysVisible = true;
            lbPantry.Size = new Size(150, 104);
            lbPantry.TabIndex = 6;
            // 
            // btnRemoveFromPantry
            // 
            btnRemoveFromPantry.Location = new Point(45, 407);
            btnRemoveFromPantry.Name = "btnRemoveFromPantry";
            btnRemoveFromPantry.Size = new Size(94, 29);
            btnRemoveFromPantry.TabIndex = 7;
            btnRemoveFromPantry.Text = "Remove from pantry";
            btnRemoveFromPantry.UseVisualStyleBackColor = true;
            btnRemoveFromPantry.Click += btnRemoveFromPantry_Click;
            // 
            // lbReceptek
            // 
            lbReceptek.AutoSize = true;
            lbReceptek.Location = new Point(514, 32);
            lbReceptek.Name = "lbReceptek";
            lbReceptek.Size = new Size(70, 20);
            lbReceptek.TabIndex = 8;
            lbReceptek.Text = "Receptek";
            // 
            // lbAjanlasok
            // 
            lbAjanlasok.AutoSize = true;
            lbAjanlasok.Location = new Point(514, 284);
            lbAjanlasok.Name = "lbAjanlasok";
            lbAjanlasok.Size = new Size(73, 20);
            lbAjanlasok.TabIndex = 9;
            lbAjanlasok.Text = "Ajánlások";
            // 
            // lbReceipes
            // 
            lbReceipes.FormattingEnabled = true;
            lbReceipes.HorizontalExtent = 400;
            lbReceipes.HorizontalScrollbar = true;
            lbReceipes.Location = new Point(514, 68);
            lbReceipes.Name = "lbReceipes";
            lbReceipes.ScrollAlwaysVisible = true;
            lbReceipes.Size = new Size(150, 104);
            lbReceipes.TabIndex = 10;
            // 
            // btnAddReceipe
            // 
            btnAddReceipe.Location = new Point(514, 191);
            btnAddReceipe.Name = "btnAddReceipe";
            btnAddReceipe.Size = new Size(94, 29);
            btnAddReceipe.TabIndex = 11;
            btnAddReceipe.Text = "Add recipe";
            btnAddReceipe.UseVisualStyleBackColor = true;
            btnAddReceipe.Click += btnAddReceipe_Click;
            // 
            // lbRecommendations
            // 
            lbRecommendations.FormattingEnabled = true;
            lbRecommendations.HorizontalExtent = 400;
            lbRecommendations.HorizontalScrollbar = true;
            lbRecommendations.Location = new Point(514, 322);
            lbRecommendations.Name = "lbRecommendations";
            lbRecommendations.ScrollAlwaysVisible = true;
            lbRecommendations.Size = new Size(150, 104);
            lbRecommendations.TabIndex = 12;
            // 
            // btnRefreshRecommendations
            // 
            btnRefreshRecommendations.Location = new Point(514, 447);
            btnRefreshRecommendations.Name = "btnRefreshRecommendations";
            btnRefreshRecommendations.Size = new Size(94, 29);
            btnRefreshRecommendations.TabIndex = 13;
            btnRefreshRecommendations.Text = "Refresh Recommendations";
            btnRefreshRecommendations.UseVisualStyleBackColor = true;
            btnRefreshRecommendations.Click += btnRefreshRecommendations_Click;
            // 
            // cbIngredients
            // 
            cbIngredients.FormattingEnabled = true;
            cbIngredients.Location = new Point(168, 59);
            cbIngredients.Name = "cbIngredients";
            cbIngredients.Size = new Size(151, 28);
            cbIngredients.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(cbIngredients);
            Controls.Add(btnRefreshRecommendations);
            Controls.Add(lbRecommendations);
            Controls.Add(btnAddReceipe);
            Controls.Add(lbReceipes);
            Controls.Add(lbAjanlasok);
            Controls.Add(lbReceptek);
            Controls.Add(btnRemoveFromPantry);
            Controls.Add(lbPantry);
            Controls.Add(btnAddPantry);
            Controls.Add(lbKamra);
            Controls.Add(btnSaveIngredient);
            Controls.Add(label1);
            Controls.Add(lbIngredients);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbIngredients;
        private Label label1;
        private Button btnSaveIngredient;
        private Label lbKamra;
        private Button btnAddPantry;
        private ListBox lbPantry;
        private Button btnRemoveFromPantry;
        private Label lbReceptek;
        private Label lbAjanlasok;
        private ListBox lbReceipes;
        private Button btnAddReceipe;
        private ListBox lbRecommendations;
        private Button btnRefreshRecommendations;
        private ComboBox cbIngredients;
    }
}
