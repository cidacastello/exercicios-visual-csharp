using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeEsfera
{
    public partial class frmEsfera : Form
    {
        public frmEsfera()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração de variáveis
            //entrada 
            double raio;
            //saída
            double volume;
            //entrada de dados
            raio = Convert.ToDouble(txtRaio.Text);
            //processamento
            volume = (double)4 / 3 * 3.14159 * raio * raio * raio;
            //saída de dados , resposta
            txtVolume.Text = Convert.ToString(volume);
            //ou
            txtVolume.Text = volume.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.ResetText();
            //ou
            txtRaio.Clear();
            txtVolume.Text = "";
            txtRaio.Focus();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
