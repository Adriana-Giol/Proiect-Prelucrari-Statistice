namespace Recensamant
{
    partial class Form1_Recenzati_Persoana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Recenzati_Persoana));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Nume = new System.Windows.Forms.Label();
            this.label_Prenume = new System.Windows.Forms.Label();
            this.label_CNP = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label_Sex = new System.Windows.Forms.Label();
            this.label_DataNasteri = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.golireFormularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Anulare = new System.Windows.Forms.Button();
            this.btn_NextLocuinta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTextToolStripMenuItem,
            this.fisierBinarToolStripMenuItem});
            resources.ApplyResources(this.salvareToolStripMenuItem, "salvareToolStripMenuItem");
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            resources.ApplyResources(this.fisierTextToolStripMenuItem, "fisierTextToolStripMenuItem");
            this.fisierTextToolStripMenuItem.Click += new System.EventHandler(this.fisierTextToolStripMenuItem_Click);
            // 
            // fisierBinarToolStripMenuItem
            // 
            this.fisierBinarToolStripMenuItem.Name = "fisierBinarToolStripMenuItem";
            resources.ApplyResources(this.fisierBinarToolStripMenuItem, "fisierBinarToolStripMenuItem");
            this.fisierBinarToolStripMenuItem.Click += new System.EventHandler(this.fisierBinarToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTextToolStripMenuItem1,
            this.fisierBinarToolStripMenuItem1});
            resources.ApplyResources(this.restaurareToolStripMenuItem, "restaurareToolStripMenuItem");
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            // 
            // fisierTextToolStripMenuItem1
            // 
            this.fisierTextToolStripMenuItem1.Name = "fisierTextToolStripMenuItem1";
            resources.ApplyResources(this.fisierTextToolStripMenuItem1, "fisierTextToolStripMenuItem1");
            this.fisierTextToolStripMenuItem1.Click += new System.EventHandler(this.fisierTextToolStripMenuItem1_Click);
            // 
            // fisierBinarToolStripMenuItem1
            // 
            this.fisierBinarToolStripMenuItem1.Name = "fisierBinarToolStripMenuItem1";
            resources.ApplyResources(this.fisierBinarToolStripMenuItem1, "fisierBinarToolStripMenuItem1");
            // 
            // label_Nume
            // 
            resources.ApplyResources(this.label_Nume, "label_Nume");
            this.label_Nume.Name = "label_Nume";
            // 
            // label_Prenume
            // 
            resources.ApplyResources(this.label_Prenume, "label_Prenume");
            this.label_Prenume.Name = "label_Prenume";
            // 
            // label_CNP
            // 
            resources.ApplyResources(this.label_CNP, "label_CNP");
            this.label_CNP.Name = "label_CNP";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            resources.GetString("cbSex.Items"),
            resources.GetString("cbSex.Items1")});
            resources.ApplyResources(this.cbSex, "cbSex");
            this.cbSex.Name = "cbSex";
            // 
            // label_Sex
            // 
            resources.ApplyResources(this.label_Sex, "label_Sex");
            this.label_Sex.Name = "label_Sex";
            // 
            // label_DataNasteri
            // 
            resources.ApplyResources(this.label_DataNasteri, "label_DataNasteri");
            this.label_DataNasteri.Name = "label_DataNasteri";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // tbNume
            // 
            resources.ApplyResources(this.tbNume, "tbNume");
            this.tbNume.Name = "tbNume";
            // 
            // tbPrenume
            // 
            resources.ApplyResources(this.tbPrenume, "tbPrenume");
            this.tbPrenume.Name = "tbPrenume";
            // 
            // tbCNP
            // 
            resources.ApplyResources(this.tbCNP, "tbCNP");
            this.tbCNP.Name = "tbCNP";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.golireFormularToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // golireFormularToolStripMenuItem
            // 
            this.golireFormularToolStripMenuItem.Name = "golireFormularToolStripMenuItem";
            resources.ApplyResources(this.golireFormularToolStripMenuItem, "golireFormularToolStripMenuItem");
            this.golireFormularToolStripMenuItem.Click += new System.EventHandler(this.golireFormularToolStripMenuItem_Click);
            // 
            // btn_Anulare
            // 
            this.btn_Anulare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(156)))), ((int)(((byte)(217)))));
            resources.ApplyResources(this.btn_Anulare, "btn_Anulare");
            this.btn_Anulare.Name = "btn_Anulare";
            this.btn_Anulare.UseVisualStyleBackColor = true;
            this.btn_Anulare.Click += new System.EventHandler(this.btn_Anulare_Click);
            // 
            // btn_NextLocuinta
            // 
            this.btn_NextLocuinta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(156)))), ((int)(((byte)(217)))));
            resources.ApplyResources(this.btn_NextLocuinta, "btn_NextLocuinta");
            this.btn_NextLocuinta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_NextLocuinta.Name = "btn_NextLocuinta";
            this.btn_NextLocuinta.UseVisualStyleBackColor = true;
            // 
            // Form1_Recenzati_Persoana
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(156)))), ((int)(((byte)(217)))));
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_NextLocuinta);
            this.Controls.Add(this.btn_Anulare);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_DataNasteri);
            this.Controls.Add(this.label_Sex);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label_CNP);
            this.Controls.Add(this.label_Prenume);
            this.Controls.Add(this.label_Nume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1_Recenzati_Persoana";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarToolStripMenuItem1;
        private System.Windows.Forms.Label label_Nume;
        private System.Windows.Forms.Label label_Prenume;
        private System.Windows.Forms.Label label_CNP;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.Label label_DataNasteri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_NextLocuinta;
        private System.Windows.Forms.Button btn_Anulare;
        private System.Windows.Forms.ToolStripMenuItem golireFormularToolStripMenuItem;
    }
}