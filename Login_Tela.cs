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
using System.Runtime.Remoting.Messaging;

namespace Lets_Musics
{
    public partial class Login_Tela : Form
    {
        string contas_File;
        ControladorContas controlador = new ControladorContas();
        string nome, senha, email;
        int tipo;
        bool pBanda;

        public Login_Tela()
        {
            InitializeComponent();
            contas_File = File.ReadAllText("../../Contas.txt");
            string[] load_contas = contas_File.Split('}');

            foreach (string k in load_contas)
            {
                int count = 0;
                string[] conta_info = k.Split(',');
                foreach (string j in conta_info)
                {
                    switch (count)
                    {
                        case 1:
                            tipo = int.Parse(j.Split(':')[1]);
                            break;
                        case 2:
                            nome = j.Split(':')[1];
                            break;
                        case 3:
                            senha = j.Split(':')[1];
                            break;
                        case 4:
                            email = j.Split(':')[1];
                            break;
                        case 5:
                            pBanda = bool.Parse(j.Split(':')[1]);
                            break;
                        
                    }
                    count++;
                }
                if (tipo == 0)
                {
                    controlador.GetContas().Add(new ContaNormal(nome, senha, email, pBanda));
                }
                else
                {
                    controlador.GetContas().Add(new ContaPremium(nome, senha, email, pBanda));
                }
                
            }

        }



        private void Login_Tela_Load(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Cadastro_Tela cTela = new Cadastro_Tela();
            this.Hide();
            cTela.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach(Conta c in controlador.GetContas())
            {
                if (c.Email == txtEmail.Text && c.Senha == txtSenha.Text)
                {
                    Cadastro_Tela cTela = new Cadastro_Tela();
                    this.Hide();
                    cTela.Show();
                }
                else
                {
                }
            }
        }
    }
}
