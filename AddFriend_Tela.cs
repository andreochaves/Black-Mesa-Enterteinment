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
    public partial class AddFriend_Tela : Form
    {
        ControladorContas cc = new ControladorContas();
        public AddFriend_Tela()
        {
            InitializeComponent();
        }

        private void txtFriendCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string error = null;
            foreach(Conta c in cc.GetContas())
            {
                if(c.Codigo.ToString() == txtFriendCode.Text)
                {
                    if (cc.getAtual().Codigo.ToString() == txtFriendCode.Text)
                    {
                        error += "1";
                    }
                    else
                    {
                        error += "0";
                    }
                }
                else
                {
                    error += "1";
                }
            }
            bool er = error.Contains("0");
            switch (er)
            {
                case true:
                    DialogResult = DialogResult.OK;
                    break;
                case false:
                    MessageBox.Show("Não é possivel adicionar este Codigo");
                    DialogResult = DialogResult.Cancel;
                    break;
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
