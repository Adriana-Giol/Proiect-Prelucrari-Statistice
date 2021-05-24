namespace Proiect_PAW
{
    partial class UC_PanouAcasa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaImgBtnDashboard = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(172)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(8, 226);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Maroon;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(423, 414);
            this.guna2ShadowPanel2.TabIndex = 1;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Proiect_PAW.Properties.Resources._1zej_unscreen;
            this.guna2PictureBox2.Location = new System.Drawing.Point(431, 367);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(499, 273);
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            // 
            // gunaImgBtnDashboard
            // 
            this.gunaImgBtnDashboard.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImgBtnDashboard.CheckedState.Parent = this.gunaImgBtnDashboard;
            this.gunaImgBtnDashboard.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImgBtnDashboard.HoverState.Parent = this.gunaImgBtnDashboard;
            this.gunaImgBtnDashboard.Image = global::Proiect_PAW.Properties.Resources.arrrow;
            this.gunaImgBtnDashboard.ImageRotate = 0F;
            this.gunaImgBtnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImgBtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.gunaImgBtnDashboard.Name = "gunaImgBtnDashboard";
            this.gunaImgBtnDashboard.PressedState.ImageSize = new System.Drawing.Size(30, 25);
            this.gunaImgBtnDashboard.PressedState.Parent = this.gunaImgBtnDashboard;
            this.gunaImgBtnDashboard.Size = new System.Drawing.Size(48, 33);
            this.gunaImgBtnDashboard.TabIndex = 12;
            this.gunaImgBtnDashboard.Click += new System.EventHandler(this.gunaImgBtnDashboard_Click);
            // 
            // UC_PanouAcasa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(172)))));
            this.Controls.Add(this.gunaImgBtnDashboard);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Name = "UC_PanouAcasa";
            this.Size = new System.Drawing.Size(933, 657);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnDashboard;
    }
}
