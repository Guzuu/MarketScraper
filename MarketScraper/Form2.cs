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
        Form5 loading = new Form5();

        /// <summary>
        /// Scrapes images and bunch of lidl products
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            s1.ScrapeImages();
            s1.ScrapeLidl("https://www.lidl.pl/pl/oferta-spozywcza");
        }

        /// <summary>
        /// Assembles data grids from scraped data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetPromos_Click(object sender, EventArgs e)
        {
            loading.Show();
            loading.Location = Location;
            loading.Size = Size;
            Text = "Ładowanie...";

            dataGridViewBiedronkaPromo.Rows.Clear();
            dataGridViewSparPromo.Rows.Clear();
            dataGridViewLidlPromo.Rows.Clear();

            foreach (string url in s1.BiedrImg)
            {
                dataGridViewBiedronkaPromo.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(url), 400));
            }

            foreach (string url in s1.SparImg)
            {
                dataGridViewSparPromo.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(url), 400));
            }


            foreach (var product in s1.LidlPromos)
            {
                dataGridViewLidlPromo.Rows.Add(PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.imageUrl), 200), product.name + "\n" + product.price + "zł\n" + product.weight);
            }

            dataGridViewBiedronkaPromo.Columns[0].HeaderText = "Biedronka (" + s1.BiedrImg.Count + ")";
            dataGridViewSparPromo.Columns[0].HeaderText = "Spar (" + s1.SparImg.Count + ")";
            dataGridViewLidlPromo.Columns[0].HeaderText = "Lidl (" + s1.LidlPromos.Count + ")";

            dataGridViewBiedronkaPromo.AutoResizeRows();
            dataGridViewSparPromo.AutoResizeRows();
            dataGridViewLidlPromo.AutoResizeRows();

            loading.Hide();
            Text = "Promocje";
        }

        /// <summary>
        /// Back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Program.f1.Show();
        }

        /// <summary>
        /// Open main menu form if this form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.f1.Show();
        }
    }
}
