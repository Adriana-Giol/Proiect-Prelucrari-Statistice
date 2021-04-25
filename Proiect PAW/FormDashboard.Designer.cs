namespace Proiect_PAW
{
    partial class FormDashboard
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gunaPannelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPanouPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaBtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnRecenzori = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnRecenzati = new Guna.UI2.WinForms.Guna2Button();
            this.labelRecensamantulPopulatiei = new System.Windows.Forms.Label();
            this.gunaImgBtnX = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_PanouRecenzati1 = new Proiect_PAW.UC_PanouRecenzati();
            this.guna2ShadowPanel3.SuspendLayout();
            this.gunaPannelContainer.SuspendLayout();
            this.gunaPanouPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.gunaPannelContainer);
            this.guna2ShadowPanel3.Controls.Add(this.gunaPanouPrincipal);
            this.guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(6, 25);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(1184, 666);
            this.guna2ShadowPanel3.TabIndex = 1;
            // 
            // gunaPannelContainer
            // 
            this.gunaPannelContainer.Controls.Add(this.uC_PanouRecenzati1);
            this.gunaPannelContainer.Location = new System.Drawing.Point(244, 6);
            this.gunaPannelContainer.Name = "gunaPannelContainer";
            this.gunaPannelContainer.ShadowDecoration.Parent = this.gunaPannelContainer;
            this.gunaPannelContainer.Size = new System.Drawing.Size(937, 657);
            this.gunaPannelContainer.TabIndex = 1;
            // 
            // gunaPanouPrincipal
            // 
            this.gunaPanouPrincipal.BackColor = System.Drawing.Color.Indigo;
            this.gunaPanouPrincipal.Controls.Add(this.gunaBtnLogout);
            this.gunaPanouPrincipal.Controls.Add(this.gunaBtnRecenzori);
            this.gunaPanouPrincipal.Controls.Add(this.gunaBtnHome);
            this.gunaPanouPrincipal.Controls.Add(this.gunaBtnRecenzati);
            this.gunaPanouPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanouPrincipal.Location = new System.Drawing.Point(0, 0);
            this.gunaPanouPrincipal.Name = "gunaPanouPrincipal";
            this.gunaPanouPrincipal.ShadowDecoration.Parent = this.gunaPanouPrincipal;
            this.gunaPanouPrincipal.Size = new System.Drawing.Size(251, 666);
            this.gunaPanouPrincipal.TabIndex = 0;
            // 
            // gunaBtnLogout
            // 
            this.gunaBtnLogout.Animated = true;
            this.gunaBtnLogout.AutoRoundedCorners = true;
            this.gunaBtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnLogout.BorderRadius = 33;
            this.gunaBtnLogout.CheckedState.Parent = this.gunaBtnLogout;
            this.gunaBtnLogout.CustomImages.Parent = this.gunaBtnLogout;
            this.gunaBtnLogout.FillColor = System.Drawing.Color.Indigo;
            this.gunaBtnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.gunaBtnLogout.ForeColor = System.Drawing.Color.White;
            this.gunaBtnLogout.HoverState.BorderColor = System.Drawing.Color.DarkMagenta;
            this.gunaBtnLogout.HoverState.FillColor = System.Drawing.Color.DarkMagenta;
            this.gunaBtnLogout.HoverState.Parent = this.gunaBtnLogout;
            this.gunaBtnLogout.Image = global::Proiect_PAW.Properties.Resources.logout;
            this.gunaBtnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBtnLogout.Location = new System.Drawing.Point(33, 545);
            this.gunaBtnLogout.Name = "gunaBtnLogout";
            this.gunaBtnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.gunaBtnLogout.ShadowDecoration.Parent = this.gunaBtnLogout;
            this.gunaBtnLogout.Size = new System.Drawing.Size(190, 68);
            this.gunaBtnLogout.TabIndex = 3;
            this.gunaBtnLogout.Text = "Ieșire";
            this.gunaBtnLogout.UseTransparentBackground = true;
            this.gunaBtnLogout.Click += new System.EventHandler(this.gunaBtnLogout_Click);
            // 
            // gunaBtnRecenzori
            // 
            this.gunaBtnRecenzori.Animated = true;
            this.gunaBtnRecenzori.AutoRoundedCorners = true;
            this.gunaBtnRecenzori.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnRecenzori.BorderRadius = 37;
            this.gunaBtnRecenzori.CheckedState.Parent = this.gunaBtnRecenzori;
            this.gunaBtnRecenzori.CustomImages.Parent = this.gunaBtnRecenzori;
            this.gunaBtnRecenzori.FillColor = System.Drawing.Color.Indigo;
            this.gunaBtnRecenzori.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.gunaBtnRecenzori.ForeColor = System.Drawing.Color.White;
            this.gunaBtnRecenzori.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.gunaBtnRecenzori.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.gunaBtnRecenzori.HoverState.FillColor = System.Drawing.Color.SkyBlue;
            this.gunaBtnRecenzori.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.gunaBtnRecenzori.HoverState.Parent = this.gunaBtnRecenzori;
            this.gunaBtnRecenzori.Image = global::Proiect_PAW.Properties.Resources.group;
            this.gunaBtnRecenzori.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBtnRecenzori.Location = new System.Drawing.Point(9, 380);
            this.gunaBtnRecenzori.Name = "gunaBtnRecenzori";
            this.gunaBtnRecenzori.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.gunaBtnRecenzori.ShadowDecoration.Parent = this.gunaBtnRecenzori;
            this.gunaBtnRecenzori.Size = new System.Drawing.Size(275, 76);
            this.gunaBtnRecenzori.TabIndex = 2;
            this.gunaBtnRecenzori.Text = "Recenzori";
            this.gunaBtnRecenzori.UseTransparentBackground = true;
            this.gunaBtnRecenzori.Click += new System.EventHandler(this.gunaBtnRecenzori_Click);
            // 
            // gunaBtnHome
            // 
            this.gunaBtnHome.Animated = true;
            this.gunaBtnHome.AutoRoundedCorners = true;
            this.gunaBtnHome.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnHome.BorderRadius = 37;
            this.gunaBtnHome.CheckedState.Parent = this.gunaBtnHome;
            this.gunaBtnHome.CustomImages.Parent = this.gunaBtnHome;
            this.gunaBtnHome.FillColor = System.Drawing.Color.Indigo;
            this.gunaBtnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnHome.ForeColor = System.Drawing.Color.White;
            this.gunaBtnHome.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.gunaBtnHome.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.gunaBtnHome.HoverState.Parent = this.gunaBtnHome;
            this.gunaBtnHome.Image = global::Proiect_PAW.Properties.Resources.house;
            this.gunaBtnHome.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBtnHome.Location = new System.Drawing.Point(9, 200);
            this.gunaBtnHome.Name = "gunaBtnHome";
            this.gunaBtnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.gunaBtnHome.ShadowDecoration.Parent = this.gunaBtnHome;
            this.gunaBtnHome.Size = new System.Drawing.Size(266, 76);
            this.gunaBtnHome.TabIndex = 0;
            this.gunaBtnHome.Text = "Acasa";
            this.gunaBtnHome.UseTransparentBackground = true;
            this.gunaBtnHome.Click += new System.EventHandler(this.gunaBtnHome_Click);
            // 
            // gunaBtnRecenzati
            // 
            this.gunaBtnRecenzati.Animated = true;
            this.gunaBtnRecenzati.AutoRoundedCorners = true;
            this.gunaBtnRecenzati.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnRecenzati.BorderColor = System.Drawing.Color.Indigo;
            this.gunaBtnRecenzati.BorderRadius = 37;
            this.gunaBtnRecenzati.CheckedState.Parent = this.gunaBtnRecenzati;
            this.gunaBtnRecenzati.CustomImages.Parent = this.gunaBtnRecenzati;
            this.gunaBtnRecenzati.FillColor = System.Drawing.Color.Indigo;
            this.gunaBtnRecenzati.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.gunaBtnRecenzati.ForeColor = System.Drawing.Color.White;
            this.gunaBtnRecenzati.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.gunaBtnRecenzati.HoverState.CustomBorderColor = System.Drawing.Color.Orange;
            this.gunaBtnRecenzati.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.gunaBtnRecenzati.HoverState.ForeColor = System.Drawing.Color.Gold;
            this.gunaBtnRecenzati.HoverState.Parent = this.gunaBtnRecenzati;
            this.gunaBtnRecenzati.Image = global::Proiect_PAW.Properties.Resources.search;
            this.gunaBtnRecenzati.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBtnRecenzati.Location = new System.Drawing.Point(9, 290);
            this.gunaBtnRecenzati.Name = "gunaBtnRecenzati";
            this.gunaBtnRecenzati.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.gunaBtnRecenzati.ShadowDecoration.Parent = this.gunaBtnRecenzati;
            this.gunaBtnRecenzati.Size = new System.Drawing.Size(275, 76);
            this.gunaBtnRecenzati.TabIndex = 1;
            this.gunaBtnRecenzati.Text = "Recenzați";
            this.gunaBtnRecenzati.UseTransparentBackground = true;
            this.gunaBtnRecenzati.Click += new System.EventHandler(this.gunaBtnRecenzati_Click);
            // 
            // labelRecensamantulPopulatiei
            // 
            this.labelRecensamantulPopulatiei.AutoSize = true;
            this.labelRecensamantulPopulatiei.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecensamantulPopulatiei.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRecensamantulPopulatiei.Location = new System.Drawing.Point(20, 5);
            this.labelRecensamantulPopulatiei.Name = "labelRecensamantulPopulatiei";
            this.labelRecensamantulPopulatiei.Size = new System.Drawing.Size(288, 20);
            this.labelRecensamantulPopulatiei.TabIndex = 2;
            this.labelRecensamantulPopulatiei.Text = "Recensământul Populației României 2022";
            // 
            // gunaImgBtnX
            // 
            this.gunaImgBtnX.BackColor = System.Drawing.Color.Transparent;
            this.gunaImgBtnX.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImgBtnX.CheckedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.HoverState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Image = global::Proiect_PAW.Properties.Resources.exit;
            this.gunaImgBtnX.ImageRotate = 0F;
            this.gunaImgBtnX.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImgBtnX.Location = new System.Drawing.Point(1145, -4);
            this.gunaImgBtnX.Name = "gunaImgBtnX";
            this.gunaImgBtnX.PressedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Size = new System.Drawing.Size(27, 29);
            this.gunaImgBtnX.TabIndex = 10;
            this.gunaImgBtnX.UseTransparentBackground = true;
            this.gunaImgBtnX.Click += new System.EventHandler(this.gunaImgBtnX_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // uC_PanouRecenzati1
            // 
            this.uC_PanouRecenzati1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.uC_PanouRecenzati1.Location = new System.Drawing.Point(1, -6);
            this.uC_PanouRecenzati1.Name = "uC_PanouRecenzati1";
            this.uC_PanouRecenzati1.Size = new System.Drawing.Size(933, 657);
            this.uC_PanouRecenzati1.TabIndex = 0;
            // 
            // FormDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1196, 697);
            this.Controls.Add(this.gunaImgBtnX);
            this.Controls.Add(this.labelRecensamantulPopulatiei);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Padding = new System.Windows.Forms.Padding(6, 25, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.gunaPannelContainer.ResumeLayout(false);
            this.gunaPanouPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label labelRecensamantulPopulatiei;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnX;
        private Guna.UI2.WinForms.Guna2Panel gunaPanouPrincipal;
        private Guna.UI2.WinForms.Guna2Button gunaBtnRecenzori;
        private Guna.UI2.WinForms.Guna2Button gunaBtnHome;
        private Guna.UI2.WinForms.Guna2Button gunaBtnRecenzati;
        private Guna.UI2.WinForms.Guna2Panel gunaPannelContainer;
        private Guna.UI2.WinForms.Guna2Button gunaBtnLogout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UC_PanouRecenzati uC_PanouRecenzati1;
    }
}