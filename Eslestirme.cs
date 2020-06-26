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
    public partial class Eslestirme : Form
    {

 
        Test test;
        int[] buttonClicklist = new int[12];
        int sayac = 0;

        public Eslestirme()
        {
            InitializeComponent();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//güç kaynağı yazı butonu
        {

            buttonClicklist[0] = 1;
            if (buttonClicklist[0] == 1 && buttonClicklist[7] == 1)
            {
                pictureBox1.Visible = true;
                pictureBox8.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();

        }

        private void button3_Click(object sender, EventArgs e)//ekran kartı yazı butonu
        {
            buttonClicklist[2] = 1;
            if (buttonClicklist[2] == 1 && buttonClicklist[6] == 1)
            {
                pictureBox3.Visible = true;
                pictureBox7.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void oyunkontrol()
        {
            if (sayac == 6)// sayaç 6 gelince otomatik bitirme.
            {
                string message = "Tebrikler eşleştirmeyi başarıyla tamamladınız.\n";

                string caption = "Başarılı oldunuz!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Messagebox gösterilir.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    test = new Test();
                    test.Show();
                    this.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)//ekran kartı resim butonu
        {
            buttonClicklist[6] = 1;
            if (buttonClicklist[2] == 1 && buttonClicklist[6] == 1)
            {
                pictureBox3.Visible = true;
                pictureBox7.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();


        }

        private void button8_Click(object sender, EventArgs e)//güç kaynağı resim butonu
        {

            buttonClicklist[7] = 1;
            if (buttonClicklist[2] == 1 && buttonClicklist[7] == 1)
            {
                pictureBox3.Visible = true;
                pictureBox8.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void button6_Click(object sender, EventArgs e)//işlemci yazı butonu
        {
            buttonClicklist[5] = 1;
            if (buttonClicklist[5] == 1 && buttonClicklist[8] == 1)
            {
                pictureBox6.Visible = true;
                pictureBox9.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void button9_Click(object sender, EventArgs e)//işlemci resim butonu
        {
            buttonClicklist[8] = 1;
            if (buttonClicklist[5] == 1 && buttonClicklist[8] == 1)
            {
                pictureBox6.Visible = true;
                pictureBox9.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void button2_Click(object sender, EventArgs e)//ram yazı butonu
        {
            buttonClicklist[1] = 1;
            if (buttonClicklist[1] == 1 && buttonClicklist[9] == 1)
            {
                pictureBox2.Visible = true;
                pictureBox10.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void button10_Click(object sender, EventArgs e)//ram resim butonu
        {
            buttonClicklist[9] = 1;
            if (buttonClicklist[1] == 1 && buttonClicklist[9] == 1)
            {
                pictureBox2.Visible = true;
                pictureBox10.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void button4_Click(object sender, EventArgs e)//Sabit disk yazı butonu
        {
            buttonClicklist[3] = 1;
            if (buttonClicklist[3] == 1 && buttonClicklist[10] == 1)
            {
                pictureBox4.Visible = true;
                pictureBox11.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void button11_Click(object sender, EventArgs e)//Sabit disk resim butonu
        {
            buttonClicklist[10] = 1;
            if (buttonClicklist[3] == 1 && buttonClicklist[10] == 1)
            {
                pictureBox4.Visible = true;
                pictureBox11.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonClicklist[4] = 1;//anakart yazı
            if (buttonClicklist[4] == 1 && buttonClicklist[11] == 1)
            {
                pictureBox5.Visible = true;
                pictureBox12.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonClicklist[11] = 1;//anakart resim 
            if (buttonClicklist[4] == 1 && buttonClicklist[11] == 1)
            {
                pictureBox5.Visible = true;
                pictureBox12.Visible = true;
                Array.Clear(buttonClicklist, 0, 12);
                sayac++;
            }
            oyunkontrol();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
