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
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.gunaImgBtnX = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelTermeniConditii = new System.Windows.Forms.Label();
            this.gunaBtnAnulare = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.labelInregistrare.Location = new System.Drawing.Point(46, 41);
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
            this.gunaBtnCreareCont.BorderRadius = 30;
            this.gunaBtnCreareCont.CheckedState.Parent = this.gunaBtnCreareCont;
            this.gunaBtnCreareCont.CustomImages.Parent = this.gunaBtnCreareCont;
            this.gunaBtnCreareCont.FillColor = System.Drawing.Color.SlateBlue;
            this.gunaBtnCreareCont.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaBtnCreareCont.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaBtnCreareCont.ForeColor = System.Drawing.Color.White;
            this.gunaBtnCreareCont.HoverState.Parent = this.gunaBtnCreareCont;
            this.gunaBtnCreareCont.Location = new System.Drawing.Point(71, 515);
            this.gunaBtnCreareCont.Name = "gunaBtnCreareCont";
            this.gunaBtnCreareCont.ShadowDecoration.Parent = this.gunaBtnCreareCont;
            this.gunaBtnCreareCont.Size = new System.Drawing.Size(180, 62);
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
            this.gunaTbNume.BorderRadius = 17;
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
            this.gunaTbNume.Location = new System.Drawing.Point(27, 164);
            this.gunaTbNume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbNume.Name = "gunaTbNume";
            this.gunaTbNume.PasswordChar = '\0';
            this.gunaTbNume.PlaceholderText = "Nume";
            this.gunaTbNume.SelectedText = "";
            this.gunaTbNume.ShadowDecoration.Parent = this.gunaTbNume;
            this.gunaTbNume.Size = new System.Drawing.Size(269, 36);
            this.gunaTbNume.TabIndex = 12;
            // 
            // guna2Email
            // 
            this.guna2Email.Animated = true;
            this.guna2Email.AutoRoundedCorners = true;
            this.guna2Email.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2Email.BorderRadius = 17;
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
            this.guna2Email.Location = new System.Drawing.Point(27, 223);
            this.guna2Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Email.Name = "guna2Email";
            this.guna2Email.PasswordChar = '\0';
            this.guna2Email.PlaceholderText = "Email";
            this.guna2Email.SelectedText = "";
            this.guna2Email.ShadowDecoration.Parent = this.guna2Email;
            this.guna2Email.Size = new System.Drawing.Size(269, 36);
            this.guna2Email.TabIndex = 17;
            // 
            // guna2Parola
            // 
            this.guna2Parola.Animated = true;
            this.guna2Parola.AutoRoundedCorners = true;
            this.guna2Parola.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2Parola.BorderRadius = 17;
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
            this.guna2Parola.Location = new System.Drawing.Point(27, 285);
            this.guna2Parola.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Parola.Name = "guna2Parola";
            this.guna2Parola.PasswordChar = '\0';
            this.guna2Parola.PlaceholderText = "Parola";
            this.guna2Parola.SelectedText = "";
            this.guna2Parola.ShadowDecoration.Parent = this.guna2Parola;
            this.guna2Parola.Size = new System.Drawing.Size(269, 36);
            this.guna2Parola.TabIndex = 18;
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 5;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2CustomCheckBox1.CheckedState.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.CheckMarkColor = System.Drawing.Color.SlateBlue;
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(27, 422);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.ShadowDecoration.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox1.TabIndex = 19;
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 5;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CustomCheckBox1.UncheckedState.Parent = this.guna2CustomCheckBox1;
            // 
            // gunaImgBtnX
            // 
            this.gunaImgBtnX.BackColor = System.Drawing.Color.Transparent;
            this.gunaImgBtnX.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImgBtnX.CheckedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImgBtnX.HoverState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Image = global::Proiect_PAW.Properties.Resources.exit;
            this.gunaImgBtnX.ImageRotate = 0F;
            this.gunaImgBtnX.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImgBtnX.Location = new System.Drawing.Point(588, 0);
            this.gunaImgBtnX.Name = "gunaImgBtnX";
            this.gunaImgBtnX.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImgBtnX.PressedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Size = new System.Drawing.Size(66, 54);
            this.gunaImgBtnX.TabIndex = 10;
            this.gunaImgBtnX.UseTransparentBackground = true;
            this.gunaImgBtnX.Click += new System.EventHandler(this.gunaImgBtnX_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Proiect_PAW.Properties.Resources.bran2;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(325, -39);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(495, 753);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // labelTermeniConditii
            // 
            this.labelTermeniConditii.AutoSize = true;
            this.labelTermeniConditii.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTermeniConditii.Location = new System.Drawing.Point(53, 423);
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
            this.gunaBtnAnulare.BorderRadius = 30;
            this.gunaBtnAnulare.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaBtnAnulare.BorderThickness = 2;
            this.gunaBtnAnulare.CheckedState.Parent = this.gunaBtnAnulare;
            this.gunaBtnAnulare.CustomImages.Parent = this.gunaBtnAnulare;
            this.gunaBtnAnulare.FillColor = System.Drawing.Color.Transparent;
            this.gunaBtnAnulare.FillColor2 = System.Drawing.Color.Transparent;
            this.gunaBtnAnulare.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnAnulare.ForeColor = System.Drawing.Color.SlateBlue;
            this.gunaBtnAnulare.HoverState.Parent = this.gunaBtnAnulare;
            this.gunaBtnAnulare.Location = new System.Drawing.Point(71, 588);
            this.gunaBtnAnulare.Name = "gunaBtnAnulare";
            this.gunaBtnAnulare.ShadowDecoration.Parent = this.gunaBtnAnulare;
            this.gunaBtnAnulare.Size = new System.Drawing.Size(180, 62);
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
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(666, 662);
            this.Controls.Add(this.gunaBtnAnulare);
            this.Controls.Add(this.labelTermeniConditii);
            this.Controls.Add(this.guna2CustomCheckBox1);
            this.Controls.Add(this.guna2Parola);
            this.Controls.Add(this.guna2Email);
            this.Controls.Add(this.labelInregistrare);
            this.Controls.Add(this.gunaBtnCreareCont);
            this.Controls.Add(this.gunaTbNume);
            this.Controls.Add(this.gunaImgBtnX);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnX;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label labelInregistrare;
        private Guna.UI2.WinForms.Guna2GradientButton gunaBtnCreareCont;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbNume;
        private Guna.UI2.WinForms.Guna2TextBox guna2Parola;
        private Guna.UI2.WinForms.Guna2TextBox guna2Email;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        private System.Windows.Forms.Label labelTermeniConditii;
        private Guna.UI2.WinForms.Guna2GradientButton gunaBtnAnulare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}