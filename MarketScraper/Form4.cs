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
        public Dictionary<PromoScraper.Product, int> BiedronkaCart;
        public Dictionary<PromoScraper.Product, int> SparCart;

        public Form4()
        {
            InitializeComponent();
            BiedronkaCart = new Dictionary<PromoScraper.Product, int>();
            SparCart = new Dictionary<PromoScraper.Product, int>();
        }

        public void UpdateCart(object sender)
        {
            dataGridViewBiedronkaCart.Rows.Clear();
            dataGridViewSparCart.Rows.Clear();

            float suma1 = 0;
            float suma2 = 0;

            foreach (var keyValuePair in BiedronkaCart)
            {
                dataGridViewBiedronkaCart.Rows.Add(keyValuePair.Value , PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(keyValuePair.Key.imageUrl), 150), keyValuePair.Key.name + "\n" + keyValuePair.Key.price + "zł\n" + keyValuePair.Key.weight);
                suma1 += keyValuePair.Key.price * keyValuePair.Value;
            }

            foreach (var keyValuePair in SparCart)
            {
                dataGridViewSparCart.Rows.Add(keyValuePair.Value, PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(keyValuePair.Key.imageUrl), 150), keyValuePair.Key.name + "\n" + keyValuePair.Key.price + "zł\n" + keyValuePair.Key.weight);
                suma2 += keyValuePair.Key.price * keyValuePair.Value;
            }

            textBoxBiedronkaSum.Text = Math.Round(suma1, 2).ToString()+"zł";
            textBoxSparSum.Text = Math.Round(suma2, 2).ToString() + "zł";
            textBoxSumSum.Text = Math.Round(suma1+suma2, 2).ToString() + "zł";

            dataGridViewBiedronkaCart.AutoResizeRows();
            dataGridViewSparCart.AutoResizeRows();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            BiedronkaCart.Clear();
            SparCart.Clear();
            dataGridViewBiedronkaCart.Rows.Clear();
            dataGridViewSparCart.Rows.Clear();

            textBoxBiedronkaSum.Text = "0zł";
            textBoxSparSum.Text = "0zł";
            textBoxSumSum.Text = "0zł";
        }
    }
}
