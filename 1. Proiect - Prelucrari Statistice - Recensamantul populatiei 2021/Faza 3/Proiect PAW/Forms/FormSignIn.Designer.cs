namespace Proiect_PAW
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.labelInregistrare = new System.Windows.Forms.Label();
            this.gunaBtnCreareCont = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaTbNume = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Parola = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaCkAcord = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.labelTermeniConditii = new System.Windows.Forms.Label();
            this.gunaBtnAnulare = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ImageCheckBox3 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2ImageCheckBox2 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gunaImgBtnX = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TbAtentionare = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaTbAcord = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // labelInregistrare
            // 
            this.labelInregistrare.AutoSize = true;
            this.labelInregistrare.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInregistrare.Location = new System.Drawing.Point(65, 34);
            this.labelInregistrare.Name = "labelInregistrare";
            this.labelInregistrare.Size = new System.Drawing.Size(231, 54);
            this.labelInregistrare.TabIndex = 15;
            this.labelInregistrare.Text = "Inregistrare";
            // 
            // gunaBtnCreareCont
            // 
            this.gunaBtnCreareCont.Animated = true;
            this.gunaBtnCreareCont.AutoRoundedCorners = true;
            this.gunaBtnCreareCont.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnCreareCont.BorderRadius = 32;
            this.gunaBtnCreareCont.CheckedState.Parent = this.gunaBtnCreareCont;
            this.gunaBtnCreareCont.CustomImages.Parent = this.gunaBtnCreareCont;
            this.gunaBtnCreareCont.FillColor = System.Drawing.Color.SlateBlue;
            this.gunaBtnCreareCont.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaBtnCreareCont.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaBtnCreareCont.ForeColor = System.Drawing.Color.White;
            this.gunaBtnCreareCont.HoverState.Parent = this.gunaBtnCreareCont;
            this.gunaBtnCreareCont.Location = new System.Drawing.Point(71, 547);
            this.gunaBtnCreareCont.Name = "gunaBtnCreareCont";
            this.gunaBtnCreareCont.ShadowDecoration.Parent = this.gunaBtnCreareCont;
            this.gunaBtnCreareCont.Size = new System.Drawing.Size(180, 66);
            this.gunaBtnCreareCont.TabIndex = 14;
            this.gunaBtnCreareCont.Text = "Creare cont!";
            this.gunaBtnCreareCont.UseTransparentBackground = true;
            this.gunaBtnCreareCont.Click += new System.EventHandler(this.gunaBtnCreareCont_Click);
            // 
            // gunaTbNume
            // 
            this.gunaTbNume.Animated = true;
            this.gunaTbNume.AutoRoundedCorners = true;
            this.gunaTbNume.BorderColor = System.Drawing.Color.SlateBlue;
            this.gunaTbNume.BorderRadius = 18;
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
            this.gunaTbNume.Location = new System.Drawing.Point(13, 172);
            this.gunaTbNume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbNume.Name = "gunaTbNume";
            this.gunaTbNume.PasswordChar = '\0';
            this.gunaTbNume.PlaceholderText = "Nume";
            this.gunaTbNume.SelectedText = "";
            this.gunaTbNume.ShadowDecoration.Parent = this.gunaTbNume;
            this.gunaTbNume.Size = new System.Drawing.Size(269, 38);
            this.gunaTbNume.TabIndex = 12;
            this.gunaTbNume.TextChanged += new System.EventHandler(this.gunaTbNume_TextChanged);
            // 
            // guna2Email
            // 
            this.guna2Email.Animated = true;
            this.guna2Email.AutoRoundedCorners = true;
            this.guna2Email.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2Email.BorderRadius = 18;
            this.guna2Email.BorderThickness = 2;
            this.guna2Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Email.DefaultText = "";
            this.guna2Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Email.DisabledState.Parent = this.guna2Email;
            this.guna2Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Email.FocusedState.Parent = this.guna2Email;
            this.guna2Email.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Email.HoverState.Parent = this.guna2Email;
            this.guna2Email.Location = new System.Drawing.Point(13, 237);
            this.guna2Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Email.Name = "guna2Email";
            this.guna2Email.PasswordChar = '\0';
            this.guna2Email.PlaceholderText = "Email";
            this.guna2Email.SelectedText = "";
            this.guna2Email.ShadowDecoration.Parent = this.guna2Email;
            this.guna2Email.Size = new System.Drawing.Size(269, 38);
            this.guna2Email.TabIndex = 17;
            this.guna2Email.TextChanged += new System.EventHandler(this.guna2Email_TextChanged);
            // 
            // guna2Parola
            // 
            this.guna2Parola.Animated = true;
            this.guna2Parola.AutoRoundedCorners = true;
            this.guna2Parola.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2Parola.BorderRadius = 18;
            this.guna2Parola.BorderThickness = 2;
            this.guna2Parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Parola.DefaultText = "";
            this.guna2Parola.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2Parola.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2Parola.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Parola.DisabledState.Parent = this.guna2Parola;
            this.guna2Parola.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Parola.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Parola.FocusedState.Parent = this.guna2Parola;
            this.guna2Parola.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Parola.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Parola.HoverState.Parent = this.guna2Parola;
            this.guna2Parola.Location = new System.Drawing.Point(12, 307);
            this.guna2Parola.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Parola.Name = "guna2Parola";
            this.guna2Parola.PasswordChar = '\0';
            this.guna2Parola.PlaceholderText = "Parola";
            this.guna2Parola.SelectedText = "";
            this.guna2Parola.ShadowDecoration.Parent = this.guna2Parola;
            this.guna2Parola.Size = new System.Drawing.Size(269, 38);
            this.guna2Parola.TabIndex = 18;
            this.guna2Parola.TextChanged += new System.EventHandler(this.guna2Parola_TextChanged);
            // 
            // gunaCkAcord
            // 
            this.gunaCkAcord.CheckedState.BorderColor = System.Drawing.Color.SlateBlue;
            this.gunaCkAcord.CheckedState.BorderRadius = 5;
            this.gunaCkAcord.CheckedState.BorderThickness = 0;
            this.gunaCkAcord.CheckedState.FillColor = System.Drawing.Color.SlateBlue;
            this.gunaCkAcord.CheckedState.Parent = this.gunaCkAcord;
            this.gunaCkAcord.CheckMarkColor = System.Drawing.Color.SlateBlue;
            this.gunaCkAcord.Location = new System.Drawing.Point(12, 395);
            this.gunaCkAcord.Name = "gunaCkAcord";
            this.gunaCkAcord.ShadowDecoration.Parent = this.gunaCkAcord;
            this.gunaCkAcord.Size = new System.Drawing.Size(20, 21);
            this.gunaCkAcord.TabIndex = 19;
            this.gunaCkAcord.UncheckedState.BorderColor = System.Drawing.Color.SlateBlue;
            this.gunaCkAcord.UncheckedState.BorderRadius = 5;
            this.gunaCkAcord.UncheckedState.BorderThickness = 0;
            this.gunaCkAcord.UncheckedState.FillColor = System.Drawing.Color.White;
            this.gunaCkAcord.UncheckedState.Parent = this.gunaCkAcord;
            // 
            // labelTermeniConditii
            // 
            this.labelTermeniConditii.AutoSize = true;
            this.labelTermeniConditii.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTermeniConditii.Location = new System.Drawing.Point(30, 395);
            this.labelTermeniConditii.Name = "labelTermeniConditii";
            this.labelTermeniConditii.Size = new System.Drawing.Size(252, 19);
            this.labelTermeniConditii.TabIndex = 20;
            this.labelTermeniConditii.Text = "Sunt de acord cu termenii si conditiile!";
            // 
            // gunaBtnAnulare
            // 
            this.gunaBtnAnulare.Animated = true;
            this.gunaBtnAnulare.AutoRoundedCorners = true;
            this.gunaBtnAnulare.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnAnulare.BorderColor = System.Drawing.Color.SlateBlue;
            this.gunaBtnAnulare.BorderRadius = 32;
            this.gunaBtnAnulare.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaBtnAnulare.BorderThickness = 2;
            this.gunaBtnAnulare.CheckedState.Parent = this.gunaBtnAnulare;
            this.gunaBtnAnulare.CustomImages.Parent = this.gunaBtnAnulare;
            this.gunaBtnAnulare.FillColor = System.Drawing.Color.Transparent;
            this.gunaBtnAnulare.FillColor2 = System.Drawing.Color.Transparent;
            this.gunaBtnAnulare.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnAnulare.ForeColor = System.Drawing.Color.SlateBlue;
            this.gunaBtnAnulare.HoverState.Parent = this.gunaBtnAnulare;
            this.gunaBtnAnulare.Location = new System.Drawing.Point(71, 625);
            this.gunaBtnAnulare.Name = "gunaBtnAnulare";
            this.gunaBtnAnulare.ShadowDecoration.Parent = this.gunaBtnAnulare;
            this.gunaBtnAnulare.Size = new System.Drawing.Size(180, 66);
            this.gunaBtnAnulare.TabIndex = 21;
            this.gunaBtnAnulare.Text = "Anulare!";
            this.gunaBtnAnulare.UseTransparentBackground = true;
            this.gunaBtnAnulare.Click += new System.EventHandler(this.gunaBtnAnulare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // guna2ImageCheckBox3
            // 
            this.guna2ImageCheckBox3.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.guna2ImageCheckBox3.CheckedState.Parent = this.guna2ImageCheckBox3;
            this.guna2ImageCheckBox3.HoverState.Parent = this.guna2ImageCheckBox3;
            this.guna2ImageCheckBox3.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.guna2ImageCheckBox3.IndicateFocus = false;
            this.guna2ImageCheckBox3.Location = new System.Drawing.Point(283, 307);
            this.guna2ImageCheckBox3.Name = "guna2ImageCheckBox3";
            this.guna2ImageCheckBox3.PressedState.Parent = this.guna2ImageCheckBox3;
            this.guna2ImageCheckBox3.Size = new System.Drawing.Size(36, 38);
            this.guna2ImageCheckBox3.TabIndex = 24;
            // 
            // guna2ImageCheckBox2
            // 
            this.guna2ImageCheckBox2.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.guna2ImageCheckBox2.CheckedState.Parent = this.guna2ImageCheckBox2;
            this.guna2ImageCheckBox2.HoverState.Parent = this.guna2ImageCheckBox2;
            this.guna2ImageCheckBox2.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.guna2ImageCheckBox2.IndicateFocus = false;
            this.guna2ImageCheckBox2.Location = new System.Drawing.Point(283, 237);
            this.guna2ImageCheckBox2.Name = "guna2ImageCheckBox2";
            this.guna2ImageCheckBox2.PressedState.Parent = this.guna2ImageCheckBox2;
            this.guna2ImageCheckBox2.Size = new System.Drawing.Size(36, 38);
            this.guna2ImageCheckBox2.TabIndex = 23;
            // 
            // guna2ImageCheckBox1
            // 
            this.guna2ImageCheckBox1.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.guna2ImageCheckBox1.CheckedState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.HoverState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.guna2ImageCheckBox1.IndicateFocus = false;
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(283, 172);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.PressedState.Parent = this.guna2ImageCheckBox1;
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(36, 38);
            this.guna2ImageCheckBox1.TabIndex = 22;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Proiect_PAW.Properties.Resources.bran2;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(325, -41);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(495, 800);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
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
            this.gunaImgBtnX.Location = new System.Drawing.Point(617, 0);
            this.gunaImgBtnX.Name = "gunaImgBtnX";
            this.gunaImgBtnX.PressedState.ImageSize = new System.Drawing.Size(30, 25);
            this.gunaImgBtnX.PressedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Size = new System.Drawing.Size(46, 43);
            this.gunaImgBtnX.TabIndex = 25;
            this.gunaImgBtnX.UseTransparentBackground = true;
            this.gunaImgBtnX.Click += new System.EventHandler(this.gunaImgBtnX_Click);
            // 
            // guna2TbAtentionare
            // 
            this.guna2TbAtentionare.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.guna2TbAtentionare.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TbAtentionare.DefaultText = "Ai mare grija la completarea casutelor!";
            this.guna2TbAtentionare.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TbAtentionare.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TbAtentionare.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TbAtentionare.DisabledState.Parent = this.guna2TbAtentionare;
            this.guna2TbAtentionare.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TbAtentionare.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.guna2TbAtentionare.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TbAtentionare.FocusedState.Parent = this.guna2TbAtentionare;
            this.guna2TbAtentionare.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TbAtentionare.ForeColor = System.Drawing.Color.Red;
            this.guna2TbAtentionare.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TbAtentionare.HoverState.Parent = this.guna2TbAtentionare;
            this.guna2TbAtentionare.Location = new System.Drawing.Point(27, 351);
            this.guna2TbAtentionare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TbAtentionare.Name = "guna2TbAtentionare";
            this.guna2TbAtentionare.PasswordChar = '\0';
            this.guna2TbAtentionare.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.guna2TbAtentionare.PlaceholderText = "";
            this.guna2TbAtentionare.SelectedText = "";
            this.guna2TbAtentionare.SelectionStart = 39;
            this.guna2TbAtentionare.ShadowDecoration.Parent = this.guna2TbAtentionare;
            this.guna2TbAtentionare.Size = new System.Drawing.Size(264, 41);
            this.guna2TbAtentionare.TabIndex = 27;
            this.guna2TbAtentionare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaTbAcord
            // 
            this.gunaTbAcord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.gunaTbAcord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTbAcord.DefaultText = "Trebuie sa fii de acrod cu termenii si conditiile!";
            this.gunaTbAcord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTbAcord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTbAcord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbAcord.DisabledState.Parent = this.gunaTbAcord;
            this.gunaTbAcord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbAcord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.gunaTbAcord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbAcord.FocusedState.Parent = this.gunaTbAcord;
            this.gunaTbAcord.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTbAcord.ForeColor = System.Drawing.Color.Red;
            this.gunaTbAcord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbAcord.HoverState.Parent = this.gunaTbAcord;
            this.gunaTbAcord.Location = new System.Drawing.Point(12, 434);
            this.gunaTbAcord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbAcord.Name = "gunaTbAcord";
            this.gunaTbAcord.PasswordChar = '\0';
            this.gunaTbAcord.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.gunaTbAcord.PlaceholderText = "";
            this.gunaTbAcord.SelectedText = "";
            this.gunaTbAcord.ShadowDecoration.Parent = this.gunaTbAcord;
            this.gunaTbAcord.Size = new System.Drawing.Size(300, 41);
            this.gunaTbAcord.TabIndex = 28;
            this.gunaTbAcord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(666, 703);
            this.Controls.Add(this.gunaTbAcord);
            this.Controls.Add(this.guna2TbAtentionare);
            this.Controls.Add(this.gunaImgBtnX);
            this.Controls.Add(this.guna2ImageCheckBox3);
            this.Controls.Add(this.guna2ImageCheckBox2);
            this.Controls.Add(this.guna2ImageCheckBox1);
            this.Controls.Add(this.gunaBtnAnulare);
            this.Controls.Add(this.labelTermeniConditii);
            this.Controls.Add(this.gunaCkAcord);
            this.Controls.Add(this.guna2Parola);
            this.Controls.Add(this.guna2Email);
            this.Controls.Add(this.labelInregistrare);
            this.Controls.Add(this.gunaBtnCreareCont);
            this.Controls.Add(this.gunaTbNume);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignIn";
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label labelInregistrare;
        private Guna.UI2.WinForms.Guna2GradientButton gunaBtnCreareCont;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbNume;
        private Guna.UI2.WinForms.Guna2TextBox guna2Parola;
        private Guna.UI2.WinForms.Guna2TextBox guna2Email;
        private Guna.UI2.WinForms.Guna2CustomCheckBox gunaCkAcord;
        private System.Windows.Forms.Label labelTermeniConditii;
        private Guna.UI2.WinForms.Guna2GradientButton gunaBtnAnulare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox3;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox2;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnX;
        private Guna.UI2.WinForms.Guna2TextBox guna2TbAtentionare;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbAcord;
    }
}