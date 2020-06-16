using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketScraper
{
    public partial class Form6 : Form
    {
        public Form6(Form4 f4)
        {
            InitializeComponent();
            this.f4 = f4;
        }

        Form4 f4;

        /// <summary>
        /// Verifies the data from textboxes, creates client object and sets an order for him.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox6.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Client c1 = new Client(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, int.Parse(textBox6.Text));
                f4.SetOrder(c1);
                this.Close();
            }
            else MessageBox.Show("Wypełnij wszystkie pola");
        }


    }
}
