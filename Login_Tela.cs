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
        ControladorContas cc = new ControladorContas();
        ControladorGeneros cg = new ControladorGeneros();
        Conta at;
        public Login_Tela()
        {
            InitializeComponent();
            cg.Atualizar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
        	cc.AtualizarContas();
            Cadastro_Tela cTela = new Cadastro_Tela();
            this.Hide();
            cTela.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
        	cc.AtualizarContas();
            
        	bool x = false;
            foreach(Conta c in cc.GetContas())
            {
                if (c.Email == txtEmail.Text && c.Senha == txtSenha.Text)
                {
                	x = true;
                    cc.setAtual(c);
                }
            }
            if(x)
            {
                Dashboard_Tela dTela = new Dashboard_Tela();
                this.Hide();
                this.txtEmail.Text = "";
                this.txtSenha.Text = "";
                dTela.Show();
            }
            else
            {
            	MessageBox.Show("Login Incorreto");
            }
        }
    }
}
