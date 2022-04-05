using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class MeuPrimeiroForm : Form
    {
        public MeuPrimeiroForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textName.Text.Trim().Length != 0)
            {
                lbResultado.Text = $"Olá {textName.Text}, seja muito bem-vindo(a)!";
            }
            else
            {
                MessageBox.Show("Ops...Informe o nome!", "Erro!");
            }
            
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "Digite seu nome: ";
            textName.Text = "";
            textName.Focus();
            


        }
    }
}
