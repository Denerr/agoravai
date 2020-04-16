using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtRepeteSenha.Text)
            {
                MessageBox.Show("As Senhas Não São Compativeis!");
            }
            else if(txtUsuario.Text == "" && txtSenha.Text == "" && txtRepeteSenha.Text == "")
            {
                MessageBox.Show("Cadastro feito com Sucesso!!");
            }
            else
            {
                MessageBox.Show("Cadastro feito com Sucesso!!");
            }
        }
    }
}
