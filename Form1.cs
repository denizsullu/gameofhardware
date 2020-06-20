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
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        Form4 form4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void eslestirmebutton_Click(object sender, EventArgs e)
        {

        }
        private void yerlestirmebutton_Click(object sender, EventArgs e)//yerlestirme butonuna basildiğinda gerceklesecek islemler.
        {
            form3 = new Form3();//yeni form acilir.
            form3.Show();//form gösterilir.
            this.Hide();//su an bulunan form gizlenir.
        }


        private void testbutton_Click(object sender, EventArgs e)//test butonuna bastiginda gerceklesecek islemler.
        {
            form4 = new Form4();
            form4.Show();
            this.Hide();

        }


        private void button1_Click_1(object sender, EventArgs e)//hazirlayanalr butonu.
        {
            form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
