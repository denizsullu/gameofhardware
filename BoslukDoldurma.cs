using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deniz
{
    public partial class BoslukDoldurma : Form
    {
        Eslestirme eslestir;
        int[] dogru;
        string metin;
        public string ad, soyad, numara;
        public BoslukDoldurma()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//anakart
        {
            metin = textBox1.Text;
            metin = metin.ToLower();
            metin = metin.Trim();
            if (metin == "anakart") { pictureBox7.Visible = true;dogru[0] = 1; label34.Visible = true; }
            if (metin != "anakart") { pictureBox7.Visible = false;dogru[0] = 0; label34.Visible = false; }
            oyunKontrol(dogru);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//işlemci
        {
            metin = textBox2.Text;
            metin = metin.ToLower();
            metin = metin.Trim();
            if (metin == "işlemci") { pictureBox8.Visible = true; dogru[1] = 1; label31.Visible = true; }
            if (metin != "işlemci") { pictureBox8.Visible = false; dogru[1] = 0; label31.Visible = false; }
            oyunKontrol(dogru);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//harddisk
        {
            metin = textBox3.Text;
            metin = metin.ToLower();
            metin = metin.Trim();
            if (metin == "harddisk" || metin == "hard disk" || metin=="hard-disk") { pictureBox9.Visible = true; dogru[2] = 1; label35.Visible = true; }
            if (metin != "harddisk" &&  metin != "hard disk" && metin != "hard-disk") { pictureBox9.Visible = false; dogru[2] = 0; label35.Visible = false; }
            oyunKontrol(dogru);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//ekrankartı
        {
            metin = textBox4.Text;
            metin = metin.ToLower();
            metin = metin.Trim();
            if (metin == "ekran kartı" || metin == "ekrankartı") { pictureBox10.Visible = true; dogru[3] = 1; label33.Visible = true; }
            if (metin != "ekran kartı" && metin != "ekrankartı") { pictureBox10.Visible = false; dogru[3] = 0; label33.Visible = false; }
            oyunKontrol(dogru);
        }

        private void BoslukDoldurma_Load(object sender, EventArgs e)//aldığımız adı yazdırma.
        {
            dogru = new int[6];
            label28.Text = ad + " " + soyad + " sınavınız başlamış bulunmaktadır!";
            
        }

        void oyunKontrol(int[] dogru)
        {
            int sayac = 0;
            for(int x=0;x<dogru.Length;x++)
            {
                if (dogru[x] == 1)
                {
                    sayac++;
                }
            }
            if(sayac==dogru.Length)
            {
                string message = "Tebrikler eşleştirmeyi başarıyla tamamladınız.\n";

                string caption = "Başarılı oldunuz!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Messagebox gösterilir.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    eslestir = new Eslestirme();
                    eslestir.Show();
                    this.Hide();
                }
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//ram
        {
            metin = textBox5.Text;
            metin = metin.ToLower();
            metin = metin.Trim();
            if (metin == "ram" ) { pictureBox11.Visible = true; dogru[4] = 1; label30.Visible = true; }
            if (metin != "ram") { pictureBox11.Visible = false; dogru[4] = 0; label30.Visible = false; }
            oyunKontrol(dogru);
        }

     

        private void textBox7_TextChanged(object sender, EventArgs e)//monitör
        {
            metin = textBox7.Text;
            metin = metin.ToLower();
            metin = metin.Trim();
            if (metin == "monitör" ) { pictureBox13.Visible = true; dogru[5] = 1; label32.Visible = true; }
            if (metin != "monitör") { pictureBox13.Visible = false; dogru[5] = 0; label32.Visible = false; }
            oyunKontrol(dogru);
        }

    }
}
