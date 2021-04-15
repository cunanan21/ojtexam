using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Country = txtCountry.Text;
            string City = txtCity.Text;
            string Abbv = txtAbbv.Text;
            try
            {
                StringBuilder quarryaddress = new StringBuilder();
                quarryaddress.Append("http://maps.google.com/maps?q=");

                if(Country != string.Empty)
                {
                    quarryaddress.Append(Country+","+"+");
                }

                if (City != string.Empty)
                {
                    quarryaddress.Append(City + "," + "+");
                }

                if (Abbv != string.Empty)
                {
                    quarryaddress.Append(Abbv + "," + "+");
                }

                webBrowser1.Navigate(quarryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
