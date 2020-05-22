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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            dataGridView1.Rows.Clear();
            qs1.BiedronkaProducts.Clear();
            qs1.SparProducts.Clear();

            qs1.ScrapeBiedronka(textBox1.Text);
            qs1.ScrapeSpar(textBox1.Text);

            foreach (var product in qs1.BiedronkaProducts)
            {
                dataGridView3.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 200), product.name + "\n" + product.price + "zł\n" + product.weight);
            }

            foreach (var product in qs1.SparProducts)
            {
                dataGridView1.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 200), product.name + "\n" + product.price + "zł\n" + product.weight);
            }

            dataGridView3.AutoResizeRows();
            dataGridView1.AutoResizeRows();
        }
    }
}
