using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolenToplamları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int BolenAdet = 0;
            int Bolen=Convert.ToInt32(txtBolen.Text);
            for (int i = 1; i < Convert.ToInt32(txtBolunen.Text); i++)
            {
                if (i % Bolen == 0)
                {
                    BolenAdet++;
                    lblBolenSayisi.Text = BolenAdet.ToString();
                    toplam += i;
                    lblToplam.Text = toplam.ToString();
                }
            }
        }
    }
}
