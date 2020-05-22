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
    public partial class Form2 : Form
    {
        PromoScraper s1 = new PromoScraper();
        public Form2()
        {
            InitializeComponent();
            s1.ScrapeImages();
            s1.ScrapeLidl("https://www.lidl.pl/pl/oferta-spozywcza");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();

            foreach (string url in s1.BiedrImg)
            {
                dataGridView1.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(url), 400));
            }

            foreach (string url in s1.SparImg)
            {
                dataGridView2.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(url), 400));
            }


            foreach (var product in s1.LidlPromos)
            {
                dataGridView3.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 200), product.name + "\n" + product.price + "zł\n" + product.weight);
            }

            dataGridView1.Columns[0].HeaderText = "Biedronka (" + s1.BiedrImg.Count + ")";
            dataGridView2.Columns[0].HeaderText = "Spar (" + s1.SparImg.Count + ")";
            dataGridView3.Columns[0].HeaderText = "Lidl (" + s1.LidlPromos.Count + ")";

            dataGridView1.AutoResizeRows();
            dataGridView2.AutoResizeRows();
            dataGridView3.AutoResizeRows();
        }
    }
}
