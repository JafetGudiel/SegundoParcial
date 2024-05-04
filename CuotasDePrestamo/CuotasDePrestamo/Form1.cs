using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuotasDePrestamo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(Monto.Text);
            double interes = double.Parse(Interes.Text);
            double plazo = double.Parse(Plazos.Text);
            interes = interes / 100;

            double cuotaMensual = (monto * (interes * Math.Pow(1 + interes, plazo))) / (Math.Pow(1 + interes, plazo)-1);
            cuotaMensual = Math.Round(cuotaMensual, 2);
            Cuota.Text = cuotaMensual.ToString();

            double interesTotal = monto * interes;

            MostrarIntereses.Text = interesTotal.ToString();

            double totalFinal = monto + interesTotal;
            
            TotalPagar.Text = totalFinal.ToString();



        }
    }
}
