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
    
    public partial class Bitis : Form
    {
        Anasayfa anasayfa;
        string ad;

        public Bitis(string _ad)
        {
           
            InitializeComponent();
            this.ad = _ad;
           
        }

        public Bitis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//anasayfaya dön butonu
        {
           
            anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//çıkış butonu
        {
            Application.Exit();
        }

        private void Bitis_Load(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
