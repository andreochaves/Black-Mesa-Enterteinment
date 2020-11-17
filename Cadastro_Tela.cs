using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_Musics
{
    public partial class Cadastro_Tela : Form
    {
        string contas_File = File.ReadAllText("../../Contas.txt");
        ControladorContas controlador = new ControladorContas();
        string nome, senha, email;

        public Cadastro_Tela()
        {
            InitializeComponent();

           
        }

        private void Cadastro_Tela_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.tela_login.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            senha = txtSenha.Text;
            email = txtEmail.Text;
            foreach (Conta c in controlador.GetContas())
            {
                if (email == c.Email)
                {
                    MessageBox.Show("Email já Cadastrado!");
                }
                else
                {
                    contas_File += "\nCodigo:2,\nTipoConta: 0,\nNome:" + nome + ",\nSenha:" + senha + ",\nEmail:" + email + ",\nPossui_Banda: false\n}";
                    File.WriteAllText("../../Contas.txt", contas_File);
                    MessageBox.Show("Cadastrado!");
                }
            }
        }
    }
}
