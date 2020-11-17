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
        ControladorContas controlador = new ControladorContas();
        
        public Login_Tela()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
        	controlador.AtualizarContas();
            Cadastro_Tela cTela = new Cadastro_Tela();
            this.Hide();
            cTela.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
        	controlador.AtualizarContas();
        	bool x = false;
            foreach(Conta c in controlador.GetContas())
            {
                if (c.Email == txtEmail.Text && c.Senha == txtSenha.Text)
                {
                	x = true;
                }
            }
            if(x)
            {
            	Playlist_Tela pTela = new Playlist_Tela();
                this.Hide();
                pTela.Show();
            }
            else
            {
            	MessageBox.Show("Login Incorreto");
            }
        }
    }
}
