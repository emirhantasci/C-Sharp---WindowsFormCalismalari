using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ile_Aktarma
{
    public partial class Form1 : Form
    {
        int y = 0;
        public Form1()
        {
            InitializeComponent();

            int y = 0;
            do
            {
                comboBox1.Items.Add(y);
                y = y + 1;
            } while (y <= 10);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
