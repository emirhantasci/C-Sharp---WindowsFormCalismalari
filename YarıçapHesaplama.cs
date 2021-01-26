using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double pi = 3.14;
        double sonuc, r;



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            r = double.Parse(txtYaricap.Text);
            sonuc = pi * 2 * r;
            txtSonuc.Text=(Convert.ToString(sonuc));
        }
    }
}
