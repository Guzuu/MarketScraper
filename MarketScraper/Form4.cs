﻿using System;
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

        float suma1;
        float suma2;

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

            suma1 = 0;
            suma2 = 0;

            foreach (var keyValuePair in BiedronkaCart)
            {
                dataGridViewBiedronkaCart.Rows.Add(keyValuePair.Value , PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(keyValuePair.Key.imageUrl), 150), keyValuePair.Key.name + "\n" + keyValuePair.Key.price + "zł\n" + keyValuePair.Key.weight);
                suma1 += keyValuePair.Key.price * keyValuePair.Value;
            }

            foreach (var keyValuePair in SparCart)
            {
                dataGridViewSparCart.Rows.Add(keyValuePair.Value, PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(keyValuePair.Key.imageUrl), 100), keyValuePair.Key.name + "\n" + keyValuePair.Key.price + "zł\n" + keyValuePair.Key.weight);
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

        private void buttonSaveListSpar_Click(object sender, EventArgs e)
        {
            if (SparCart.Count == 0) return;
            int DGVw = 400, DGVh = dataGridViewSparCart[0, 1].Size.Height * dataGridViewSparCart.RowCount;
            Bitmap Layout = new Bitmap(DGVw, DGVh);

            dataGridViewSparCart.Hide();
            dataGridViewSparCart.Dock = DockStyle.None;
            dataGridViewSparCart.Width = DGVw;
            dataGridViewSparCart.Height = DGVh + 5;
            dataGridViewSparCart.DrawToBitmap(Layout, new Rectangle(0, 0, DGVw, DGVh));

            saveFileDialog1.FileName += "Lista Zakupów Spar" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            saveFileDialog1.ShowDialog();
            Console.WriteLine(saveFileDialog1.FileName);
            Layout.Save(saveFileDialog1.FileName);
            Layout.Dispose();
            dataGridViewSparCart.Dock = DockStyle.Left;
            dataGridViewSparCart.Show();
        }

        private void buttonSaveListBiedronka_Click(object sender, EventArgs e)
        {
            if (BiedronkaCart.Count == 0) return;
            int DGVw = 400, DGVh = dataGridViewBiedronkaCart[0, 1].Size.Height * dataGridViewBiedronkaCart.RowCount;
            Bitmap Layout = new Bitmap(DGVw, DGVh);

            dataGridViewBiedronkaCart.Hide();
            dataGridViewBiedronkaCart.Dock = DockStyle.None;
            dataGridViewBiedronkaCart.Width = DGVw;
            dataGridViewBiedronkaCart.Height = DGVh + 5;
            dataGridViewBiedronkaCart.DrawToBitmap(Layout, new Rectangle(0, 0, DGVw, DGVh));

            saveFileDialog1.FileName += "Lista Zakupów Biedronka" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            saveFileDialog1.ShowDialog();
            Console.WriteLine(saveFileDialog1.FileName);
            Layout.Save(saveFileDialog1.FileName);
            Layout.Dispose();
            dataGridViewBiedronkaCart.Dock = DockStyle.Left;
            dataGridViewBiedronkaCart.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(this);
            f6.Show(); 
        }

        public void SetOrder(Client c1)
        {
            DBConnect db = new DBConnect();
            if (BiedronkaCart.Count != 0) db.Insert(c1, suma1, BiedronkaCart, "Biedronka");
            if (SparCart.Count != 0) db.Insert(c1, suma2, SparCart, "Spar");
        }
    }
}
