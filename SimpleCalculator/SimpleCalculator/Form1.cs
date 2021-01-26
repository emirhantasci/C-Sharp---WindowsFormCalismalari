using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double deger1, deger2;
        double sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btnToplama_Click(object sender, EventArgs e)
        {
            deger1 = double.Parse(textBox1.Text);
            deger2 = double.Parse(textBox2.Text);
            sonuc = deger1 + deger2;
            lblSonuc.Text=Convert.ToString(sonuc);

        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            deger1 = double.Parse(textBox1.Text);
            deger2 = double.Parse(textBox2.Text);
            sonuc = deger1 - deger2;
            lblSonuc.Text=Convert.ToString(sonuc);
            
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            deger1 = double.Parse(textBox1.Text);
            deger2 = double.Parse(textBox2.Text);
            sonuc = deger1 * deger2;
            lblSonuc.Text=Convert.ToString(sonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deger1 = double.Parse(textBox1.Text);
            deger2 = double.Parse(textBox2.Text);
            sonuc = deger1 / deger2;
            lblSonuc.Text =Convert.ToString(sonuc);
        }
    }
}
