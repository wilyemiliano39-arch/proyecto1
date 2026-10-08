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


        private Reserva CrearReserva()
        {
            return new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

        }
        private Reserva CrearReservaConFinDeSemana()
        {
            decimal tarifa = nudTarifa.Value;
            if (chkFinSemana.Checked)
            {
                tarifa = tarifa * 1.15m;
            }

            return new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa
            };
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
            lstResultados.Items.Add($"1.1  r = {r}");

            decimal r2 = 10 / 4m;
            lstResultados.Items.Add($"1.2  r = {r2}");

            int x = 5;
            x = x + 2;
            x = x * 3;
            lstResultados.Items.Add($"1.3  x = {x}");

            decimal p = 200m;
            decimal r4 = p * 0.18m;
            lstResultados.Items.Add($"1.4  r = {r4}");

            int n = 7;
            decimal d = 0m;
            if (n > 7)
            {
                d = 50m;
            }
            lstResultados.Items.Add($"1.5  d = {d}");

            bool larga = n >= 7;
            lstResultados.Items.Add($"1.6  larga = {larga}");

            string s = "Villa" + "Coral";
            lstResultados.Items.Add($"1.7  s = {s}");

            int n8 = 4;
            decimal t8 = 100m;
            decimal total = n8 * t8 * 1.28m;
            lstResultados.Items.Add($"1.8  total = {total}");

            decimal t = 120m;
            t = t + t * 0.25m;
            lstResultados.Items.Add($"1.9  t = {t}");

            int noches = (int)8.9m;
            lstResultados.Items.Add($"1.10 noches = {noches}");
        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            var reserva = CrearReserva();
            decimal tasa = nudTasa.Value;
            decimal pesos = reserva.Total * tasa;
            lstResultados.Items.Add($"Total en pesos: RD$ {pesos:N2}");
        }

        private void txtHuesped_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPersonas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudNoches_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudTarifa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnPorPersona_Click(object sender, EventArgs e)
        {
            var reserva = CrearReserva();
            decimal porPersona = reserva.Total / nudPersonas.Value;
            lstResultados.Items.Add($"Cada persona paga: US$ {porPersona:N2}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var reserva = CrearReserva();
            decimal deposito = reserva.Total * 0.30m;
            decimal saldo = reserva.Total - deposito;
            lstResultados.Items.Add($"Depósito (30%): US$ {deposito:N2}");
            lstResultados.Items.Add($"Saldo pendiente: US$ {saldo:N2}");
        }

        private void btnFinSemana_Click(object sender, EventArgs e)
        {



            var reserva = CrearReservaConFinDeSemana();
            lstResultados.Items.Add($"Total con fin de semana: US$ {reserva.Total:N2}");


        }

        
       

        private void btnDesglose_Click(object sender, EventArgs e)
        {
            var reserva = CrearReserva();
            lstResultados.Items.Add($"Subtotal:       US$ {reserva.Subtotal:N2}");
            lstResultados.Items.Add($"Descuento:      US$ {reserva.Descuento:N2}");
            lstResultados.Items.Add($"Base imponible: US$ {reserva.BaseImponible:N2}");
            lstResultados.Items.Add($"ITBIS (18%):    US$ {reserva.Itbis:N2}");
            lstResultados.Items.Add($"Servicio (10%): US$ {reserva.Servicio:N2}");
            lstResultados.Items.Add($"Total:          US$ {reserva.Total:N2}");
        }
    }
}

