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
         var resp = $"CPF: {cad1.getcpf()}\n" +
                    $"Email: {cad1.getemail()}\n" +
                    $"Senha: {cad1.getsenha()}\n" +
                    $"Nome: {cad1.getnome()}\n" +
                    $"Sobrenome: {cad1.getsobrenome()}\n" +
                    $"País: {cad1.getpais()}\n" +
                    $"Mês: {cad1.getmes()}\n" +
                    $"Ano: {cad1.getano()}\n" +
                    $"Sexo: {cad1.getsexo()}\n";

            MessageBox.Show(resp, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
