namespace FormGame_NTP_II
{
    partial class frmOyun
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
            this.pnlOyun = new System.Windows.Forms.Panel();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lbl_KA = new System.Windows.Forms.Label();
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.pnlOyun.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOyun
            // 
            this.pnlOyun.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlOyun.Controls.Add(this.lblSkor);
            this.pnlOyun.Controls.Add(this.lblSure);
            this.pnlOyun.Controls.Add(this.label2);
            this.pnlOyun.Controls.Add(this.label1);
            this.pnlOyun.Controls.Add(this.lblSoyad);
            this.pnlOyun.Controls.Add(this.lblAd);
            this.pnlOyun.Controls.Add(this.lbl_KA);
            this.pnlOyun.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOyun.Location = new System.Drawing.Point(617, 0);
            this.pnlOyun.Name = "pnlOyun";
            this.pnlOyun.Size = new System.Drawing.Size(165, 503);
            this.pnlOyun.TabIndex = 0;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Lavender;
            this.lblSoyad.Location = new System.Drawing.Point(41, 129);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(18, 19);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "-";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Lavender;
            this.lblAd.Location = new System.Drawing.Point(41, 110);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(18, 19);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "-";
            // 
            // lbl_KA
            // 
            this.lbl_KA.AutoSize = true;
            this.lbl_KA.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KA.ForeColor = System.Drawing.Color.Gold;
            this.lbl_KA.Location = new System.Drawing.Point(40, 54);
            this.lbl_KA.Name = "lbl_KA";
            this.lbl_KA.Size = new System.Drawing.Size(100, 29);
            this.lbl_KA.TabIndex = 0;
            this.lbl_KA.Text = "OYUNCU";
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 1000;
            this.tmrButton.Tick += new System.EventHandler(this.tmrButton_Tick);
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(40, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "SÜRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(40, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "SKOR";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.Lavender;
            this.lblSure.Location = new System.Drawing.Point(41, 246);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(18, 19);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "-";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.ForeColor = System.Drawing.Color.Lavender;
            this.lblSkor.Location = new System.Drawing.Point(41, 366);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(18, 19);
            this.lblSkor.TabIndex = 6;
            this.lblSkor.Text = "-";
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnlOyun);
            this.Name = "frmOyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOyun";
            this.Load += new System.EventHandler(this.frmOyun_Load);
            this.pnlOyun.ResumeLayout(false);
            this.pnlOyun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOyun;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lbl_KA;
        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}