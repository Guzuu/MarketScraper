﻿using System;
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
    public partial class Form7 : Form
    {
        DBConnect db;
        int pickedOrderID;

        public Form7()
        {
            InitializeComponent();
            db = new DBConnect();
            dataGridViewOrders.Rows.Clear();
            foreach (DBConnect.Zamowienie zamowienie in db.SelectOrders())
            {
                dataGridViewOrders.Rows.Add(zamowienie.id, zamowienie.data, zamowienie.cena, zamowienie.sklep);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Program.f1.Show();
        }

        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewProductsFromDB.Rows.Clear();
            dataGridViewProductsFromDB.Columns[1].HeaderText = dataGridViewOrders[3, e.RowIndex].Value.ToString();
            pickedOrderID = int.Parse(dataGridViewOrders[0, e.RowIndex].Value.ToString());
            foreach (KeyValuePair<PromoScraper.Product, int> product in db.SelectOrderDetails(pickedOrderID))
            {
                dataGridViewProductsFromDB.Rows.Add(product.Value, PromoScraper.ScaleImage(PromoScraper.DownloadImageFromUrl(product.Key.imageUrl), 200), product.Key.name + "\n" + product.Key.price + "zł\n" + product.Key.weight);
            }
            dataGridViewProductsFromDB.AutoResizeRows();
        }

        private void buttonAcceptOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductsFromDB.RowCount != 0)
            {
                db.Delete(pickedOrderID);

                dataGridViewOrders.Rows.Clear();
                dataGridViewProductsFromDB.Rows.Clear();
                foreach (DBConnect.Zamowienie zamowienie in db.SelectOrders())
                {
                    dataGridViewOrders.Rows.Add(zamowienie.id, zamowienie.data, zamowienie.cena, zamowienie.sklep);
                }
                MessageBox.Show("Przyjąłeś zamówienie.");
            }
            else MessageBox.Show("Wybierz zamówienie.");
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.f1.Show();
        }
    }
}
