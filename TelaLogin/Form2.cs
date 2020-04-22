using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    
    public partial class Form2 : Form
    {
        
        public Form2()
        {

            InitializeComponent();
            
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuarioRegistro_Click(object sender, EventArgs e)
        {
            txtUsuarioRegistro.Clear();

            pctPessoa.Image = Properties.Resources.pessoacertarosa;
            panel1.BackColor = Color.FromArgb(220, 20, 60);
            txtUsuarioRegistro.ForeColor = Color.FromArgb(220, 20, 60);

            pctCadeado.Image = Properties.Resources.cadeadocerto;
            txtSenhaRegistro.ForeColor = Color.FromArgb(105, 105, 105);
            pctCadeado2.Image = Properties.Resources.cadeadocerto;
            txtSenhaRegistro.ForeColor = Color.FromArgb(105, 105, 105);
            pctPessoa2.Image = Properties.Resources.pessoacerta;
            txtSenhaRegistroConfirmar.ForeColor = Color.FromArgb(105, 105, 105);
            txtEmail.ForeColor = Color.FromArgb(105, 105, 105);

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();

            pctPessoa2.Image = Properties.Resources.pessoacertarosa;
            panel1.BackColor = Color.FromArgb(220, 20, 60);
            txtEmail.ForeColor = Color.FromArgb(220, 20, 60);

            pctCadeado.Image = Properties.Resources.cadeadocerto;
            txtSenhaRegistroConfirmar.ForeColor = Color.FromArgb(105, 105, 105);
            pctCadeado2.Image = Properties.Resources.cadeadocerto;
            txtSenhaRegistroConfirmar.ForeColor = Color.FromArgb(105, 105, 105);
            pctPessoa.Image = Properties.Resources.pessoacerta;
            txtUsuarioRegistro.ForeColor = Color.FromArgb(105, 105, 105);
           
        }

        private void txtSenhaRegistro_Click_1(object sender, EventArgs e)
        {
            txtSenhaRegistro.Clear();

            pctCadeado.Image = Properties.Resources.cadeadocertorosa;
            txtSenhaRegistro.ForeColor = Color.FromArgb(220, 20, 60);

            pctPessoa.Image = Properties.Resources.pessoacerta;
            txtUsuarioRegistro.ForeColor = Color.FromArgb(105, 105, 105);
            pctPessoa2.Image = Properties.Resources.pessoacerta;
            txtEmail.ForeColor = Color.FromArgb(105, 105, 105);
            pctCadeado2.Image = Properties.Resources.cadeadocerto;
            txtSenhaRegistroConfirmar.ForeColor = Color.FromArgb(105, 105, 105);
        }

        private void txtSenhaRegistroConfirmar_Click(object sender, EventArgs e)
        {
            txtSenhaRegistroConfirmar.Clear();

            pctCadeado2.Image = Properties.Resources.cadeadocertorosa;
            txtSenhaRegistroConfirmar.ForeColor = Color.FromArgb(220, 20, 60);

            pctPessoa.Image = Properties.Resources.pessoacerta;
            txtUsuarioRegistro.ForeColor = Color.FromArgb(105, 105, 105);
            pctPessoa2.Image = Properties.Resources.pessoacerta;
            txtEmail.ForeColor = Color.FromArgb(105, 105, 105);
            pctCadeado.Image = Properties.Resources.cadeadocerto;
            txtSenhaRegistro.ForeColor = Color.FromArgb(105, 105, 105);


        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            this.Hide(); 
            Form1.ShowDialog();
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtSenhaRegistro.Text != txtSenhaRegistroConfirmar.Text)
            {
                MessageBox.Show("As Senhas Não Coincidem!!");
            }
            else if(txtUsuarioRegistro.Text == "" && txtEmail.Text == "" && txtSenhaRegistro.Text == "" && txtSenhaRegistroConfirmar.Text == "")
            {
                MessageBox.Show("Os Campos Devem Ser Preenchidos!!!");
            }
            else
            {
                MessageBox.Show("Cadastro Feito com Sucesso!!!");
            }
        }
    }
    
}
