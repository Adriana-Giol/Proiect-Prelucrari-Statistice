namespace Proiect_PAW.Forms
{
    partial class FormAdd_Recenzor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd_Recenzor));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
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
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaCbRegiune = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaCkImgRegiune = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaimgCkJudet = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaCbJudet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaImgCkLocalitate = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.labelRegiune = new System.Windows.Forms.Label();
            this.gunaTbLocalitate = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelLocalitate = new System.Windows.Forms.Label();
            this.labelJudet = new System.Windows.Forms.Label();
            this.gunaGbDatePersonale = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaImgCkSex = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaImgCkData = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaImgCkCNP = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaImgCkNume = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.labelAni = new System.Windows.Forms.Label();
            this.labelDataNasterii = new System.Windows.Forms.Label();
            this.gunaTbNume = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaTbCodRecenzor = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCodRecenzor = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelNume = new System.Windows.Forms.Label();
            this.gunaGbSex = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ImageRadioButtonMasculin = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.guna2ImageRadioButtonFeminin = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.labelMasculin = new System.Windows.Forms.Label();
            this.labelFeminin = new System.Windows.Forms.Label();
            this.gunaaBtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnSalvare = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelBara = new System.Windows.Forms.Label();
            this.gunaImgBtnX = new Guna.UI2.WinForms.Guna2ImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.gunaGbDatePersonale.SuspendLayout();
            this.gunaGbSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.guna2Panel1.Controls.Add(this.menuStrip1);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox2);
            this.guna2Panel1.Controls.Add(this.gunaGbDatePersonale);
            this.guna2Panel1.Controls.Add(this.gunaaBtnCancel);
            this.guna2Panel1.Controls.Add(this.gunaBtnSalvare);
            this.guna2Panel1.Location = new System.Drawing.Point(26, 42);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(769, 649);
            this.guna2Panel1.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(769, 35);
            this.menuStrip1.TabIndex = 30;
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
            this.salvareFisierToolStripMenuItem.Size = new System.Drawing.Size(143, 31);
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
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
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
            this.importDateToolStripMenuItem.Size = new System.Drawing.Size(137, 31);
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
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Blue;
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2GroupBox2.BorderThickness = 4;
            this.guna2GroupBox2.Controls.Add(this.gunaCbRegiune);
            this.guna2GroupBox2.Controls.Add(this.gunaCkImgRegiune);
            this.guna2GroupBox2.Controls.Add(this.gunaimgCkJudet);
            this.guna2GroupBox2.Controls.Add(this.gunaCbJudet);
            this.guna2GroupBox2.Controls.Add(this.gunaImgCkLocalitate);
            this.guna2GroupBox2.Controls.Add(this.labelRegiune);
            this.guna2GroupBox2.Controls.Add(this.gunaTbLocalitate);
            this.guna2GroupBox2.Controls.Add(this.labelLocalitate);
            this.guna2GroupBox2.Controls.Add(this.labelJudet);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.SkyBlue;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.guna2GroupBox2.Location = new System.Drawing.Point(416, 45);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(319, 442);
            this.guna2GroupBox2.TabIndex = 29;
            this.guna2GroupBox2.Text = "II. Date Zonă Recenzată";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox2.UseTransparentBackground = true;
            // 
            // gunaCbRegiune
            // 
            this.gunaCbRegiune.AutoRoundedCorners = true;
            this.gunaCbRegiune.BackColor = System.Drawing.Color.Transparent;
            this.gunaCbRegiune.BorderColor = System.Drawing.Color.Blue;
            this.gunaCbRegiune.BorderRadius = 17;
            this.gunaCbRegiune.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaCbRegiune.BorderThickness = 2;
            this.gunaCbRegiune.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaCbRegiune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaCbRegiune.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaCbRegiune.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaCbRegiune.FocusedState.Parent = this.gunaCbRegiune;
            this.gunaCbRegiune.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.gunaCbRegiune.ForeColor = System.Drawing.Color.Navy;
            this.gunaCbRegiune.HoverState.Parent = this.gunaCbRegiune;
            this.gunaCbRegiune.ItemHeight = 30;
            this.gunaCbRegiune.ItemsAppearance.Parent = this.gunaCbRegiune;
            this.gunaCbRegiune.Location = new System.Drawing.Point(27, 87);
            this.gunaCbRegiune.Name = "gunaCbRegiune";
            this.gunaCbRegiune.ShadowDecoration.Parent = this.gunaCbRegiune;
            this.gunaCbRegiune.Size = new System.Drawing.Size(250, 36);
            this.gunaCbRegiune.TabIndex = 41;
            this.gunaCbRegiune.SelectedIndexChanged += new System.EventHandler(this.gunaCbRegiune_SelectedIndexChanged);
            // 
            // gunaCkImgRegiune
            // 
            this.gunaCkImgRegiune.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaCkImgRegiune.CheckedState.Parent = this.gunaCkImgRegiune;
            this.gunaCkImgRegiune.HoverState.Parent = this.gunaCkImgRegiune;
            this.gunaCkImgRegiune.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.gunaCkImgRegiune.IndicateFocus = false;
            this.gunaCkImgRegiune.Location = new System.Drawing.Point(280, 85);
            this.gunaCkImgRegiune.Name = "gunaCkImgRegiune";
            this.gunaCkImgRegiune.PressedState.Parent = this.gunaCkImgRegiune;
            this.gunaCkImgRegiune.Size = new System.Drawing.Size(36, 38);
            this.gunaCkImgRegiune.TabIndex = 38;
            // 
            // gunaimgCkJudet
            // 
            this.gunaimgCkJudet.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaimgCkJudet.CheckedState.Parent = this.gunaimgCkJudet;
            this.gunaimgCkJudet.HoverState.Parent = this.gunaimgCkJudet;
            this.gunaimgCkJudet.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.gunaimgCkJudet.IndicateFocus = false;
            this.gunaimgCkJudet.Location = new System.Drawing.Point(280, 159);
            this.gunaimgCkJudet.Name = "gunaimgCkJudet";
            this.gunaimgCkJudet.PressedState.Parent = this.gunaimgCkJudet;
            this.gunaimgCkJudet.Size = new System.Drawing.Size(36, 38);
            this.gunaimgCkJudet.TabIndex = 32;
            // 
            // gunaCbJudet
            // 
            this.gunaCbJudet.AutoRoundedCorners = true;
            this.gunaCbJudet.BackColor = System.Drawing.Color.Transparent;
            this.gunaCbJudet.BorderColor = System.Drawing.Color.Blue;
            this.gunaCbJudet.BorderRadius = 17;
            this.gunaCbJudet.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaCbJudet.BorderThickness = 2;
            this.gunaCbJudet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaCbJudet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaCbJudet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaCbJudet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaCbJudet.FocusedState.Parent = this.gunaCbJudet;
            this.gunaCbJudet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.gunaCbJudet.ForeColor = System.Drawing.Color.Navy;
            this.gunaCbJudet.HoverState.Parent = this.gunaCbJudet;
            this.gunaCbJudet.ItemHeight = 30;
            this.gunaCbJudet.ItemsAppearance.Parent = this.gunaCbJudet;
            this.gunaCbJudet.Location = new System.Drawing.Point(27, 161);
            this.gunaCbJudet.Name = "gunaCbJudet";
            this.gunaCbJudet.ShadowDecoration.Parent = this.gunaCbJudet;
            this.gunaCbJudet.Size = new System.Drawing.Size(250, 36);
            this.gunaCbJudet.TabIndex = 37;
            this.gunaCbJudet.SelectedIndexChanged += new System.EventHandler(this.gunaCbJudet_SelectedIndexChanged);
            // 
            // gunaImgCkLocalitate
            // 
            this.gunaImgCkLocalitate.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaImgCkLocalitate.CheckedState.Parent = this.gunaImgCkLocalitate;
            this.gunaImgCkLocalitate.HoverState.Parent = this.gunaImgCkLocalitate;
            this.gunaImgCkLocalitate.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.gunaImgCkLocalitate.IndicateFocus = false;
            this.gunaImgCkLocalitate.Location = new System.Drawing.Point(280, 231);
            this.gunaImgCkLocalitate.Name = "gunaImgCkLocalitate";
            this.gunaImgCkLocalitate.PressedState.Parent = this.gunaImgCkLocalitate;
            this.gunaImgCkLocalitate.Size = new System.Drawing.Size(36, 38);
            this.gunaImgCkLocalitate.TabIndex = 33;
            // 
            // labelRegiune
            // 
            this.labelRegiune.AutoSize = true;
            this.labelRegiune.BackColor = System.Drawing.Color.Transparent;
            this.labelRegiune.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegiune.Location = new System.Drawing.Point(35, 65);
            this.labelRegiune.Name = "labelRegiune";
            this.labelRegiune.Size = new System.Drawing.Size(141, 19);
            this.labelRegiune.TabIndex = 18;
            this.labelRegiune.Text = "1. Regiune Recenzată";
            // 
            // gunaTbLocalitate
            // 
            this.gunaTbLocalitate.Animated = true;
            this.gunaTbLocalitate.AutoRoundedCorners = true;
            this.gunaTbLocalitate.BorderColor = System.Drawing.Color.Blue;
            this.gunaTbLocalitate.BorderRadius = 19;
            this.gunaTbLocalitate.BorderThickness = 2;
            this.gunaTbLocalitate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTbLocalitate.DefaultText = "";
            this.gunaTbLocalitate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTbLocalitate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTbLocalitate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbLocalitate.DisabledState.Parent = this.gunaTbLocalitate;
            this.gunaTbLocalitate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbLocalitate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbLocalitate.FocusedState.Parent = this.gunaTbLocalitate;
            this.gunaTbLocalitate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaTbLocalitate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbLocalitate.HoverState.Parent = this.gunaTbLocalitate;
            this.gunaTbLocalitate.Location = new System.Drawing.Point(27, 231);
            this.gunaTbLocalitate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbLocalitate.Name = "gunaTbLocalitate";
            this.gunaTbLocalitate.PasswordChar = '\0';
            this.gunaTbLocalitate.PlaceholderText = "Localitate Recenzată";
            this.gunaTbLocalitate.SelectedText = "";
            this.gunaTbLocalitate.ShadowDecoration.Parent = this.gunaTbLocalitate;
            this.gunaTbLocalitate.Size = new System.Drawing.Size(250, 40);
            this.gunaTbLocalitate.TabIndex = 8;
            this.gunaTbLocalitate.TextChanged += new System.EventHandler(this.gunaTbLocalitate_TextChanged);
            this.gunaTbLocalitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gunaTbLocalitate_KeyPress);
            // 
            // labelLocalitate
            // 
            this.labelLocalitate.AutoSize = true;
            this.labelLocalitate.BackColor = System.Drawing.Color.Transparent;
            this.labelLocalitate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalitate.Location = new System.Drawing.Point(35, 213);
            this.labelLocalitate.Name = "labelLocalitate";
            this.labelLocalitate.Size = new System.Drawing.Size(153, 19);
            this.labelLocalitate.TabIndex = 17;
            this.labelLocalitate.Text = "3. Localitate Recenzată";
            // 
            // labelJudet
            // 
            this.labelJudet.AutoSize = true;
            this.labelJudet.BackColor = System.Drawing.Color.Transparent;
            this.labelJudet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudet.Location = new System.Drawing.Point(35, 140);
            this.labelJudet.Name = "labelJudet";
            this.labelJudet.Size = new System.Drawing.Size(119, 19);
            this.labelJudet.TabIndex = 16;
            this.labelJudet.Text = "2. Județ Recenzat";
            // 
            // gunaGbDatePersonale
            // 
            this.gunaGbDatePersonale.BackColor = System.Drawing.Color.Transparent;
            this.gunaGbDatePersonale.BorderColor = System.Drawing.Color.Blue;
            this.gunaGbDatePersonale.BorderRadius = 20;
            this.gunaGbDatePersonale.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.gunaGbDatePersonale.BorderThickness = 4;
            this.gunaGbDatePersonale.Controls.Add(this.gunaImgCkSex);
            this.gunaGbDatePersonale.Controls.Add(this.gunaImgCkData);
            this.gunaGbDatePersonale.Controls.Add(this.gunaImgCkCNP);
            this.gunaGbDatePersonale.Controls.Add(this.gunaImgCkNume);
            this.gunaGbDatePersonale.Controls.Add(this.labelAni);
            this.gunaGbDatePersonale.Controls.Add(this.labelDataNasterii);
            this.gunaGbDatePersonale.Controls.Add(this.gunaTbNume);
            this.gunaGbDatePersonale.Controls.Add(this.gunaTbCodRecenzor);
            this.gunaGbDatePersonale.Controls.Add(this.labelCodRecenzor);
            this.gunaGbDatePersonale.Controls.Add(this.guna2DateTimePicker1);
            this.gunaGbDatePersonale.Controls.Add(this.labelNume);
            this.gunaGbDatePersonale.Controls.Add(this.gunaGbSex);
            this.gunaGbDatePersonale.CustomBorderColor = System.Drawing.Color.SkyBlue;
            this.gunaGbDatePersonale.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gunaGbDatePersonale.FillColor = System.Drawing.Color.SkyBlue;
            this.gunaGbDatePersonale.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGbDatePersonale.ForeColor = System.Drawing.Color.Blue;
            this.gunaGbDatePersonale.Location = new System.Drawing.Point(40, 45);
            this.gunaGbDatePersonale.Margin = new System.Windows.Forms.Padding(0);
            this.gunaGbDatePersonale.Name = "gunaGbDatePersonale";
            this.gunaGbDatePersonale.ShadowDecoration.Parent = this.gunaGbDatePersonale;
            this.gunaGbDatePersonale.Size = new System.Drawing.Size(319, 442);
            this.gunaGbDatePersonale.TabIndex = 25;
            this.gunaGbDatePersonale.Text = "I. Date Personale";
            this.gunaGbDatePersonale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGbDatePersonale.UseTransparentBackground = true;
            // 
            // gunaImgCkSex
            // 
            this.gunaImgCkSex.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaImgCkSex.CheckedState.Parent = this.gunaImgCkSex;
            this.gunaImgCkSex.HoverState.Parent = this.gunaImgCkSex;
            this.gunaImgCkSex.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.gunaImgCkSex.IndicateFocus = false;
            this.gunaImgCkSex.Location = new System.Drawing.Point(279, 352);
            this.gunaImgCkSex.Name = "gunaImgCkSex";
            this.gunaImgCkSex.PressedState.Parent = this.gunaImgCkSex;
            this.gunaImgCkSex.Size = new System.Drawing.Size(36, 38);
            this.gunaImgCkSex.TabIndex = 32;
            // 
            // gunaImgCkData
            // 
            this.gunaImgCkData.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaImgCkData.CheckedState.Parent = this.gunaImgCkData;
            this.gunaImgCkData.HoverState.Parent = this.gunaImgCkData;
            this.gunaImgCkData.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.gunaImgCkData.IndicateFocus = false;
            this.gunaImgCkData.Location = new System.Drawing.Point(280, 237);
            this.gunaImgCkData.Name = "gunaImgCkData";
            this.gunaImgCkData.PressedState.Parent = this.gunaImgCkData;
            this.gunaImgCkData.Size = new System.Drawing.Size(36, 38);
            this.gunaImgCkData.TabIndex = 31;
            // 
            // gunaImgCkCNP
            // 
            this.gunaImgCkCNP.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaImgCkCNP.CheckedState.Parent = this.gunaImgCkCNP;
            this.gunaImgCkCNP.HoverState.Parent = this.gunaImgCkCNP;
            this.gunaImgCkCNP.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.gunaImgCkCNP.IndicateFocus = false;
            this.gunaImgCkCNP.Location = new System.Drawing.Point(280, 163);
            this.gunaImgCkCNP.Name = "gunaImgCkCNP";
            this.gunaImgCkCNP.PressedState.Parent = this.gunaImgCkCNP;
            this.gunaImgCkCNP.Size = new System.Drawing.Size(36, 38);
            this.gunaImgCkCNP.TabIndex = 30;
            // 
            // gunaImgCkNume
            // 
            this.gunaImgCkNume.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaImgCkNume.CheckedState.Parent = this.gunaImgCkNume;
            this.gunaImgCkNume.HoverState.Parent = this.gunaImgCkNume;
            this.gunaImgCkNume.Image = global::Proiect_PAW.Properties.Resources.Picture2;
            this.gunaImgCkNume.IndicateFocus = false;
            this.gunaImgCkNume.Location = new System.Drawing.Point(280, 89);
            this.gunaImgCkNume.Name = "gunaImgCkNume";
            this.gunaImgCkNume.PressedState.Parent = this.gunaImgCkNume;
            this.gunaImgCkNume.Size = new System.Drawing.Size(36, 38);
            this.gunaImgCkNume.TabIndex = 30;
            // 
            // labelAni
            // 
            this.labelAni.AutoSize = true;
            this.labelAni.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAni.ForeColor = System.Drawing.Color.Crimson;
            this.labelAni.Location = new System.Drawing.Point(136, 213);
            this.labelAni.Name = "labelAni";
            this.labelAni.Size = new System.Drawing.Size(78, 19);
            this.labelAni.TabIndex = 28;
            this.labelAni.Text = "Cati ani ai?";
            // 
            // labelDataNasterii
            // 
            this.labelDataNasterii.AutoSize = true;
            this.labelDataNasterii.BackColor = System.Drawing.Color.Transparent;
            this.labelDataNasterii.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNasterii.Location = new System.Drawing.Point(24, 213);
            this.labelDataNasterii.Name = "labelDataNasterii";
            this.labelDataNasterii.Size = new System.Drawing.Size(106, 19);
            this.labelDataNasterii.TabIndex = 18;
            this.labelDataNasterii.Text = "3. Data Nașterii";
            // 
            // gunaTbNume
            // 
            this.gunaTbNume.Animated = true;
            this.gunaTbNume.AutoRoundedCorners = true;
            this.gunaTbNume.BorderColor = System.Drawing.Color.Blue;
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
            this.gunaTbNume.Location = new System.Drawing.Point(28, 87);
            this.gunaTbNume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbNume.Name = "gunaTbNume";
            this.gunaTbNume.PasswordChar = '\0';
            this.gunaTbNume.PlaceholderText = "Nume și Prenume";
            this.gunaTbNume.SelectedText = "";
            this.gunaTbNume.ShadowDecoration.Parent = this.gunaTbNume;
            this.gunaTbNume.Size = new System.Drawing.Size(250, 40);
            this.gunaTbNume.TabIndex = 7;
            this.gunaTbNume.TextChanged += new System.EventHandler(this.gunaTbNume_TextChanged);
            this.gunaTbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gunaTbNume_KeyPress);
            // 
            // gunaTbCodRecenzor
            // 
            this.gunaTbCodRecenzor.Animated = true;
            this.gunaTbCodRecenzor.AutoRoundedCorners = true;
            this.gunaTbCodRecenzor.BorderColor = System.Drawing.Color.Blue;
            this.gunaTbCodRecenzor.BorderRadius = 19;
            this.gunaTbCodRecenzor.BorderThickness = 2;
            this.gunaTbCodRecenzor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTbCodRecenzor.DefaultText = "";
            this.gunaTbCodRecenzor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTbCodRecenzor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTbCodRecenzor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbCodRecenzor.DisabledState.Parent = this.gunaTbCodRecenzor;
            this.gunaTbCodRecenzor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTbCodRecenzor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbCodRecenzor.FocusedState.Parent = this.gunaTbCodRecenzor;
            this.gunaTbCodRecenzor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaTbCodRecenzor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTbCodRecenzor.HoverState.Parent = this.gunaTbCodRecenzor;
            this.gunaTbCodRecenzor.Location = new System.Drawing.Point(28, 161);
            this.gunaTbCodRecenzor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gunaTbCodRecenzor.Name = "gunaTbCodRecenzor";
            this.gunaTbCodRecenzor.PasswordChar = '\0';
            this.gunaTbCodRecenzor.PlaceholderText = "Cod Recenzor";
            this.gunaTbCodRecenzor.SelectedText = "";
            this.gunaTbCodRecenzor.ShadowDecoration.Parent = this.gunaTbCodRecenzor;
            this.gunaTbCodRecenzor.Size = new System.Drawing.Size(250, 40);
            this.gunaTbCodRecenzor.TabIndex = 8;
            this.gunaTbCodRecenzor.TextChanged += new System.EventHandler(this.gunaTbCodRecenzor_TextChanged);
            this.gunaTbCodRecenzor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gunaTbCodRecenzor_KeyPress);
            // 
            // labelCodRecenzor
            // 
            this.labelCodRecenzor.AutoSize = true;
            this.labelCodRecenzor.BackColor = System.Drawing.Color.Transparent;
            this.labelCodRecenzor.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodRecenzor.Location = new System.Drawing.Point(24, 140);
            this.labelCodRecenzor.Name = "labelCodRecenzor";
            this.labelCodRecenzor.Size = new System.Drawing.Size(111, 19);
            this.labelCodRecenzor.TabIndex = 17;
            this.labelCodRecenzor.Text = "2. Cod Recenzor";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.Blue;
            this.guna2DateTimePicker1.BorderRadius = 19;
            this.guna2DateTimePicker1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2DateTimePicker1.BorderThickness = 2;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.Navy;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(28, 235);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(250, 40);
            this.guna2DateTimePicker1.TabIndex = 10;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 4, 25, 16, 39, 13, 488);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.BackColor = System.Drawing.Color.Transparent;
            this.labelNume.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(24, 65);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(133, 19);
            this.labelNume.TabIndex = 16;
            this.labelNume.Text = "1. Nume și Prenume";
            // 
            // gunaGbSex
            // 
            this.gunaGbSex.AutoRoundedCorners = true;
            this.gunaGbSex.BorderColor = System.Drawing.Color.Blue;
            this.gunaGbSex.BorderRadius = 58;
            this.gunaGbSex.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaGbSex.BorderThickness = 2;
            this.gunaGbSex.Controls.Add(this.guna2ImageRadioButtonMasculin);
            this.gunaGbSex.Controls.Add(this.guna2ImageRadioButtonFeminin);
            this.gunaGbSex.Controls.Add(this.labelMasculin);
            this.gunaGbSex.Controls.Add(this.labelFeminin);
            this.gunaGbSex.CustomBorderColor = System.Drawing.Color.SkyBlue;
            this.gunaGbSex.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gunaGbSex.FillColor = System.Drawing.Color.SkyBlue;
            this.gunaGbSex.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGbSex.ForeColor = System.Drawing.Color.Blue;
            this.gunaGbSex.Location = new System.Drawing.Point(28, 312);
            this.gunaGbSex.Name = "gunaGbSex";
            this.gunaGbSex.ShadowDecoration.Parent = this.gunaGbSex;
            this.gunaGbSex.Size = new System.Drawing.Size(250, 119);
            this.gunaGbSex.TabIndex = 14;
            this.gunaGbSex.Text = "Sex";
            this.gunaGbSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ImageRadioButtonMasculin
            // 
            this.guna2ImageRadioButtonMasculin.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.guna2ImageRadioButtonMasculin.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageRadioButtonMasculin.CheckedState.Parent = this.guna2ImageRadioButtonMasculin;
            this.guna2ImageRadioButtonMasculin.HoverState.Parent = this.guna2ImageRadioButtonMasculin;
            this.guna2ImageRadioButtonMasculin.Image = global::Proiect_PAW.Properties.Resources.man;
            this.guna2ImageRadioButtonMasculin.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageRadioButtonMasculin.IndicateFocus = false;
            this.guna2ImageRadioButtonMasculin.Location = new System.Drawing.Point(126, 40);
            this.guna2ImageRadioButtonMasculin.Name = "guna2ImageRadioButtonMasculin";
            this.guna2ImageRadioButtonMasculin.PressedState.Parent = this.guna2ImageRadioButtonMasculin;
            this.guna2ImageRadioButtonMasculin.Size = new System.Drawing.Size(60, 43);
            this.guna2ImageRadioButtonMasculin.TabIndex = 37;
            this.guna2ImageRadioButtonMasculin.UseTransparentBackground = true;
            // 
            // guna2ImageRadioButtonFeminin
            // 
            this.guna2ImageRadioButtonFeminin.CheckedState.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.guna2ImageRadioButtonFeminin.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageRadioButtonFeminin.CheckedState.Parent = this.guna2ImageRadioButtonFeminin;
            this.guna2ImageRadioButtonFeminin.HoverState.Parent = this.guna2ImageRadioButtonFeminin;
            this.guna2ImageRadioButtonFeminin.Image = global::Proiect_PAW.Properties.Resources.woman;
            this.guna2ImageRadioButtonFeminin.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageRadioButtonFeminin.IndicateFocus = false;
            this.guna2ImageRadioButtonFeminin.Location = new System.Drawing.Point(3, 40);
            this.guna2ImageRadioButtonFeminin.Name = "guna2ImageRadioButtonFeminin";
            this.guna2ImageRadioButtonFeminin.PressedState.Parent = this.guna2ImageRadioButtonFeminin;
            this.guna2ImageRadioButtonFeminin.Size = new System.Drawing.Size(59, 43);
            this.guna2ImageRadioButtonFeminin.TabIndex = 36;
            this.guna2ImageRadioButtonFeminin.UseTransparentBackground = true;
            // 
            // labelMasculin
            // 
            this.labelMasculin.AutoSize = true;
            this.labelMasculin.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasculin.Location = new System.Drawing.Point(179, 55);
            this.labelMasculin.Name = "labelMasculin";
            this.labelMasculin.Size = new System.Drawing.Size(66, 19);
            this.labelMasculin.TabIndex = 15;
            this.labelMasculin.Text = "Masculin";
            // 
            // labelFeminin
            // 
            this.labelFeminin.AutoSize = true;
            this.labelFeminin.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeminin.Location = new System.Drawing.Point(55, 55);
            this.labelFeminin.Name = "labelFeminin";
            this.labelFeminin.Size = new System.Drawing.Size(59, 19);
            this.labelFeminin.TabIndex = 14;
            this.labelFeminin.Text = "Feminin";
            // 
            // gunaaBtnCancel
            // 
            this.gunaaBtnCancel.Animated = true;
            this.gunaaBtnCancel.AutoRoundedCorners = true;
            this.gunaaBtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.gunaaBtnCancel.BorderColor = System.Drawing.Color.Navy;
            this.gunaaBtnCancel.BorderRadius = 32;
            this.gunaaBtnCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaaBtnCancel.BorderThickness = 2;
            this.gunaaBtnCancel.CheckedState.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.CustomImages.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.FillColor = System.Drawing.Color.Blue;
            this.gunaaBtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaaBtnCancel.ForeColor = System.Drawing.Color.Black;
            this.gunaaBtnCancel.HoverState.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.Image = global::Proiect_PAW.Properties.Resources.cancel;
            this.gunaaBtnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaaBtnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaaBtnCancel.Location = new System.Drawing.Point(189, 534);
            this.gunaaBtnCancel.Name = "gunaaBtnCancel";
            this.gunaaBtnCancel.ShadowDecoration.Parent = this.gunaaBtnCancel;
            this.gunaaBtnCancel.Size = new System.Drawing.Size(179, 67);
            this.gunaaBtnCancel.TabIndex = 4;
            this.gunaaBtnCancel.Text = "Anulare";
            this.gunaaBtnCancel.UseTransparentBackground = true;
            this.gunaaBtnCancel.Click += new System.EventHandler(this.gunaaBtnCancel_Click);
            // 
            // gunaBtnSalvare
            // 
            this.gunaBtnSalvare.Animated = true;
            this.gunaBtnSalvare.AutoRoundedCorners = true;
            this.gunaBtnSalvare.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnSalvare.BorderColor = System.Drawing.Color.Navy;
            this.gunaBtnSalvare.BorderRadius = 32;
            this.gunaBtnSalvare.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gunaBtnSalvare.BorderThickness = 2;
            this.gunaBtnSalvare.CheckedState.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.CustomImages.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.FillColor = System.Drawing.Color.Blue;
            this.gunaBtnSalvare.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaBtnSalvare.ForeColor = System.Drawing.Color.Black;
            this.gunaBtnSalvare.HoverState.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.Image = global::Proiect_PAW.Properties.Resources._checked;
            this.gunaBtnSalvare.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaBtnSalvare.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaBtnSalvare.Location = new System.Drawing.Point(416, 534);
            this.gunaBtnSalvare.Name = "gunaBtnSalvare";
            this.gunaBtnSalvare.ShadowDecoration.Parent = this.gunaBtnSalvare;
            this.gunaBtnSalvare.Size = new System.Drawing.Size(171, 67);
            this.gunaBtnSalvare.TabIndex = 5;
            this.gunaBtnSalvare.Text = "Salvare";
            this.gunaBtnSalvare.UseTransparentBackground = true;
            this.gunaBtnSalvare.Click += new System.EventHandler(this.gunaBtnSalvare_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Proiect_PAW.Properties.Resources.add;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(26, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // labelBara
            // 
            this.labelBara.AutoSize = true;
            this.labelBara.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBara.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBara.Location = new System.Drawing.Point(62, 17);
            this.labelBara.Name = "labelBara";
            this.labelBara.Size = new System.Drawing.Size(118, 19);
            this.labelBara.TabIndex = 15;
            this.labelBara.Text = "Adaugă Recenzor";
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
            this.gunaImgBtnX.Location = new System.Drawing.Point(775, 2);
            this.gunaImgBtnX.Name = "gunaImgBtnX";
            this.gunaImgBtnX.PressedState.ImageSize = new System.Drawing.Size(30, 25);
            this.gunaImgBtnX.PressedState.Parent = this.gunaImgBtnX;
            this.gunaImgBtnX.Size = new System.Drawing.Size(51, 34);
            this.gunaImgBtnX.TabIndex = 16;
            this.gunaImgBtnX.UseTransparentBackground = true;
            this.gunaImgBtnX.Click += new System.EventHandler(this.gunaImgBtnX_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FormAdd_Recenzor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(839, 727);
            this.Controls.Add(this.gunaImgBtnX);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.labelBara);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdd_Recenzor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugare Recenzor";
            this.Load += new System.EventHandler(this.FormAdd_Recenzor_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.gunaGbDatePersonale.ResumeLayout(false);
            this.gunaGbDatePersonale.PerformLayout();
            this.gunaGbSex.ResumeLayout(false);
            this.gunaGbSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label labelBara;
        private Guna.UI2.WinForms.Guna2ImageButton gunaImgBtnX;
        private Guna.UI2.WinForms.Guna2Button gunaaBtnCancel;
        private Guna.UI2.WinForms.Guna2Button gunaBtnSalvare;
        private Guna.UI2.WinForms.Guna2GroupBox gunaGbDatePersonale;
        private System.Windows.Forms.Label labelAni;
        private System.Windows.Forms.Label labelDataNasterii;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbNume;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbCodRecenzor;
        private System.Windows.Forms.Label labelCodRecenzor;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label labelNume;
        private Guna.UI2.WinForms.Guna2GroupBox gunaGbSex;
        private System.Windows.Forms.Label labelMasculin;
        private System.Windows.Forms.Label labelFeminin;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label labelRegiune;
        private Guna.UI2.WinForms.Guna2TextBox gunaTbLocalitate;
        private System.Windows.Forms.Label labelLocalitate;
        private System.Windows.Forms.Label labelJudet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaImgCkLocalitate;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaimgCkJudet;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaImgCkData;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaImgCkCNP;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaImgCkNume;
        private Guna.UI2.WinForms.Guna2ComboBox gunaCbJudet;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaCkImgRegiune;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gunaImgCkSex;
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
        private Guna.UI2.WinForms.Guna2ComboBox gunaCbRegiune;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButtonMasculin;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButtonFeminin;
    }
}