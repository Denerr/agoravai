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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
           
            pctPessoa.Image = Properties.Resources.pessoacertarosa;
            panel1.BackColor = Color.FromArgb(220, 20, 60);
            txtUsuario.ForeColor = Color.FromArgb(220, 20, 60);

            pctCadeado.Image = Properties.Resources.cadeadocerto;
            txtSenha.ForeColor = Color.FromArgb(105, 105, 105);
        }


        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            pctCadeado.Image = Properties.Resources.cadeadocertorosa;
            txtSenha.ForeColor = Color.FromArgb(220, 20, 60);

            pctPessoa.Image = Properties.Resources.pessoacerta;
            txtUsuario.ForeColor = Color.FromArgb(105, 105, 105);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

     

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {


            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
          //  string UsuarioR = Form2.UsuarioR.Text;
           // string SenhaR = Form2.SenhaR.Text;

            if(nome != "" && senha != "")
            {
                MessageBox.Show("Bem Vindo "+ nome + "!!!");

                var Form3 = new Form3();
                this.Hide(); //vai “esconder” o formulário atual
                Form3.ShowDialog();
            }

          
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            this.Hide(); //vai “esconder” o formulário atual
            Form2.ShowDialog();
            

        }
       
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
            
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
