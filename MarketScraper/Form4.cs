using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketScraper
{
    public partial class Form4 : Form
    {
        public List<PromoScraper.Product> BiedronkaCart;
        public List<PromoScraper.Product> SparCart;

        public Form4()
        {
            InitializeComponent();
            BiedronkaCart = new List<PromoScraper.Product>();
            SparCart = new List<PromoScraper.Product>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewBiedronkaCart.Rows.Clear();
            dataGridViewSparCart.Rows.Clear();

            float suma1 = 0;
            float suma2 = 0;

            foreach (var product in BiedronkaCart)
            {
                dataGridViewBiedronkaCart.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 200), product.name + "\n" + product.price + "zł\n" + product.weight);
                suma1 += product.price;
            }

            foreach (var product in SparCart)
            {
                dataGridViewSparCart.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 200), product.name + "\n" + product.price + "zł\n" + product.weight);
                suma2 += product.price;
            }

            textBoxBiedronkaSum.Text = Math.Round(suma1, 2).ToString()+"zł";
            textBoxSparSum.Text = Math.Round(suma2, 2).ToString() + "zł";

            dataGridViewBiedronkaCart.AutoResizeRows();
            dataGridViewSparCart.AutoResizeRows();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
