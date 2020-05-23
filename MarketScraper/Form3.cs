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
    public partial class Form3 : Form
    {
        QueryScraper qs1 = new QueryScraper();

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewBiedronkaQuery.Rows.Clear();
            dataGridViewSparQuery.Rows.Clear();
            qs1.BiedronkaProducts.Clear();
            qs1.SparProducts.Clear();

            qs1.ScrapeBiedronka(textBoxProduct.Text);
            qs1.ScrapeSpar(textBoxProduct.Text, textBoxCity.Text);

            foreach (var product in qs1.BiedronkaProducts)
            {
                dataGridViewBiedronkaQuery.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 200), product.name + "\n" + product.price + "zł\n" + product.weight);
            }

            foreach (var product in qs1.SparProducts)
            {
                dataGridViewSparQuery.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 200), product.name + "\n" + product.price + "zł\n" + product.weight);
            }

            dataGridViewBiedronkaQuery.AutoResizeRows();
            dataGridViewSparQuery.AutoResizeRows();
        }
    }
}
