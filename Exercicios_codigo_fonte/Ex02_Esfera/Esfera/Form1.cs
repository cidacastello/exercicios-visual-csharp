using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esfera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtVolume.Clear();
            txtRaio.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //variáveis
            double raio, volume;

            //entrada de dados

            raio = Double.Parse(txtRaio.Text);

            volume = 4.0 / 3.0 * Math.PI* Math.Pow(raio, 3);

            txtVolume.Text = volume.ToString();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
