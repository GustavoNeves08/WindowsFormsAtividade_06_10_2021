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
    public partial class Form1 : Form
    {
        Cadastro cad1 = new Cadastro();
        Form2 login = new Form2();
        
        public static string resg_cpf;
        public static string resg_nome;
        public static string resg_sobrenome;
        public static string resg_senha;
        public static string resg_gmail;
        public static string resg_mes;
        public static string resg_ano;
        public static string resg_pais;
        public static string resg_sexo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i < 2022; i++)
            {
                this.comboBox4.Items.Add(i.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if(textBox2.Text != textBox4.Text)
            {
                MessageBox.Show("E-mails diferentes", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            { 
                if(textBox3.Text != textBox5.Text)
                {
                    MessageBox.Show("Senhas diferentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(radioButton2.Checked == false && radioButton3.Checked == false)
                    {
                        MessageBox.Show("Aceite os termos de consentimento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(checkBox1.Checked == false && checkBox2.Checked == false)
                        {
                            MessageBox.Show("Aceite as políticas de privacidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        if(textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null && textBox5.Text == null && textBox6.Text == null && textBox7.Text == null)
                        {
                            MessageBox.Show("Campos em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        {

                        
                                cad1.setcpf(textBox1.Text);
                                cad1.setemail(textBox2.Text);
                                cad1.setsenha(textBox3.Text);
                                cad1.setnome(textBox7.Text);
                                cad1.setsobrenome(textBox6.Text);
                                cad1.setpais(comboBox3.Text);
                                cad1.setmes(comboBox5.Text);
                                cad1.setano(int.Parse(comboBox4.Text));
                                cad1.setsexo(comboBox6.Text);

                            resg_cpf = textBox1.Text;
                            resg_nome = textBox7.Text;
                            resg_sobrenome = textBox6.Text;
                            resg_senha = textBox3.Text;
                            resg_gmail = textBox2.Text;
                            resg_mes = comboBox5.Text;
                            resg_ano = comboBox4.Text;
                            resg_pais = comboBox3.Text;
                            resg_sexo = comboBox6.Text;


                            this.Hide();
                            login.ShowDialog();

                        }
                    }
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
