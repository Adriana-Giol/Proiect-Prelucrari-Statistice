namespace Proiect_PAW
{
    partial class UC_PanouRecenzori
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
            this.labelTitlu = new System.Windows.Forms.Label();
            this.gunaTbCauta = new Guna.UI2.WinForms.Guna2TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previzualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierXMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaBtnSterge = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnActualizare = new Guna.UI2.WinForms.Guna2Button();
            this.gunaaBtnAdauga = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(300, 57);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(294, 45);
            this.labelTitlu.TabIndex = 11;
            this.labelTitlu.Text = "Personal Recenzor";
            // 
            // gunaTbCauta
            // 
            this.gunaTbCauta.Animated = true;
            this.gunaTbCauta.AutoRoundedCorners = true;
            this.gunaTbCauta.BorderColor = System.Drawing.Color.Blue;
            this.gunaTbCauta.BorderRadius = 17;
            this.gunaTbCauta.BorderThickness = 2;
            this.gunaTbCauta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTbCauta.DefaultText = "";
            this.gunaTbCauta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTbCauta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTbCauta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbCauta.DisabledState.Parent = this.gunaTbCauta;
            this.gunaTbCauta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbCauta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbCauta.FocusedState.Parent = this.gunaTbCauta;
            this.gunaTbCauta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaTbCauta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbCauta.HoverState.Parent = this.gunaTbCauta;
            this.gunaTbCauta.IconLeft = global::Proiect_PAW.Properties.Resources.loupe;
            this.gunaTbCauta.IconLeftSize = new System.Drawing.Size(15, 15);
            this.gunaTbCauta.Location = new System.Drawing.Point(299, 105);
            this.gunaTbCauta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbCauta.Name = "gunaTbCauta";
            this.gunaTbCauta.PasswordChar = '\0';
            this.gunaTbCauta.PlaceholderText = "Caută";
            this.gunaTbCauta.SelectedText = "";
            this.gunaTbCauta.ShadowDecoration.Parent = this.gunaTbCauta;
            this.gunaTbCauta.Size = new System.Drawing.Size(310, 36);
            this.gunaTbCauta.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierToolStripMenuItem,
            this.printareToolStripMenuItem,
            this.importDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 44);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvareFisierToolStripMenuItem
            // 
            this.salvareFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTextToolStripMenuItem,
            this.fisierXMLToolStripMenuItem});
            this.salvareFisierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvareFisierToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.save__1_;
            this.salvareFisierToolStripMenuItem.Name = "salvareFisierToolStripMenuItem";
            this.salvareFisierToolStripMenuItem.Size = new System.Drawing.Size(143, 40);
            this.salvareFisierToolStripMenuItem.Text = "Salvare Fisier";
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.fisierTextToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.txt;
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.fisierTextToolStripMenuItem.Text = "Fisier Text";
            // 
            // fisierXMLToolStripMenuItem
            // 
            this.fisierXMLToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.fisierXMLToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.xml;
            this.fisierXMLToolStripMenuItem.Name = "fisierXMLToolStripMenuItem";
            this.fisierXMLToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.fisierXMLToolStripMenuItem.Text = "Fisier XML";
            // 
            // printareToolStripMenuItem
            // 
            this.printareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previzualizareToolStripMenuItem,
            this.imprimareToolStripMenuItem});
            this.printareToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printareToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.printer;
            this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(104, 40);
            this.printareToolStripMenuItem.Text = "Printare";
            // 
            // previzualizareToolStripMenuItem
            // 
            this.previzualizareToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.previzualizareToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.search__1_;
            this.previzualizareToolStripMenuItem.Name = "previzualizareToolStripMenuItem";
            this.previzualizareToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.previzualizareToolStripMenuItem.Text = "Previzualizare";
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.imprimareToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.printer;
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.imprimareToolStripMenuItem.Text = "Imprimare";
            // 
            // importDateToolStripMenuItem
            // 
            this.importDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTextToolStripMenuItem1,
            this.fisierXMLToolStripMenuItem1});
            this.importDateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importDateToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.upload;
            this.importDateToolStripMenuItem.Name = "importDateToolStripMenuItem";
            this.importDateToolStripMenuItem.Size = new System.Drawing.Size(137, 40);
            this.importDateToolStripMenuItem.Text = "Import Date";
            // 
            // fisierTextToolStripMenuItem1
            // 
            this.fisierTextToolStripMenuItem1.BackColor = System.Drawing.Color.Blue;
            this.fisierTextToolStripMenuItem1.Image = global::Proiect_PAW.Properties.Resources.txt;
            this.fisierTextToolStripMenuItem1.Name = "fisierTextToolStripMenuItem1";
            this.fisierTextToolStripMenuItem1.Size = new System.Drawing.Size(173, 28);
            this.fisierTextToolStripMenuItem1.Text = "Fisier Text";
            // 
            // fisierXMLToolStripMenuItem1
            // 
            this.fisierXMLToolStripMenuItem1.BackColor = System.Drawing.Color.Blue;
            this.fisierXMLToolStripMenuItem1.Image = global::Proiect_PAW.Properties.Resources.xml;
            this.fisierXMLToolStripMenuItem1.Name = "fisierXMLToolStripMenuItem1";
            this.fisierXMLToolStripMenuItem1.Size = new System.Drawing.Size(173, 28);
            this.fisierXMLToolStripMenuItem1.Text = "Fisier XML";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.gunaBtnSterge);
            this.guna2Panel1.Controls.Add(this.gunaBtnActualizare);
            this.guna2Panel1.Controls.Add(this.gunaaBtnAdauga);
            this.guna2Panel1.Location = new System.Drawing.Point(33, 503);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(867, 100);
            this.guna2Panel1.TabIndex = 12;
            // 
            // gunaBtnSterge
            // 
            this.gunaBtnSterge.Animated = true;
            this.gunaBtnSterge.AutoRoundedCorners = true;
            this.gunaBtnSterge.BorderColor = System.Drawing.Color.Navy;
            this.gunaBtnSterge.BorderRadius = 32;
            this.gunaBtnSterge.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaBtnSterge.BorderThickness = 2;
            this.gunaBtnSterge.CheckedState.Parent = this.gunaBtnSterge;
            this.gunaBtnSterge.CustomImages.Parent = this.gunaBtnSterge;
            this.gunaBtnSterge.FillColor = System.Drawing.Color.Blue;
            this.gunaBtnSterge.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnSterge.ForeColor = System.Drawing.Color.Black;
            this.gunaBtnSterge.HoverState.Parent = this.gunaBtnSterge;
            this.gunaBtnSterge.Image = global::Proiect_PAW.Properties.Resources.delete_user;
            this.gunaBtnSterge.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBtnSterge.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaBtnSterge.Location = new System.Drawing.Point(649, 17);
            this.gunaBtnSterge.Name = "gunaBtnSterge";
            this.gunaBtnSterge.ShadowDecoration.Parent = this.gunaBtnSterge;
            this.gunaBtnSterge.Size = new System.Drawing.Size(197, 67);
            this.gunaBtnSterge.TabIndex = 2;
            this.gunaBtnSterge.Text = "Șterge Persoană";
            this.gunaBtnSterge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaBtnActualizare
            // 
            this.gunaBtnActualizare.Animated = true;
            this.gunaBtnActualizare.AutoRoundedCorners = true;
            this.gunaBtnActualizare.BorderColor = System.Drawing.Color.Navy;
            this.gunaBtnActualizare.BorderRadius = 32;
            this.gunaBtnActualizare.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaBtnActualizare.BorderThickness = 2;
            this.gunaBtnActualizare.CheckedState.Parent = this.gunaBtnActualizare;
            this.gunaBtnActualizare.CustomImages.Parent = this.gunaBtnActualizare;
            this.gunaBtnActualizare.FillColor = System.Drawing.Color.Blue;
            this.gunaBtnActualizare.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnActualizare.ForeColor = System.Drawing.Color.Black;
            this.gunaBtnActualizare.HoverState.Parent = this.gunaBtnActualizare;
            this.gunaBtnActualizare.Image = global::Proiect_PAW.Properties.Resources.edit;
            this.gunaBtnActualizare.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBtnActualizare.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaBtnActualizare.Location = new System.Drawing.Point(339, 17);
            this.gunaBtnActualizare.Name = "gunaBtnActualizare";
            this.gunaBtnActualizare.ShadowDecoration.Parent = this.gunaBtnActualizare;
            this.gunaBtnActualizare.Size = new System.Drawing.Size(229, 67);
            this.gunaBtnActualizare.TabIndex = 1;
            this.gunaBtnActualizare.Text = "Actualizează Persoană";
            this.gunaBtnActualizare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaaBtnAdauga
            // 
            this.gunaaBtnAdauga.Animated = true;
            this.gunaaBtnAdauga.AutoRoundedCorners = true;
            this.gunaaBtnAdauga.BorderColor = System.Drawing.Color.Navy;
            this.gunaaBtnAdauga.BorderRadius = 32;
            this.gunaaBtnAdauga.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaaBtnAdauga.BorderThickness = 2;
            this.gunaaBtnAdauga.CheckedState.Parent = this.gunaaBtnAdauga;
            this.gunaaBtnAdauga.CustomImages.Parent = this.gunaaBtnAdauga;
            this.gunaaBtnAdauga.FillColor = System.Drawing.Color.Blue;
            this.gunaaBtnAdauga.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaaBtnAdauga.ForeColor = System.Drawing.Color.Black;
            this.gunaaBtnAdauga.HoverState.Parent = this.gunaaBtnAdauga;
            this.gunaaBtnAdauga.Image = global::Proiect_PAW.Properties.Resources.add;
            this.gunaaBtnAdauga.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaaBtnAdauga.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaaBtnAdauga.Location = new System.Drawing.Point(50, 17);
            this.gunaaBtnAdauga.Name = "gunaaBtnAdauga";
            this.gunaaBtnAdauga.ShadowDecoration.Parent = this.gunaaBtnAdauga;
            this.gunaaBtnAdauga.Size = new System.Drawing.Size(197, 67);
            this.gunaaBtnAdauga.TabIndex = 0;
            this.gunaaBtnAdauga.Text = "Adaugă Persoană";
            this.gunaaBtnAdauga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UC_PanouRecenzori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.gunaTbCauta);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_PanouRecenzori";
            this.Size = new System.Drawing.Size(933, 657);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbCauta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previzualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fisierXMLToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button gunaBtnSterge;
        private Guna.UI2.WinForms.Guna2Button gunaBtnActualizare;
        private Guna.UI2.WinForms.Guna2Button gunaaBtnAdauga;
    }
}
