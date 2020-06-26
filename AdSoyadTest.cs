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
    public partial class AdSoyadTest : Form
    {

        public string ad, soyad, numara;
        Anasayfa form1;//anasayfa formu
        BoslukDoldurma bosluk;//bosluk doldurma
        Bitis bitis;
       

  
        public AdSoyadTest()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)//ad
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//anasayfa butonu
        {
            form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//devam et butonu
        {
            bosluk = new BoslukDoldurma();
            ad = Convert.ToString(textBox1.Text);
            soyad = Convert.ToString(textBox2.Text);
            numara = textBox3.Text;


        bool allDigits = numara.All(char.IsDigit);

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || !allDigits)//textboxlar boş bırakıldıysa hata mesajı döndürülür.
            {

                if (!allDigits)//eger numara yazilardan olustuysa ife gir
                {
                    string mesaj = "Numara Yalnızca Rakamlardan Oluşabilir.";
                    string bilgi = "Lütfen numaranızı düzgün bir şekilde giriniz.";
                    MessageBoxButtons buttonlar = MessageBoxButtons.OK;
                    DialogResult sonuc;

                    // Messagebox gösterilir.
                    sonuc = MessageBox.Show(mesaj, bilgi, buttonlar);
                    if (sonuc == System.Windows.Forms.DialogResult.OK)
                    {
                        AdSoyadTest test = new AdSoyadTest();
                        test.Show();
                        this.Close();


                    }
                }
                else if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))//eger biri bos bırakıldıysa
                {
                    string message = "Lütfen boş bıraktığınız yerleri doldurunuz.";
                    string caption = "Ad,soyad veya numara boş bırakılamaz.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Messagebox gösterilir.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.No)//no dediyse anasayfaya dön
                    {
                        form1 = new Anasayfa();
                        form1.Show();
                        this.Close();
                    }
                }
                
            }
            else//her sey dogru girildiyse boslukdoldurma formunu ac
            {
               
                bitis = new Bitis(ad);
                bosluk.ad = ad;
                bosluk.soyad=soyad;

                bosluk.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
                 
 }

