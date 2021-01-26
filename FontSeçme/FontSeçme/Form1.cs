using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontSeçme
{
    public partial class Form1 : Form
    {
        int secim = 14;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            FontFamily[] fontral = FontFamily.Families;
            for(int i =0; i <= fontral.GetUpperBound(0); i++)
            {
                listBox1.Items.Add(fontral[i].Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Regular);
                
            }
            catch
            {
                MessageBox.Show("Hata");
                throw;
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            string ad;
            ad = listBox1.Items[e.Index].ToString();
            try
            {
                e.Graphics.DrawString(ad, new Font(ad, 12,FontStyle.Regular), new SolidBrush(Color.Black), e.Bounds.Left, e.Bounds.Top);
            }
            catch
            {
                throw;
            }
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            Font fnt;
            string ad = listBox1.Items[e.Index].ToString();
            try
            {
                fnt = new Font(ad, 12, FontStyle.Regular);
                e.ItemHeight = Font.Height;
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (checkBox1.Checked == true)
                {
                    richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Bold);
                }
                if (checkBox2.Checked == true)
                {
                    richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Italic);
                }
                if (checkBox3.Checked == true)
                {
                    richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Underline);
                }
                if(checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Bold | FontStyle.Italic);
                }
                if (checkBox1.Checked == true && checkBox3.Checked == true)
                {
                    richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Bold | FontStyle.Underline);
                }
                if (checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Underline | FontStyle.Italic);
                }
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked==true)
                {
                    richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                {
                    richTextBox1.Font = new Font(listBox1.SelectedItem.ToString(), secim, FontStyle.Regular);
                }

            } 
            catch
            {
                MessageBox.Show("Hata");
                throw;
            }
        
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedString = (string)comboBox1.SelectedItem;
            
            selectedString = selectedString.ToLower();

            switch (selectedString)
            {
                case "big":
                    secim=26;
                    break;
                case "small":
                    secim = 12;
                    break;
                case "medium":
                    secim = 16;
                    break;
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Gray;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
