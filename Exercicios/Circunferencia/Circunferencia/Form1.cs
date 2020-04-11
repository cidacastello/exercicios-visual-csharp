using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circunferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRespArea.ResetText();
            lblRespComprimento.ResetText();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblRespComprimento.ResetText();
            lblRespArea.ResetText();
            txtRaio.ResetText();
            txtRaio.Focus();
              
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando variáveis
            double raio, area, comprimento;

            //entrada de dados, convertendo os tipos de dados

            raio =  Convert.ToDouble(txtRaio.Text);

            //calculando a area e o comprimento
            area = 3.14159 * raio * raio;

            comprimento = 2 * 3.14159 * raio;

            //alternativa
            area = Math.PI * Math.Pow(raio, 2);

            //apresentando os resultados
            lblRespArea.Text = area.ToString();
            lblRespComprimento.Text = Convert.ToString(comprimento);

        }
    }
}
