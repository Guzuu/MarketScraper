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
    /// <summary>
    /// Main menu form
    /// </summary>
    public partial class Form1 : Form
    {
        Form2 f2;
        Form3 f3;
        Form7 f7;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens Promotions Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPromo_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
            Program.f1.Hide();
        }

        /// <summary>
        /// Opens Scrape Search Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
            Program.f1.Hide();
        }

        /// <summary>
        /// Opens Orders Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            f7 = new Form7();
            f7.Show();
            Program.f1.Hide();
        }
    }
}
