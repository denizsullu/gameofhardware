using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deniz
{
    public partial class Anasayfa : Form
    {
        Hazirlayanlar form2;//hazirlayanlar
        AdSoyadTest form4;//adsoyad acilacak
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void testbutton_Click(object sender, EventArgs e)//ad soyad butonu
        {
            form4 = new AdSoyadTest();
            form4.Show();
            this.Hide();

        }


        private void button1_Click_1(object sender, EventArgs e)//hazirlayanalr butonu.
        {
            form2 = new Hazirlayanlar();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
