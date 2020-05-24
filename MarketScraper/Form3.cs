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

        Form4 f4 = new Form4();

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

            dataGridViewBiedronkaQuery.Columns[0].HeaderText = "Biedronka (" + qs1.BiedronkaProducts.Count + ")";
            dataGridViewSparQuery.Columns[0].HeaderText = "Spar (" + qs1.SparProducts.Count + ")";

            dataGridViewBiedronkaQuery.AutoResizeRows();
            dataGridViewSparQuery.AutoResizeRows();
        }

        private void dataGridViewBiedronkaQuery_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            f4.BiedronkaCart.Add(qs1.BiedronkaProducts[e.RowIndex]);
            MessageBox.Show("Do koszyka dodano produkt:\n" + qs1.BiedronkaProducts[e.RowIndex].name);
        }

        private void dataGridViewSparQuery_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            f4.SparCart.Add(qs1.SparProducts[e.RowIndex]);
            MessageBox.Show("Do koszyka dodano produkt:\n" + qs1.SparProducts[e.RowIndex].name);
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            f4.Show();
        }
    }
}
