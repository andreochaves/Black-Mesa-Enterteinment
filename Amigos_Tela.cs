using System;
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
    public partial class Amigos_Tela : Form
    {
        ControladorContas cc = new ControladorContas();
        List<Conta> amigos = new List<Conta>();
        string textResult = null;
        public Amigos_Tela()
        {
            InitializeComponent();
            CarregarAmigos();
        }
        public void CarregarAmigos()
        {
            foreach(Conta c in cc.getAtual().amigos)
            {
                lstAmigos.Items.Add(c.Codigo+":"+ c.Nome);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
            if (textResult != null)
            {
                foreach (Conta c in cc.GetContas())
                {
                    if (textResult == c.Codigo.ToString())
                    {
                        lstAmigos.Items.Add(c.Codigo+":"+c.Nome);
                        cc.getAtual().amigos.Add(c);
                    }
                }
                textResult = null;
            }
        }
        public void ShowMyDialogBox()
        {
            AddFriend_Tela testDialog = new AddFriend_Tela();
            
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                textResult = testDialog.txtFriendCode.Text;
                
            }
            testDialog.Dispose();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dashboard_Tela dTela = new Dashboard_Tela();
            dTela.Show();
            this.Close();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string aux = null;
            Conta p = null;
            foreach (Conta c in cc.GetContas())
            {
                if ((lstAmigos.SelectedItem.ToString() == (c.Codigo+":"+c.Nome)))
                {
                    aux = "1";
                    p = c;
                }
            }
            textResult = null;
            if(aux != null)
            {
                cc.getAtual().amigos.Remove(p);
                lstAmigos.Items.Remove(p.Codigo + ":" + p.Nome);
            }
        }
    }
}
