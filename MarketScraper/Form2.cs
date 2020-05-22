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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Scraper s1 = new Scraper();
            s1.ScrapeImages();

            foreach(string url in s1.BiedrImg)
            {
                dataGridView1.Rows.Add(Scraper.ScaleImage(Scraper.DownloadImageFromUrl(url), 500));
            }

            foreach (string url in s1.SparImg)
            {
                dataGridView2.Rows.Add(Scraper.ScaleImage(Scraper.DownloadImageFromUrl(url), 500));
            }

            dataGridView1.AutoResizeRows();
            dataGridView2.AutoResizeRows();
            //s1.ScrapeLidl("https://www.lidl.pl/pl/oferta-spozywcza");
        }
    }
}
