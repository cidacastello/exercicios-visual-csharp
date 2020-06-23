using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04_Velocidade_MUV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            double velocidadeInicial = 10, aceleracao = 3;
            double tempo, velocidadeFinal;

            //entrada de dados com validação
            if(double.TryParse(txtTempo.Text, out tempo) == false){
                MessageBox.Show("Valor inválido", "Velocidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTempo.Clear();
                txtTempo.Focus();
                return; //interrompe o processamento
            }
            
            //processamento
            velocidadeFinal = velocidadeInicial + aceleracao * tempo;

            txtVelocidade.Text = velocidadeFinal.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVelocidade.ResetText();
            txtTempo.ResetText();
            txtTempo.Focus();
        }
    }
}
