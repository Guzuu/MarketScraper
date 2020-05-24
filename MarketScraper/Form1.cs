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
    public partial class Form1 : Form
    {
        Form2 f2;
        Form3 f3;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPromo_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
            Program.f1.Hide();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
            Program.f1.Hide();
        }
    }
}
