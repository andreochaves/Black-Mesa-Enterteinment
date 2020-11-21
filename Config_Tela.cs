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
    public partial class Config_Tela : Form
    {
        ControladorContas cc = new ControladorContas();
        public Config_Tela()
        {
            InitializeComponent();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.txtCaminho.Text = this.folderBrowserDialog1.SelectedPath;
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            cc.getAtual().musicas_Path = txtCaminho.Text;
        }

        private void btnMSenha_Click(object sender, EventArgs e)
        {
            
            if(cc.getAtual().Senha == txtSAtual.Text)
            {
                string gravar = "";
                cc.getAtual().Senha = txtNSenha.Text;
                int count = 0;
                foreach(Conta c in cc.GetContas())
                {
                    if(count > 0)
                    {
                        gravar += "\n";
                    }
                    gravar += "Codigo:"+c.Codigo+",\n"+ "TipoConta:"+c.Tipo_Conta+",\n"+ "Nome:"+c.Nome+",\n"+ "Senha:"+c.Senha+",\n"+ "Email:"+c.Email+",\n"+"Possui_Banda:"+c.PossuiBanda+",\n"+"MusicasPath:"+c.musicas_Path+",\n"+"PlayLists:"+c.GetPlaylistsNomes()+"\n"+"}";
                    count++;
                }
                File.WriteAllText("../../Contas.txt", gravar);
                MessageBox.Show("Senha Alterada Com Sucesso.");
            }
            else
            {
                MessageBox.Show("Senha Atual errada");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_Tela dTela = new Dashboard_Tela();
            dTela.Show();
        }
    }
}
