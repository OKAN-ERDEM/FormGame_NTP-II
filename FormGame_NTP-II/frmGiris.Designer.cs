namespace FormGame_NTP_II
{
    partial class frmGiris
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.btnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(109, 106);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 17);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "AD :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(80, 160);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(64, 17);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "SOYAD :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(220, 106);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(172, 22);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(220, 160);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(172, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Location = new System.Drawing.Point(112, 233);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(64, 21);
            this.rbKolay.TabIndex = 4;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay";
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Location = new System.Drawing.Point(341, 233);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(51, 21);
            this.rbZor.TabIndex = 5;
            this.rbZor.TabStop = true;
            this.rbZor.Text = "Zor";
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(233, 233);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(57, 21);
            this.rbOrta.TabIndex = 6;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(190, 300);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(150, 25);
            this.btnBasla.TabIndex = 7;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 403);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbZor);
            this.Controls.Add(this.rbKolay);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.Button btnBasla;
    }
}

