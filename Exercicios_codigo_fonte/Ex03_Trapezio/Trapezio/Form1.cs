using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trapezio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpando o textBox utilizando o método Clear()
            txtAltura.Clear();
            txtBaseMenor.Clear();
            //limpando o textBox utilizando o método ResetText()
            txtBaseMaior.ResetText();
            //limpando o textBox utilizando a propriedade Text
            txtArea.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            double baseMaior;
            double baseMenor;
            double altura;
            double area;
            //entrada de dados
            baseMaior = Convert.ToDouble(txtBaseMaior.Text);
            baseMenor = Convert.ToDouble(txtBaseMenor.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            //processamento
            area = ((baseMaior + baseMenor) / 2) * altura;
            //saída de dados
            txtArea.Text = area.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
