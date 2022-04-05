using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lbCalcularIMC_Click(object sender, EventArgs e)
        {
            Imc imc = new Imc();
            imc.SetAltura(float.Parse(txtAltura.Text));
            imc.Peso = float.Parse(txtPeso.Text);
            float resultadoIMC = imc.calculaImc();

            lbResultado.Text = "IMC: " + resultadoIMC.ToString("0.00");
            lbResultado.Visible = true;

            lbClassificacao.Text = "Classificação: " + imc.classificaIMC(resultadoIMC);
            lbClassificacao.Visible = true;
        }
    }
}
