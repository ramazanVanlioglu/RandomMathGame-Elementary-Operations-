using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {

        List<string> Isaretler = new List<string>()
        {
            "+","-","x","/"
        };
        Random random = new Random();
        public string hesapIsareti { get; set; }

        public float sayi1 { get; set; }

        public float sayi2 { get; set; }

        public float toplam { get; set; }

        public short x = 0;//Doğrular için.
        public short y = 0;//Hatalar için.
        public Form1()
        {
            InitializeComponent();
        }

        public void RastgeleHesapMetodu()
        {
            sayi1 = random.Next(1, 101);
            sayi2 = random.Next(1, 101);
            lbl_sayi1.Text = sayi1.ToString();
            lbl_sayi2.Text = sayi2.ToString();
            hesapIsareti = Isaretler[random.Next(0, Isaretler.Count)];
            switch (hesapIsareti)
            {
                case "+":
                    lbl_sonuc.Text = (sayi1 + sayi2).ToString();
                    break;
                case "-":
                    lbl_sonuc.Text = (sayi1 - sayi2).ToString();
                    break;

                case "x":
                    lbl_sonuc.Text = (sayi1 * sayi2).ToString();
                    break;
                case "/":
                    lbl_sonuc.Text = (sayi1 / sayi2).ToString();
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_dogrular.Text = "Doğrular: 0";
            label_hatalar.Text = "Hatalar: 0";
            RastgeleHesapMetodu();

        }

        private void KapansinMi(object sender, FormClosingEventArgs e)
        {
            DialogResult karar = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (karar == DialogResult.Yes)
            {
                MessageBox.Show("Uygulamadan çıkılıyor", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                e.Cancel = true;// Formun kapanmasını engeller. Müthiş. 1.06.23, 15.05
            }
        }

        private void button_bolme_Click(object sender, EventArgs e)
        {

            if (button_bolme.Tag.ToString() == hesapIsareti)
            {
                x++;
                label_dogrular.Text = "Doğrular:" + x;
            }
            else
            {
                y++;
                label_hatalar.Text = "Hatalar:" + y;
            }
            RastgeleHesapMetodu();
        }

        private void button_carpma_Click(object sender, EventArgs e)
        {
            if (button_carpma.Tag.ToString() == hesapIsareti)
            {
                x++;
                label_dogrular.Text = "Doğrular:" + x;
            }
            else
            {
                y++;
                label_hatalar.Text = "Hatalar:" + y;
            }
            RastgeleHesapMetodu();
        }

        private void button_cikarma_Click(object sender, EventArgs e)
        {
            if (button_cikarma.Tag.ToString() == hesapIsareti)
            {
                x++;
                label_dogrular.Text = "Doğrular:" + x;
            }
            else
            {
                y++;
                label_hatalar.Text = "Hatalar:" + y;
            }
            RastgeleHesapMetodu();
        }

        private void button_toplama_Click(object sender, EventArgs e)
        {
            if (button_toplama.Tag.ToString() == hesapIsareti)
            {
                x++;
                label_dogrular.Text = "Doğrular:" + x;
            }
            else
            {
                y++;
                label_hatalar.Text = "Hatalar:" + y;
            }
            RastgeleHesapMetodu();
        }
    }
}
