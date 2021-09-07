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
            this.components = new System.ComponentModel.Container();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afisarePersoaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.listViewRecenzor = new System.Windows.Forms.ListView();
            this.colNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegiune = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJudet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocalitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDirector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.stergeRecenzorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaImgBtnLocuinta = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaImgBtnDashboard = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaTbCauta = new Guna.UI2.WinForms.Guna2TextBox();
            this.menuStrip1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(325, 61);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(294, 45);
            this.labelTitlu.TabIndex = 11;
            this.labelTitlu.Text = "Personal Recenzor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisarePersoaneToolStripMenuItem,
            this.salvareFisierToolStripMenuItem,
            this.printareToolStripMenuItem,
            this.importDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 44);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afisarePersoaneToolStripMenuItem
            // 
            this.afisarePersoaneToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afisarePersoaneToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.list;
            this.afisarePersoaneToolStripMenuItem.Name = "afisarePersoaneToolStripMenuItem";
            this.afisarePersoaneToolStripMenuItem.Size = new System.Drawing.Size(176, 40);
            this.afisarePersoaneToolStripMenuItem.Text = "Afisare Recenzori";
            this.afisarePersoaneToolStripMenuItem.Click += new System.EventHandler(this.afisarePersoaneToolStripMenuItem_Click);
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
            this.previzualizareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.previzualizareToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.previzualizareToolStripMenuItem.Text = "Previzualizare";
            this.previzualizareToolStripMenuItem.Click += new System.EventHandler(this.previzualizareToolStripMenuItem_Click);
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.imprimareToolStripMenuItem.Image = global::Proiect_PAW.Properties.Resources.printer;
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
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
            this.guna2Panel1.Location = new System.Drawing.Point(50, 479);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(834, 100);
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
            this.gunaBtnSterge.ForeColor = System.Drawing.Color.White;
            this.gunaBtnSterge.HoverState.Parent = this.gunaBtnSterge;
            this.gunaBtnSterge.Image = global::Proiect_PAW.Properties.Resources.delete_user;
            this.gunaBtnSterge.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBtnSterge.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaBtnSterge.Location = new System.Drawing.Point(603, 16);
            this.gunaBtnSterge.Name = "gunaBtnSterge";
            this.gunaBtnSterge.ShadowDecoration.Parent = this.gunaBtnSterge;
            this.gunaBtnSterge.Size = new System.Drawing.Size(197, 67);
            this.gunaBtnSterge.TabIndex = 2;
            this.gunaBtnSterge.Text = "Șterge Persoană";
            this.gunaBtnSterge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaBtnSterge.Click += new System.EventHandler(this.gunaBtnSterge_Click);
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
            this.gunaBtnActualizare.ForeColor = System.Drawing.Color.White;
            this.gunaBtnActualizare.HoverState.Parent = this.gunaBtnActualizare;
            this.gunaBtnActualizare.Image = global::Proiect_PAW.Properties.Resources.edit;
            this.gunaBtnActualizare.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBtnActualizare.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaBtnActualizare.Location = new System.Drawing.Point(305, 16);
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
            this.gunaaBtnAdauga.ForeColor = System.Drawing.Color.White;
            this.gunaaBtnAdauga.HoverState.Parent = this.gunaaBtnAdauga;
            this.gunaaBtnAdauga.Image = global::Proiect_PAW.Properties.Resources.add;
            this.gunaaBtnAdauga.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaaBtnAdauga.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaaBtnAdauga.Location = new System.Drawing.Point(3, 16);
            this.gunaaBtnAdauga.Name = "gunaaBtnAdauga";
            this.gunaaBtnAdauga.ShadowDecoration.Parent = this.gunaaBtnAdauga;
            this.gunaaBtnAdauga.Size = new System.Drawing.Size(197, 67);
            this.gunaaBtnAdauga.TabIndex = 0;
            this.gunaaBtnAdauga.Text = "Adaugă Persoană";
            this.gunaaBtnAdauga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaaBtnAdauga.Click += new System.EventHandler(this.gunaaBtnAdauga_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.listViewRecenzor);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(43, 192);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(841, 259);
            this.guna2ShadowPanel1.TabIndex = 13;
            // 
            // listViewRecenzor
            // 
            this.listViewRecenzor.AllowColumnReorder = true;
            this.listViewRecenzor.BackColor = System.Drawing.Color.SkyBlue;
            this.listViewRecenzor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNume,
            this.colCod,
            this.colData,
            this.colSex,
            this.colRegiune,
            this.colJudet,
            this.colLocalitate,
            this.colDirector});
            this.listViewRecenzor.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRecenzor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listViewRecenzor.FullRowSelect = true;
            this.listViewRecenzor.GridLines = true;
            this.listViewRecenzor.HideSelection = false;
            this.listViewRecenzor.Location = new System.Drawing.Point(13, 13);
            this.listViewRecenzor.Name = "listViewRecenzor";
            this.listViewRecenzor.Size = new System.Drawing.Size(815, 233);
            this.listViewRecenzor.TabIndex = 16;
            this.listViewRecenzor.UseCompatibleStateImageBehavior = false;
            this.listViewRecenzor.View = System.Windows.Forms.View.Details;
            // 
            // colNume
            // 
            this.colNume.Text = "Nume Prenume";
            this.colNume.Width = 125;
            // 
            // colCod
            // 
            this.colCod.Text = "Cod Recenzor";
            this.colCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCod.Width = 100;
            // 
            // colData
            // 
            this.colData.Text = "Data Nasterii";
            this.colData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colData.Width = 103;
            // 
            // colSex
            // 
            this.colSex.Text = "Sex";
            this.colSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSex.Width = 72;
            // 
            // colRegiune
            // 
            this.colRegiune.Text = "Regiune";
            this.colRegiune.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRegiune.Width = 103;
            // 
            // colJudet
            // 
            this.colJudet.Text = "Judet";
            this.colJudet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colJudet.Width = 88;
            // 
            // colLocalitate
            // 
            this.colLocalitate.Text = "Localitate";
            this.colLocalitate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLocalitate.Width = 79;
            // 
            // colDirector
            // 
            this.colDirector.Text = "Director Regional";
            this.colDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDirector.Width = 141;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.Blue;
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeRecenzorToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(190, 28);
            // 
            // stergeRecenzorToolStripMenuItem
            // 
            this.stergeRecenzorToolStripMenuItem.Name = "stergeRecenzorToolStripMenuItem";
            this.stergeRecenzorToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.stergeRecenzorToolStripMenuItem.Text = "Sterge Recenzor";
            // 
            // gunaImgBtnLocuinta
            // 
            this.gunaImgBtnLocuinta.BackColor = System.Drawing.Color.Transparent;
            this.gunaImgBtnLocuinta.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImgBtnLocuinta.CheckedState.Parent = this.gunaImgBtnLocuinta;
            this.gunaImgBtnLocuinta.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImgBtnLocuinta.HoverState.Parent = this.gunaImgBtnLocuinta;
            this.gunaImgBtnLocuinta.Image = global::Proiect_PAW.Properties.Resources.romania__1_;
            this.gunaImgBtnLocuinta.ImageRotate = 0F;
            this.gunaImgBtnLocuinta.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImgBtnLocuinta.Location = new System.Drawing.Point(849, 0);
            this.gunaImgBtnLocuinta.Name = "gunaImgBtnLocuinta";
            this.gunaImgBtnLocuinta.PressedState.ImageSize = new System.Drawing.Size(40, 35);
            this.gunaImgBtnLocuinta.PressedState.Parent = this.gunaImgBtnLocuinta;
            this.gunaImgBtnLocuinta.Size = new System.Drawing.Size(81, 44);
            this.gunaImgBtnLocuinta.TabIndex = 15;
            this.gunaImgBtnLocuinta.UseTransparentBackground = true;
            this.gunaImgBtnLocuinta.Click += new System.EventHandler(this.gunaImgBtnLocuinta_Click);
            // 
            // gunaImgBtnDashboard
            // 
            this.gunaImgBtnDashboard.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImgBtnDashboard.CheckedState.Parent = this.gunaImgBtnDashboard;
            this.gunaImgBtnDashboard.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImgBtnDashboard.HoverState.Parent = this.gunaImgBtnDashboard;
            this.gunaImgBtnDashboard.Image = global::Proiect_PAW.Properties.Resources.arrow21;
            this.gunaImgBtnDashboard.ImageRotate = 0F;
            this.gunaImgBtnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImgBtnDashboard.Location = new System.Drawing.Point(3, 47);
            this.gunaImgBtnDashboard.Name = "gunaImgBtnDashboard";
            this.gunaImgBtnDashboard.PressedState.ImageSize = new System.Drawing.Size(30, 25);
            this.gunaImgBtnDashboard.PressedState.Parent = this.gunaImgBtnDashboard;
            this.gunaImgBtnDashboard.Size = new System.Drawing.Size(48, 33);
            this.gunaImgBtnDashboard.TabIndex = 14;
            this.gunaImgBtnDashboard.Click += new System.EventHandler(this.gunaImgBtnDashboard_Click);
            // 
            // gunaTbCauta
            // 
            this.gunaTbCauta.Animated = true;
            this.gunaTbCauta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
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
            this.gunaTbCauta.Location = new System.Drawing.Point(289, 126);
            this.gunaTbCauta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbCauta.Name = "gunaTbCauta";
            this.gunaTbCauta.PasswordChar = '\0';
            this.gunaTbCauta.PlaceholderText = "Caută";
            this.gunaTbCauta.SelectedText = "";
            this.gunaTbCauta.ShadowDecoration.Parent = this.gunaTbCauta;
            this.gunaTbCauta.Size = new System.Drawing.Size(310, 36);
            this.gunaTbCauta.TabIndex = 9;
            this.gunaTbCauta.TextChanged += new System.EventHandler(this.gunaTbCauta_TextChanged);
            // 
            // UC_PanouRecenzori
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.gunaImgBtnLocuinta);
            this.Controls.Add(this.gunaImgBtnDashboard);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.gunaTbCauta);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_PanouRecenzori";
            this.Size = new System.Drawing.Size(933, 657);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnDashboard;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeRecenzorToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnLocuinta;
        private System.Windows.Forms.ToolStripMenuItem afisarePersoaneToolStripMenuItem;
        private System.Windows.Forms.ListView listViewRecenzor;
        private System.Windows.Forms.ColumnHeader colNume;
        private System.Windows.Forms.ColumnHeader colCod;
        private System.Windows.Forms.ColumnHeader colSex;
        private System.Windows.Forms.ColumnHeader colRegiune;
        private System.Windows.Forms.ColumnHeader colJudet;
        private System.Windows.Forms.ColumnHeader colLocalitate;
        private System.Windows.Forms.ColumnHeader colDirector;
        private System.Windows.Forms.ColumnHeader colData;
    }
}
