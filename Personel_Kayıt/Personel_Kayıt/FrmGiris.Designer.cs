namespace Personel_Kayıt
{
    partial class FrmGiris
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
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKullanıcıAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BorderRadius = 8;
            this.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(192, 213);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(229, 51);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Giriş";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Giriş Paneli";
            // 
            // TxtKullanıcıAd
            // 
            this.TxtKullanıcıAd.BorderColor = System.Drawing.Color.Black;
            this.TxtKullanıcıAd.BorderRadius = 8;
            this.TxtKullanıcıAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtKullanıcıAd.DefaultText = "";
            this.TxtKullanıcıAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtKullanıcıAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtKullanıcıAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtKullanıcıAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtKullanıcıAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtKullanıcıAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanıcıAd.ForeColor = System.Drawing.Color.Black;
            this.TxtKullanıcıAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtKullanıcıAd.Location = new System.Drawing.Point(192, 76);
            this.TxtKullanıcıAd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtKullanıcıAd.Name = "TxtKullanıcıAd";
            this.TxtKullanıcıAd.PasswordChar = '\0';
            this.TxtKullanıcıAd.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtKullanıcıAd.PlaceholderText = "";
            this.TxtKullanıcıAd.SelectedText = "";
            this.TxtKullanıcıAd.Size = new System.Drawing.Size(227, 48);
            this.TxtKullanıcıAd.TabIndex = 4;
            // 
            // TxtSifre
            // 
            this.TxtSifre.BorderColor = System.Drawing.Color.Black;
            this.TxtSifre.BorderRadius = 8;
            this.TxtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSifre.DefaultText = "";
            this.TxtSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.ForeColor = System.Drawing.Color.Black;
            this.TxtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSifre.Location = new System.Drawing.Point(192, 143);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.PlaceholderText = "";
            this.TxtSifre.SelectedText = "";
            this.TxtSifre.Size = new System.Drawing.Size(227, 48);
            this.TxtSifre.TabIndex = 5;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(529, 294);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullanıcıAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtKullanıcıAd;
        private Guna.UI2.WinForms.Guna2TextBox TxtSifre;
    }
}