using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace class_çalışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void labelegecirme()
        {
            label2.Text = iphone.Model;                                 //bu kısım def yani fonksiyonum bunu bi kısaltma yol olarak düşünebiliriz
            label3.Text = iphone.Ram.ToString();
            label5.Text = iphone.Hz.ToString();
            label8.Text = iphone.Jarjsuresi.ToString() + "saat";



        }
        telefon iphone =new telefon();
        private void button1_Click(object sender, EventArgs e)
        {
            iphone = new telefon(); //bu kısımda classımın içinde  hayali bir obje açıyorum
           
           
                iphone.Hz = Convert.ToInt32(textBox3.Text);
                iphone.Ram = Convert.ToInt32(textBox2.Text);
                iphone.Jarjsuresi = Convert.ToInt32(textBox4.Text); //bu kısımda textbox ları değişkenlere atıyorum
                iphone.Model = textBox1.Text;
            MessageBox.Show("telefon üretildi");
                labelegecirme();
                                


        }
        int sayac = 0;
        private void label13_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {
                panel1.Visible = false;
                sayac = 0;                          //burada ise panel bileşeninden açılır kapanır bir pencere yapıyorum
            
            }
            else if (sayac==1)
                panel1.Visible=true;
        }
    }
}
