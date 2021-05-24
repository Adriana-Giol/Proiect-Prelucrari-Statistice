namespace Proiect_PAW.Forms
{
    partial class FormAddPers_Migrant
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPers_Migrant));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunaGbMigrant = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaBtnSalvare = new Guna.UI2.WinForms.Guna2Button();
            this.gunaaBtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.gunaTbAn = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNationalitate = new System.Windows.Forms.Label();
            this.labelDataNasterii = new System.Windows.Forms.Label();
            this.gunaTbNume = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaTbNationalitate = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTara = new System.Windows.Forms.Label();
            this.gunaImgBtnX = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaGbMigrant.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // gunaGbMigrant
            // 
            this.gunaGbMigrant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.gunaGbMigrant.BorderColor = System.Drawing.Color.DarkOrange;
            this.gunaGbMigrant.BorderRadius = 5;
            this.gunaGbMigrant.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.gunaGbMigrant.BorderThickness = 5;
            this.gunaGbMigrant.Controls.Add(this.gunaBtnSalvare);
            this.gunaGbMigrant.Controls.Add(this.gunaaBtnCancel);
            this.gunaGbMigrant.Controls.Add(this.gunaTbAn);
            this.gunaGbMigrant.Controls.Add(this.labelNationalitate);
            this.gunaGbMigrant.Controls.Add(this.labelDataNasterii);
            this.gunaGbMigrant.Controls.Add(this.gunaTbNume);
            this.gunaGbMigrant.Controls.Add(this.gunaTbNationalitate);
            this.gunaGbMigrant.Controls.Add(this.labelTara);
            this.gunaGbMigrant.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.gunaGbMigrant.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gunaGbMigrant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.gunaGbMigrant.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGbMigrant.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaGbMigrant.Location = new System.Drawing.Point(29, 33);
            this.gunaGbMigrant.Name = "gunaGbMigrant";
            this.gunaGbMigrant.ShadowDecoration.Parent = this.gunaGbMigrant;
            this.gunaGbMigrant.Size = new System.Drawing.Size(361, 470);
            this.gunaGbMigrant.TabIndex = 0;
            this.gunaGbMigrant.Text = "Persoana Migrantă";
            this.gunaGbMigrant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaBtnSalvare
            // 
            this.gunaBtnSalvare.Animated = true;
            this.gunaBtnSalvare.AutoRoundedCorners = true;
            this.gunaBtnSalvare.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnSalvare.BorderColor = System.Drawing.Color.Orange;
            this.gunaBtnSalvare.BorderRadius = 30;
            this.gunaBtnSalvare.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaBtnSalvare.BorderThickness = 2;
            this.gunaBtnSalvare.CheckedState.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.CustomImages.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.FillColor = System.Drawing.Color.Gold;
            this.gunaBtnSalvare.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaBtnSalvare.ForeColor = System.Drawing.Color.Black;
            this.gunaBtnSalvare.HoverState.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaBtnSalvare.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaBtnSalvare.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaBtnSalvare.Location = new System.Drawing.Point(202, 375);
            this.gunaBtnSalvare.Name = "gunaBtnSalvare";
            this.gunaBtnSalvare.ShadowDecoration.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.Size = new System.Drawing.Size(142, 63);
            this.gunaBtnSalvare.TabIndex = 40;
            this.gunaBtnSalvare.Text = "Salvare";
            this.gunaBtnSalvare.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBtnSalvare.UseTransparentBackground = true;
            this.gunaBtnSalvare.Click += new System.EventHandler(this.gunaBtnSalvare_Click);
            // 
            // gunaaBtnCancel
            // 
            this.gunaaBtnCancel.Animated = true;
            this.gunaaBtnCancel.AutoRoundedCorners = true;
            this.gunaaBtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.gunaaBtnCancel.BorderColor = System.Drawing.Color.Orange;
            this.gunaaBtnCancel.BorderRadius = 30;
            this.gunaaBtnCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaaBtnCancel.BorderThickness = 2;
            this.gunaaBtnCancel.CheckedState.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.CustomImages.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.FillColor = System.Drawing.Color.Gold;
            this.gunaaBtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaaBtnCancel.ForeColor = System.Drawing.Color.Black;
            this.gunaaBtnCancel.HoverState.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.Image = global::Proiect_PAW.Properties.Resources.cancel;
            this.gunaaBtnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaaBtnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaaBtnCancel.Location = new System.Drawing.Point(16, 375);
            this.gunaaBtnCancel.Name = "gunaaBtnCancel";
            this.gunaaBtnCancel.ShadowDecoration.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.Size = new System.Drawing.Size(152, 63);
            this.gunaaBtnCancel.TabIndex = 39;
            this.gunaaBtnCancel.Text = "Anulare";
            this.gunaaBtnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaaBtnCancel.UseTransparentBackground = true;
            this.gunaaBtnCancel.Click += new System.EventHandler(this.gunaaBtnCancel_Click);
            // 
            // gunaTbAn
            // 
            this.gunaTbAn.Animated = true;
            this.gunaTbAn.AutoRoundedCorners = true;
            this.gunaTbAn.BorderColor = System.Drawing.Color.Gold;
            this.gunaTbAn.BorderRadius = 19;
            this.gunaTbAn.BorderThickness = 2;
            this.gunaTbAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTbAn.DefaultText = "";
            this.gunaTbAn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTbAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTbAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbAn.DisabledState.Parent = this.gunaTbAn;
            this.gunaTbAn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbAn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbAn.FocusedState.Parent = this.gunaTbAn;
            this.gunaTbAn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaTbAn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbAn.HoverState.Parent = this.gunaTbAn;
            this.gunaTbAn.Location = new System.Drawing.Point(68, 183);
            this.gunaTbAn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbAn.Name = "gunaTbAn";
            this.gunaTbAn.PasswordChar = '\0';
            this.gunaTbAn.PlaceholderText = "An Migrare";
            this.gunaTbAn.SelectedText = "";
            this.gunaTbAn.ShadowDecoration.Parent = this.gunaTbAn;
            this.gunaTbAn.Size = new System.Drawing.Size(250, 40);
            this.gunaTbAn.TabIndex = 38;
            // 
            // labelNationalitate
            // 
            this.labelNationalitate.AutoSize = true;
            this.labelNationalitate.BackColor = System.Drawing.Color.Transparent;
            this.labelNationalitate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationalitate.Location = new System.Drawing.Point(113, 261);
            this.labelNationalitate.Name = "labelNationalitate";
            this.labelNationalitate.Size = new System.Drawing.Size(83, 19);
            this.labelNationalitate.TabIndex = 37;
            this.labelNationalitate.Text = "3. Cetățenie";
            // 
            // labelDataNasterii
            // 
            this.labelDataNasterii.AutoSize = true;
            this.labelDataNasterii.BackColor = System.Drawing.Color.Transparent;
            this.labelDataNasterii.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNasterii.Location = new System.Drawing.Point(113, 161);
            this.labelDataNasterii.Name = "labelDataNasterii";
            this.labelDataNasterii.Size = new System.Drawing.Size(107, 19);
            this.labelDataNasterii.TabIndex = 36;
            this.labelDataNasterii.Text = "2. Anul Migrării";
            // 
            // gunaTbNume
            // 
            this.gunaTbNume.Animated = true;
            this.gunaTbNume.AutoRoundedCorners = true;
            this.gunaTbNume.BorderColor = System.Drawing.Color.Gold;
            this.gunaTbNume.BorderRadius = 19;
            this.gunaTbNume.BorderThickness = 2;
            this.gunaTbNume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTbNume.DefaultText = "";
            this.gunaTbNume.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTbNume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTbNume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbNume.DisabledState.Parent = this.gunaTbNume;
            this.gunaTbNume.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbNume.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbNume.FocusedState.Parent = this.gunaTbNume;
            this.gunaTbNume.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaTbNume.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbNume.HoverState.Parent = this.gunaTbNume;
            this.gunaTbNume.Location = new System.Drawing.Point(68, 100);
            this.gunaTbNume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbNume.Name = "gunaTbNume";
            this.gunaTbNume.PasswordChar = '\0';
            this.gunaTbNume.PlaceholderText = "Țară Migrare";
            this.gunaTbNume.SelectedText = "";
            this.gunaTbNume.ShadowDecoration.Parent = this.gunaTbNume;
            this.gunaTbNume.Size = new System.Drawing.Size(250, 40);
            this.gunaTbNume.TabIndex = 32;
            // 
            // gunaTbNationalitate
            // 
            this.gunaTbNationalitate.Animated = true;
            this.gunaTbNationalitate.AutoRoundedCorners = true;
            this.gunaTbNationalitate.BorderColor = System.Drawing.Color.Gold;
            this.gunaTbNationalitate.BorderRadius = 19;
            this.gunaTbNationalitate.BorderThickness = 2;
            this.gunaTbNationalitate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTbNationalitate.DefaultText = "";
            this.gunaTbNationalitate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTbNationalitate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTbNationalitate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbNationalitate.DisabledState.Parent = this.gunaTbNationalitate;
            this.gunaTbNationalitate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbNationalitate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbNationalitate.FocusedState.Parent = this.gunaTbNationalitate;
            this.gunaTbNationalitate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaTbNationalitate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbNationalitate.HoverState.Parent = this.gunaTbNationalitate;
            this.gunaTbNationalitate.Location = new System.Drawing.Point(68, 283);
            this.gunaTbNationalitate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbNationalitate.Name = "gunaTbNationalitate";
            this.gunaTbNationalitate.PasswordChar = '\0';
            this.gunaTbNationalitate.PlaceholderText = "Cetatenie";
            this.gunaTbNationalitate.SelectedText = "";
            this.gunaTbNationalitate.ShadowDecoration.Parent = this.gunaTbNationalitate;
            this.gunaTbNationalitate.Size = new System.Drawing.Size(250, 40);
            this.gunaTbNationalitate.TabIndex = 33;
            // 
            // labelTara
            // 
            this.labelTara.AutoSize = true;
            this.labelTara.BackColor = System.Drawing.Color.Transparent;
            this.labelTara.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTara.Location = new System.Drawing.Point(113, 78);
            this.labelTara.Name = "labelTara";
            this.labelTara.Size = new System.Drawing.Size(102, 19);
            this.labelTara.TabIndex = 35;
            this.labelTara.Text = "1. Țară Migrare";
            // 
            // gunaImgBtnX
            // 
            this.gunaImgBtnX.BackColor = System.Drawing.Color.Transparent;
            this.gunaImgBtnX.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImgBtnX.CheckedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImgBtnX.HoverState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Image = global::Proiect_PAW.Properties.Resources.cancel;
            this.gunaImgBtnX.ImageRotate = 0F;
            this.gunaImgBtnX.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImgBtnX.Location = new System.Drawing.Point(368, -2);
            this.gunaImgBtnX.Name = "gunaImgBtnX";
            this.gunaImgBtnX.PressedState.ImageSize = new System.Drawing.Size(30, 25);
            this.gunaImgBtnX.PressedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Size = new System.Drawing.Size(38, 39);
            this.gunaImgBtnX.TabIndex = 12;
            this.gunaImgBtnX.UseTransparentBackground = true;
            this.gunaImgBtnX.Click += new System.EventHandler(this.gunaImgBtnX_Click);
            // 
            // FormAddPers_Migrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(419, 534);
            this.Controls.Add(this.gunaImgBtnX);
            this.Controls.Add(this.gunaGbMigrant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddPers_Migrant";
            this.Padding = new System.Windows.Forms.Padding(10, 35, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddPers_Migrant";
            this.gunaGbMigrant.ResumeLayout(false);
            this.gunaGbMigrant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox gunaGbMigrant;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnX;
        private System.Windows.Forms.Label labelNationalitate;
        private System.Windows.Forms.Label labelDataNasterii;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbNume;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbNationalitate;
        private System.Windows.Forms.Label labelTara;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbAn;
        private Guna.UI2.WinForms.Guna2Button gunaaBtnCancel;
        private Guna.UI2.WinForms.Guna2Button gunaBtnSalvare;
    }
}