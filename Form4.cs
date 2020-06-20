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
    public partial class Form4 : Form
    {
        Form1 form1;
        Form5 form5;//ilk test sayfası
        public string ad, soyad, numara;
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)//ad
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//devam et butonu
        {
            form5 = new Form5();
            ad = textBox1.Text;
            soyad = textBox2.Text;
            numara = textBox3.Text;
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))//textboxlar boş bırakıldıysa hata mesajı döndürülür.
            {
                string message = "Lütfen boş bıraktığınız yerleri doldurunuz.";
                string caption = "Ad,soyad veya numara boş bırakılamaz.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Messagebox gösterilir.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
            }
            else 
            {
                form5.ad = textBox1.Text;
                form5.soyad = textBox2.Text;
                form5.numara = textBox3.Text;
                form5.Show();
                this.Hide();
            }
        }
       
    }
}
