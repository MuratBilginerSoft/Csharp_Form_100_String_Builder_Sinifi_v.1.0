using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace String_Builder_Sinifi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime1=textBox1.Text; // kelime değişenimize string ifademizi aldık.

            StringBuilder sb = new StringBuilder(); // işte nesne tanımalamamız.

            sb.Append(kelime1);

            label3.Text = sb.ToString(); // ve label a yazdırma işlemi.
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            int i; 
            
            string başlangıc, bitiş1; // başlangıç ve bitiş sürelerini tutacak değişkenimiz.

            string yazı = "";

            başlangıc = DateTime.Now.ToLongTimeString(); // başlangıç zamanını aldık.

            label5.Text = başlangıc; // başlakngıç zamanını gerekli label a yazdırdık.
           

            for ( i = 0; i < 50000; i++) // dikkat edelim burdaki döngümüz ellibin kere dönecek.
            {
                yazı = yazı+i.ToString(); // her defasında yazı değişkenimize yeni değerini yazdık.
            }

            bitiş1 = DateTime.Now.ToLongTimeString(); // bitiş zamanını aldık.

            label7.Text = bitiş1; // label a yazdık.

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int j;

            string başlangıc2,  bitiş2;

            başlangıc2 = DateTime.Now.ToLongTimeString();

            label12.Text = başlangıc2;

            StringBuilder sb2 = new StringBuilder(); // nesnemizi tanımladık.

            for (j = 0; j < 5000000; j++) // dikkat edelim bu döngümüz ise beş milyon kere dönecek.
            {
                sb2.Append(j.ToString()); // append metodu ile stringbuilder içine atama yaptık.
            }

            bitiş2 = DateTime.Now.ToLongTimeString();
            label10.Text = bitiş2;
        }
    }
}
