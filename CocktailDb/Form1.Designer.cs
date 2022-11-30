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
            this.SearchButton = new System.Windows.Forms.Button();
            this.CocktailDbHeading = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(583, 107);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(165, 48);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Click here to Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
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
            this.CocktailDbHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(119, 120);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(404, 22);
            this.SearchBar.TabIndex = 3;
            this.SearchBar.Text = "Enter any ingrediant, cocktail name";
            // 
            // CocktailDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 616);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.CocktailDbHeading);
            this.Controls.Add(this.SearchButton);
            this.Name = "CocktailDb";
            this.Text = "CocktailDb";
            this.Load += new System.EventHandler(this.CocktailDb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label CocktailDbHeading;
        private System.Windows.Forms.TextBox SearchBar;
    }
}

