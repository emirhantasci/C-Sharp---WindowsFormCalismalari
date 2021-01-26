using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListÇalışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Items.Add("Emir");
            listView1.Items.Add("Arda");
            listView1.Items.Add("Asel");
            listView1.Items.Add("Sema");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                label1.Text = selectedItem.Text;
                selectedItem.Remove();
                break; // remove it if you have multiple selection but you need thread as well with Thread.Sleep.
            }
        }

     
    }
}
