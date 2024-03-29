﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksit_DateTime_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double taksit = Convert.ToInt32(txtÜcret.Text) / Convert.ToDouble(num.Value);

            DateTime tarih = DateTime.Now;
            lbTaksit.Items.Clear();
            for (int i = 1; i <= num.Value; i++)
            {
                lbTaksit.Items.Add($" {i} taksit: {taksit} ");

                DateTime yeniTarih = DateTime.Now;

                lbTarih.Items.Add($"Yıl: {yeniTarih.Year} Ay: {yeniTarih.Month}. Gün: {yeniTarih.Day} ");

            }
        }
    }
}
