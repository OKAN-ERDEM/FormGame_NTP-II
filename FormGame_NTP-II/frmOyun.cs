using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGame_NTP_II
{
    public partial class frmOyun : Form
    {
        Random rnd = new Random();

        //Game
        int skor;//skor
        int sure;//zaman
        int hiz;//butonların hızı



        public frmOyun(byte zorluk, string ad, string soyad)
        {
            InitializeComponent();
            lblAd.Text = ad.ToUpper();
            lblSoyad.Text = soyad.ToUpper();

            switch (zorluk)
            {
                case 0://kolay
                    sure = 20;
                    hiz = 1000;
                    break;

                case 1://orta
                    sure = 15;
                    hiz = 750;
                    break;

                case 2://zor
                    sure = 10;
                    hiz = 500;
                    break;
            }
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            skor += int.Parse(btn.Text);
            lblSkor.Text = skor.ToString();
            btn.Visible = false;
        }

        private void frmOyun_Load(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();

            tmrButton.Interval = hiz;
        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();

            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlOyun.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Size = new Size(rnd.Next(20, 100), 50);
            btn.Text = rnd.Next(1, 100).ToString();

            //btn.Location = new Point(rnd.Next(Math.Abs(this.ClientSize.Width - btn.Width)), rnd.Next(Math.Abs(this.ClientSize.Height - (btn.Height + pnlOyun.Height))));

            btn.Click += buttonClick;

            this.Controls.Add(btn);

        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            lblSure.Text = (sure).ToString();
            if (sure == 0)
            {
                tmrButton.Stop();
                tmrSure.Stop();
                MessageBox.Show("Oyun Bitti! Skorunuz: " + skor);

                string txt = @"C:\Users\HP\Desktop\III.-\NTP-II\FormGame.txt";
                FileStream fs = new FileStream(txt, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(lblAd.Text + " " + lblSoyad + " - Skor:" + skor.ToString());
                sw.Flush();
                sw.Close();
                fs.Close();

                this.Close();
            }
            else
            {
                sure--;
            }
        }
    }
}
