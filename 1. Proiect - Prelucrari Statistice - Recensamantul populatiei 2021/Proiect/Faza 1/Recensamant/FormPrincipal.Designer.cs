namespace Recensamant
{
    partial class FormPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Recenzori = new System.Windows.Forms.Button();
            this.btn_Recenzati = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.btn_Recenzori);
            this.panel1.Controls.Add(this.btn_Recenzati);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 559);
            this.panel1.TabIndex = 0;
            // 
            // btn_Recenzori
            // 
            this.btn_Recenzori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recenzori.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recenzori.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Recenzori.Location = new System.Drawing.Point(17, 229);
            this.btn_Recenzori.Name = "btn_Recenzori";
            this.btn_Recenzori.Size = new System.Drawing.Size(178, 67);
            this.btn_Recenzori.TabIndex = 1;
            this.btn_Recenzori.Text = "Recenzori";
            this.btn_Recenzori.UseVisualStyleBackColor = true;
            // 
            // btn_Recenzati
            // 
            this.btn_Recenzati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recenzati.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recenzati.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Recenzati.Location = new System.Drawing.Point(17, 132);
            this.btn_Recenzati.Name = "btn_Recenzati";
            this.btn_Recenzati.Size = new System.Drawing.Size(178, 67);
            this.btn_Recenzati.TabIndex = 0;
            this.btn_Recenzati.Text = "Persoane Recenzate";
            this.btn_Recenzati.UseVisualStyleBackColor = true;
            this.btn_Recenzati.Click += new System.EventHandler(this.btn_Recenzati_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(156)))), ((int)(((byte)(217)))));
            this.panel2.Location = new System.Drawing.Point(196, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 556);
            this.panel2.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Recenzati;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Recenzori;
    }
}

