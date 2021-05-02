namespace Proiect_PAW.Forms
{
    partial class FormAddPers_Cultura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPers_Cultura));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelAcord = new System.Windows.Forms.Label();
            this.gunaGbOrientareSex = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelHomosexual = new System.Windows.Forms.Label();
            this.labelHeterosexual = new System.Windows.Forms.Label();
            this.gunaCkFemeie = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaCkBarbat = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaBtnSalvare = new Guna.UI2.WinForms.Guna2Button();
            this.labelLimba = new System.Windows.Forms.Label();
            this.gunaaBtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelReligie = new System.Windows.Forms.Label();
            this.labelEtnie = new System.Windows.Forms.Label();
            this.gunaTbNume = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaImgBtnX = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1.SuspendLayout();
            this.gunaGbOrientareSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2GroupBox1.BorderThickness = 5;
            this.guna2GroupBox1.Controls.Add(this.labelAcord);
            this.guna2GroupBox1.Controls.Add(this.gunaGbOrientareSex);
            this.guna2GroupBox1.Controls.Add(this.gunaBtnSalvare);
            this.guna2GroupBox1.Controls.Add(this.labelLimba);
            this.guna2GroupBox1.Controls.Add(this.gunaaBtnCancel);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox3);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox2);
            this.guna2GroupBox1.Controls.Add(this.labelReligie);
            this.guna2GroupBox1.Controls.Add(this.labelEtnie);
            this.guna2GroupBox1.Controls.Add(this.gunaTbNume);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2GroupBox1.Location = new System.Drawing.Point(23, 33);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(636, 423);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Identitate Culturală";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAcord
            // 
            this.labelAcord.AutoSize = true;
            this.labelAcord.BackColor = System.Drawing.Color.Transparent;
            this.labelAcord.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcord.ForeColor = System.Drawing.Color.Red;
            this.labelAcord.Location = new System.Drawing.Point(30, 35);
            this.labelAcord.Name = "labelAcord";
            this.labelAcord.Size = new System.Drawing.Size(552, 19);
            this.labelAcord.TabIndex = 46;
            this.labelAcord.Text = "* Acest formular se completează doar dacă persoana dorește să ofere aceste inform" +
    "ații!";
            // 
            // gunaGbOrientareSex
            // 
            this.gunaGbOrientareSex.AutoRoundedCorners = true;
            this.gunaGbOrientareSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.gunaGbOrientareSex.BorderColor = System.Drawing.Color.DarkOrange;
            this.gunaGbOrientareSex.BorderRadius = 81;
            this.gunaGbOrientareSex.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaGbOrientareSex.BorderThickness = 2;
            this.gunaGbOrientareSex.Controls.Add(this.labelHomosexual);
            this.gunaGbOrientareSex.Controls.Add(this.labelHeterosexual);
            this.gunaGbOrientareSex.Controls.Add(this.gunaCkFemeie);
            this.gunaGbOrientareSex.Controls.Add(this.gunaCkBarbat);
            this.gunaGbOrientareSex.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.gunaGbOrientareSex.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gunaGbOrientareSex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.gunaGbOrientareSex.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGbOrientareSex.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaGbOrientareSex.Location = new System.Drawing.Point(336, 121);
            this.gunaGbOrientareSex.Name = "gunaGbOrientareSex";
            this.gunaGbOrientareSex.ShadowDecoration.Parent = this.gunaGbOrientareSex;
            this.gunaGbOrientareSex.Size = new System.Drawing.Size(226, 164);
            this.gunaGbOrientareSex.TabIndex = 45;
            this.gunaGbOrientareSex.Text = "Orientare Sexuală";
            this.gunaGbOrientareSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHomosexual
            // 
            this.labelHomosexual.AutoSize = true;
            this.labelHomosexual.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomosexual.Location = new System.Drawing.Point(87, 109);
            this.labelHomosexual.Name = "labelHomosexual";
            this.labelHomosexual.Size = new System.Drawing.Size(86, 19);
            this.labelHomosexual.TabIndex = 15;
            this.labelHomosexual.Text = "Homosexual";
            // 
            // labelHeterosexual
            // 
            this.labelHeterosexual.AutoSize = true;
            this.labelHeterosexual.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeterosexual.Location = new System.Drawing.Point(87, 55);
            this.labelHeterosexual.Name = "labelHeterosexual";
            this.labelHeterosexual.Size = new System.Drawing.Size(90, 19);
            this.labelHeterosexual.TabIndex = 14;
            this.labelHeterosexual.Text = "Heterosexual";
            // 
            // gunaCkFemeie
            // 
            this.gunaCkFemeie.BackColor = System.Drawing.Color.Transparent;
            this.gunaCkFemeie.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaCkFemeie.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCkFemeie.CheckedState.Parent = this.gunaCkFemeie;
            this.gunaCkFemeie.HoverState.Parent = this.gunaCkFemeie;
            this.gunaCkFemeie.Image = global::Proiect_PAW.Properties.Resources.heterosexual;
            this.gunaCkFemeie.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCkFemeie.IndicateFocus = false;
            this.gunaCkFemeie.Location = new System.Drawing.Point(28, 41);
            this.gunaCkFemeie.Name = "gunaCkFemeie";
            this.gunaCkFemeie.PressedState.Parent = this.gunaCkFemeie;
            this.gunaCkFemeie.Size = new System.Drawing.Size(44, 47);
            this.gunaCkFemeie.TabIndex = 12;
            this.gunaCkFemeie.UseTransparentBackground = true;
            // 
            // gunaCkBarbat
            // 
            this.gunaCkBarbat.BackColor = System.Drawing.Color.Transparent;
            this.gunaCkBarbat.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaCkBarbat.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCkBarbat.CheckedState.Parent = this.gunaCkBarbat;
            this.gunaCkBarbat.HoverState.Parent = this.gunaCkBarbat;
            this.gunaCkBarbat.Image = global::Proiect_PAW.Properties.Resources.gay;
            this.gunaCkBarbat.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCkBarbat.IndicateFocus = false;
            this.gunaCkBarbat.Location = new System.Drawing.Point(28, 94);
            this.gunaCkBarbat.Name = "gunaCkBarbat";
            this.gunaCkBarbat.PressedState.Parent = this.gunaCkBarbat;
            this.gunaCkBarbat.Size = new System.Drawing.Size(44, 47);
            this.gunaCkBarbat.TabIndex = 13;
            this.gunaCkBarbat.UseTransparentBackground = true;
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
            this.gunaBtnSalvare.Location = new System.Drawing.Point(356, 334);
            this.gunaBtnSalvare.Name = "gunaBtnSalvare";
            this.gunaBtnSalvare.ShadowDecoration.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.Size = new System.Drawing.Size(180, 63);
            this.gunaBtnSalvare.TabIndex = 42;
            this.gunaBtnSalvare.Text = "Salvare";
            this.gunaBtnSalvare.UseTransparentBackground = true;
            // 
            // labelLimba
            // 
            this.labelLimba.AutoSize = true;
            this.labelLimba.BackColor = System.Drawing.Color.Transparent;
            this.labelLimba.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimba.Location = new System.Drawing.Point(38, 241);
            this.labelLimba.Name = "labelLimba";
            this.labelLimba.Size = new System.Drawing.Size(118, 19);
            this.labelLimba.TabIndex = 44;
            this.labelLimba.Text = "3. Limba Materna";
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
            this.gunaaBtnCancel.Location = new System.Drawing.Point(73, 334);
            this.gunaaBtnCancel.Name = "gunaaBtnCancel";
            this.gunaaBtnCancel.ShadowDecoration.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.Size = new System.Drawing.Size(180, 63);
            this.gunaaBtnCancel.TabIndex = 41;
            this.gunaaBtnCancel.Text = "Anulare";
            this.gunaaBtnCancel.UseTransparentBackground = true;
            this.gunaaBtnCancel.Click += new System.EventHandler(this.gunaaBtnCancel_Click);
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Animated = true;
            this.guna2TextBox3.AutoRoundedCorners = true;
            this.guna2TextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.guna2TextBox3.BorderColor = System.Drawing.Color.Gold;
            this.guna2TextBox3.BorderRadius = 19;
            this.guna2TextBox3.BorderThickness = 2;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(34, 272);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Limbă Maternă";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(250, 40);
            this.guna2TextBox3.TabIndex = 43;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.AutoRoundedCorners = true;
            this.guna2TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Gold;
            this.guna2TextBox2.BorderRadius = 19;
            this.guna2TextBox2.BorderThickness = 2;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(34, 185);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Religie";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(250, 40);
            this.guna2TextBox2.TabIndex = 41;
            // 
            // labelReligie
            // 
            this.labelReligie.AutoSize = true;
            this.labelReligie.BackColor = System.Drawing.Color.Transparent;
            this.labelReligie.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReligie.Location = new System.Drawing.Point(38, 153);
            this.labelReligie.Name = "labelReligie";
            this.labelReligie.Size = new System.Drawing.Size(67, 19);
            this.labelReligie.TabIndex = 40;
            this.labelReligie.Text = "2. Religie";
            // 
            // labelEtnie
            // 
            this.labelEtnie.AutoSize = true;
            this.labelEtnie.BackColor = System.Drawing.Color.Transparent;
            this.labelEtnie.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtnie.Location = new System.Drawing.Point(38, 66);
            this.labelEtnie.Name = "labelEtnie";
            this.labelEtnie.Size = new System.Drawing.Size(53, 19);
            this.labelEtnie.TabIndex = 38;
            this.labelEtnie.Text = "1. Etnie";
            // 
            // gunaTbNume
            // 
            this.gunaTbNume.Animated = true;
            this.gunaTbNume.AutoRoundedCorners = true;
            this.gunaTbNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
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
            this.gunaTbNume.Location = new System.Drawing.Point(42, 101);
            this.gunaTbNume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbNume.Name = "gunaTbNume";
            this.gunaTbNume.PasswordChar = '\0';
            this.gunaTbNume.PlaceholderText = "Etnie";
            this.gunaTbNume.SelectedText = "";
            this.gunaTbNume.ShadowDecoration.Parent = this.gunaTbNume;
            this.gunaTbNume.Size = new System.Drawing.Size(250, 40);
            this.gunaTbNume.TabIndex = 37;
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
            this.gunaImgBtnX.Location = new System.Drawing.Point(623, -2);
            this.gunaImgBtnX.Name = "gunaImgBtnX";
            this.gunaImgBtnX.PressedState.ImageSize = new System.Drawing.Size(30, 25);
            this.gunaImgBtnX.PressedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Size = new System.Drawing.Size(49, 41);
            this.gunaImgBtnX.TabIndex = 13;
            this.gunaImgBtnX.UseTransparentBackground = true;
            this.gunaImgBtnX.Click += new System.EventHandler(this.gunaImgBtnX_Click);
            // 
            // FormAddPers_Cultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(685, 478);
            this.Controls.Add(this.gunaImgBtnX);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddPers_Cultura";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identitate Culturala";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.gunaGbOrientareSex.ResumeLayout(false);
            this.gunaGbOrientareSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnX;
        private System.Windows.Forms.Label labelEtnie;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbNume;
        private System.Windows.Forms.Label labelLimba;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label labelReligie;
        private Guna.UI2.WinForms.Guna2Button gunaBtnSalvare;
        private Guna.UI2.WinForms.Guna2Button gunaaBtnCancel;
        private Guna.UI2.WinForms.Guna2GroupBox gunaGbOrientareSex;
        private System.Windows.Forms.Label labelHomosexual;
        private System.Windows.Forms.Label labelHeterosexual;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaCkFemeie;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaCkBarbat;
        private System.Windows.Forms.Label labelAcord;
    }
}