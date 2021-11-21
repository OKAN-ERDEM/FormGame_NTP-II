using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGame_NTP_II
{// 193801025 - OKAN ERDEM
    // Kullanıcının zorluk seçimine göre 

    public partial class frmGiris : Form
    {
        byte zorluk; //değişken; zorluk seviyelerini almak için
        public frmGiris()
        {
            InitializeComponent();
        }
        
        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurmak zorunludur..!");
            }
            else
            {//farklı zorluk seviyeleri için
                if (rbKolay.Checked)
                {
                    zorluk = 0;
                }
                else if (rbOrta.Checked)
                {
                    zorluk = 1;
                }
                else if (rbZor.Checked)
                {
                    zorluk = 2;
                }
                else 
                {
                    MessageBox.Show("Zorluk seviyesi seçiniz.");
                }

                frmOyun frm = new frmOyun(zorluk, txtAd.Text, txtSoyad.Text);
                frm.Show();
            }
        }
    }
}
