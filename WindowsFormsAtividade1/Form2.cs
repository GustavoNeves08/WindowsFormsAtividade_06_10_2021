using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAtividade1
{
    public partial class Form2 : Form
    {
        Cadastro cad1 = new Cadastro();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form1.resg_gmail && textBox2.Text == Form1.resg_senha)
            {
                var resp = $"CPF: {Form1.resg_cpf}\n" +
                           $"Email: {Form1.resg_gmail}\n" +
                           $"Senha: {Form1.resg_senha}\n" +
                           $"Nome: {Form1.resg_nome}\n" +
                           $"Sobrenome: {Form1.resg_sobrenome}\n" +
                           $"País: {Form1.resg_pais}\n" +
                           $"Mês: {Form1.resg_mes}\n" +
                           $"Ano: {Form1.resg_ano}\n" +
                           $"Sexo: {Form1.resg_sexo}\n";

                MessageBox.Show(resp, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("E-mail ou senha invalidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
