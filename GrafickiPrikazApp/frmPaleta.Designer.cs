namespace GrafickiPrikazApp
{
    partial class frmPaleta
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
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(12, 51);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 22);
            this.txtSifra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 112);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(315, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "J.M.";
            // 
            // txtJM
            // 
            this.txtJM.Location = new System.Drawing.Point(12, 176);
            this.txtJM.Name = "txtJM";
            this.txtJM.Size = new System.Drawing.Size(100, 22);
            this.txtJM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kolicina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(12, 241);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtKolicina.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kod";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(12, 305);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(100, 22);
            this.txtKod.TabIndex = 8;
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdOK.Location = new System.Drawing.Point(222, 228);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(105, 35);
            this.cmdOK.TabIndex = 10;
            this.cmdOK.Text = "Prihvati";
            this.cmdOK.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(222, 292);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(105, 35);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Odustani";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // frmPaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(357, 367);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPaleta";
            this.Text = "Paleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
    }
}