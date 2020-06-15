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
        Form5 loading = new Form5();

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxProduct.Text == "") return;
            loading.Show();
            loading.Location = Location;
            loading.Size = Size;

            Text = "Ładowanie...";

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
                dataGridViewSparQuery.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 150), product.name + "\n" + product.price + "zł\n" + product.weight);
            }

            dataGridViewBiedronkaQuery.Columns[0].HeaderText = "Biedronka (" + qs1.BiedronkaProducts.Count + ")";
            dataGridViewSparQuery.Columns[0].HeaderText = "Spar (" + qs1.SparProducts.Count + ")";

            dataGridViewBiedronkaQuery.AutoResizeRows();
            dataGridViewSparQuery.AutoResizeRows();

            loading.Hide();
            Text = "Wyszukiwarka produktów";
        }

        private void dataGridViewBiedronkaQuery_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PromoScraper.Product product = qs1.BiedronkaProducts[e.RowIndex];
            if (!f4.BiedronkaCart.ContainsKey(product))
            {
                f4.BiedronkaCart.Add(product, 1);
                MessageBox.Show("Do koszyka dodano produkt:\n" + product.name);
                f4.UpdateCart(sender);
            }
            else
            {
                f4.BiedronkaCart[product]++;
                MessageBox.Show("Do koszyka ponownie dodano produkt:\n" + product.name);
                f4.UpdateCart(sender);
            }

        }

        private void dataGridViewSparQuery_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PromoScraper.Product product = qs1.SparProducts[e.RowIndex];
            if (!f4.SparCart.ContainsKey(product))
            {
                f4.SparCart.Add(product, 1);
                MessageBox.Show("Do koszyka dodano produkt:\n" + product.name);
                f4.UpdateCart(sender);
            }
            else
            {
                f4.SparCart[product]++;
                MessageBox.Show("Do koszyka ponownie dodano produkt:\n" + product.name);
                f4.UpdateCart(sender);
            }
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            f4.Hide();
            Hide();
            Program.f1.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.f1.Show();
        }
    }
}
