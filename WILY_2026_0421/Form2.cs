using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WILY_2026_0421
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        

  

        private void ltsResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNivel1_Click_1(object sender, EventArgs e)
        {
            int a = 10;
            int b = 3;
            int r = a / b;
            ltsResultados.Items.Add($"1.1  r = {r}");

            decimal r2 = 10 / 4m;
            ltsResultados.Items.Add($"1.2  r = {r2}");

            int x = 5;
            x = x + 2;
            x = x * 3;
            ltsResultados.Items.Add($"1.3  x = {x}");

            decimal p = 200m;
            decimal r4 = p * 0.18m;
            ltsResultados.Items.Add($"1.4  r = {r4}");

            int n = 7;
            decimal d = 0m;
            if (n > 7)
            {
                d = 50m;
            }
            ltsResultados.Items.Add($"1.5  d = {d}");

            bool larga = n >= 7;
            ltsResultados.Items.Add($"1.6  larga = {larga}");

            string s = "Villa" + "Coral";
            ltsResultados.Items.Add($"1.7  s = {s}");

            int n8 = 4;
            decimal t8 = 100m;
            decimal total = n8 * t8 * 1.28m;
            ltsResultados.Items.Add($"1.8  total = {total}");

            decimal t = 120m;
            t = t + t * 0.25m;
            ltsResultados.Items.Add($"1.9  t = {t}");

            int noches = (int)8.9m;
            ltsResultados.Items.Add($"1.10 noches = {noches}");
        }
    }
}
