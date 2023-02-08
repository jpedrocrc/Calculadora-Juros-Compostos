using System;
using System.Windows.Forms;

namespace Calculadora_Juros_Compostos
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnLimpar.FlatStyle = FlatStyle.Flat;
        }
        private void LimparCampos()
        {
            txtValorInicial.Text = "";
            txtValorMensal.Text = "";
            txtJuros.Text = "";
            txtTempo.Text = "";
            txtValorDeJurosFinal.Text = "";
            txtValorFinal.Text = "";
            txtValorInvestidoFinal.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            (double valorJuros, double valorTotalInvestido, double valorTotalFinal)= Calcular();
            txtValorFinal.Text = valorTotalFinal.ToString("C");
            txtValorInvestidoFinal.Text = valorTotalInvestido.ToString("C");
            txtValorDeJurosFinal.Text = valorJuros.ToString("C");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtValorInicial_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValorInicial.Text, "[^0-9,.]"))
            {
                txtValorInicial.Text = txtValorInicial.Text.Remove(txtValorInicial.TextLength - 1);
            }
        }

        private void txtValorMensal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValorMensal.Text, "[^0-9,.]"))
            {
                txtValorMensal.Text = txtValorMensal.Text.Remove(txtValorMensal.TextLength - 1);
            }
        }

        private void txtJuros_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJuros.Text, "[^0-9,.]"))
            {
                txtJuros.Text = txtJuros.Text.Remove(txtJuros.TextLength - 1);
            }
        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTempo.Text, "[^0-9,.]"))
            {
                txtTempo.Text = txtTempo.Text.Remove(txtTempo.TextLength - 1);
            }
        }
        private void ValidarCampos()
        {
            if (txtValorInicial.Text == "" || txtValorMensal.Text == "" || txtJuros.Text == "" || txtTempo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes");
                
            }
        }
        public Tuple<double, double, double> Calcular()
        {
            double valorInicial = double.Parse(txtValorInicial.Text);
            double valorMensal = double.Parse(txtValorMensal.Text);
            double juros = 1 + double.Parse(txtJuros.Text) / 100;
            double anos = double.Parse(txtTempo.Text);
            
            double valorTotalFinal = (valorInicial + (valorMensal * 12)) * Math.Pow(juros, anos);
            double valorTotalInvestido = valorInicial + (valorMensal * 12);
            double valorJuros = valorTotalFinal - valorTotalInvestido;
            return Tuple.Create(valorJuros, valorTotalInvestido, valorTotalFinal);
        }
    }
}
