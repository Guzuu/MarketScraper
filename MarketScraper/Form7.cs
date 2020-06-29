using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MarketScraper
{
    /// <summary>
    /// Order menu
    /// </summary>
    public partial class Form7 : Form
    {
        DBConnect db;
        int pickedOrderID;

        /// <summary>
        /// Downloads all orders from database and displays them in datagrid
        /// </summary>
        public Form7()
        {
            InitializeComponent();
            db = new DBConnect();
            dataGridViewOrders.Rows.Clear();
            foreach (DBConnect.Zamowienie zamowienie in db.SelectOrders())
            {
                dataGridViewOrders.Rows.Add(zamowienie.id, zamowienie.data, zamowienie.cena+"zł", zamowienie.sklep);
            }
        }

        /// <summary>
        /// Hides this form and opens up a main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Program.f1.Show();
        }

        /// <summary>
        /// Prints double clicked order details on another datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Removes order from database and gives client delivery information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAcceptOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductsFromDB.RowCount != 0)
            {
                Client c1 = db.selectClientDetails(db.selectClientId(pickedOrderID));
                MessageBox.Show("Przyjąłeś zamówienie. Szczegóły:\n" + c1.imie + " " + c1.nazwisko + "\n" + c1.miasto + " " + c1.KP + "\n" + c1.ulica + "\n" + c1.tel);
                db.Delete(pickedOrderID);

                dataGridViewOrders.Rows.Clear();
                dataGridViewProductsFromDB.Rows.Clear();
                foreach (DBConnect.Zamowienie zamowienie in db.SelectOrders())
                {
                    dataGridViewOrders.Rows.Add(zamowienie.id, zamowienie.data, zamowienie.cena, zamowienie.sklep);
                }
            }
            else MessageBox.Show("Wybierz zamówienie.");
        }

        /// <summary>
        /// Opens up main menu if this form gets closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.f1.Show();
        }
    }
}
