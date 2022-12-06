namespace CocktailDb
{
    partial class CocktailDb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CocktailDbHeading = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchIngrediant = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CocktailDbHeading
            // 
            this.CocktailDbHeading.AutoSize = true;
            this.CocktailDbHeading.BackColor = System.Drawing.SystemColors.Control;
            this.CocktailDbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocktailDbHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CocktailDbHeading.Location = new System.Drawing.Point(309, 38);
            this.CocktailDbHeading.Name = "CocktailDbHeading";
            this.CocktailDbHeading.Size = new System.Drawing.Size(214, 32);
            this.CocktailDbHeading.TabIndex = 2;
            this.CocktailDbHeading.Text = "Cocktail DB API";
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(127, 117);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(359, 22);
            this.SearchBar.TabIndex = 3;
            this.SearchBar.Text = "Enter any cocktail name or ingrediant ";
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(558, 115);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 49);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search by Name";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchIngrediant
            // 
            this.SearchIngrediant.Enabled = false;
            this.SearchIngrediant.Location = new System.Drawing.Point(714, 115);
            this.SearchIngrediant.Name = "SearchIngrediant";
            this.SearchIngrediant.Size = new System.Drawing.Size(112, 49);
            this.SearchIngrediant.TabIndex = 5;
            this.SearchIngrediant.Text = "Search by Ingrediant";
            this.SearchIngrediant.UseVisualStyleBackColor = true;
            this.SearchIngrediant.Click += new System.EventHandler(this.SearchIngrediant_Click);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(795, 12);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(75, 46);
            this.Random.TabIndex = 6;
            this.Random.Text = "Random Cocktail";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // CocktailDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(890, 241);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.SearchIngrediant);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.CocktailDbHeading);
            this.Name = "CocktailDb";
            this.Text = "CocktailDb";
            this.Load += new System.EventHandler(this.CocktailDb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CocktailDbHeading;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SearchIngrediant;
        private System.Windows.Forms.Button Random;
    }
}

