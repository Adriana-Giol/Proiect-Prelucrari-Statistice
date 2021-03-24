namespace Proiect
{
    partial class IntroducereShowForm
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
            this.tbDenumireShow = new System.Windows.Forms.TextBox();
            this.labelDenumireShow = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelCategorieVarsta = new System.Windows.Forms.Label();
            this.cbCategorieVarsta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbDenumireShow
            // 
            this.tbDenumireShow.Location = new System.Drawing.Point(299, 71);
            this.tbDenumireShow.Name = "tbDenumireShow";
            this.tbDenumireShow.Size = new System.Drawing.Size(167, 22);
            this.tbDenumireShow.TabIndex = 0;
            // 
            // labelDenumireShow
            // 
            this.labelDenumireShow.AutoSize = true;
            this.labelDenumireShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumireShow.Location = new System.Drawing.Point(79, 71);
            this.labelDenumireShow.Name = "labelDenumireShow";
            this.labelDenumireShow.Size = new System.Drawing.Size(120, 17);
            this.labelDenumireShow.TabIndex = 1;
            this.labelDenumireShow.Text = "Denumire Show";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(79, 111);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(49, 17);
            this.labelRating.TabIndex = 2;
            this.labelRating.Text = "Rating";
            // 
            // labelCategorieVarsta
            // 
            this.labelCategorieVarsta.AutoSize = true;
            this.labelCategorieVarsta.Location = new System.Drawing.Point(79, 150);
            this.labelCategorieVarsta.Name = "labelCategorieVarsta";
            this.labelCategorieVarsta.Size = new System.Drawing.Size(134, 17);
            this.labelCategorieVarsta.TabIndex = 3;
            this.labelCategorieVarsta.Text = "Categorie de Varsta";
            // 
            // cbCategorieVarsta
            // 
            this.cbCategorieVarsta.FormattingEnabled = true;
            this.cbCategorieVarsta.Items.AddRange(new object[] {
            "Public general",
            "Acordul parintilor (AP)",
            "12+",
            "15+ ",
            "18+",
            ""});
            this.cbCategorieVarsta.Location = new System.Drawing.Point(299, 147);
            this.cbCategorieVarsta.Name = "cbCategorieVarsta";
            this.cbCategorieVarsta.Size = new System.Drawing.Size(167, 24);
            this.cbCategorieVarsta.TabIndex = 4;
            // 
            // IntroducereShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCategorieVarsta);
            this.Controls.Add(this.labelCategorieVarsta);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelDenumireShow);
            this.Controls.Add(this.tbDenumireShow);
            this.Name = "IntroducereShowForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumireShow;
        private System.Windows.Forms.Label labelDenumireShow;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelCategorieVarsta;
        private System.Windows.Forms.ComboBox cbCategorieVarsta;
    }
}

