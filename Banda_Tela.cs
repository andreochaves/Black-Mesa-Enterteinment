using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lets_Musics
{
    public partial class Banda_Tela : Form
    {
        string textResult;
        public Banda_Tela()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dashboard_Tela dTela = new Dashboard_Tela();
            dTela.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
            if (textResult != null)
            {
                lbBanda.Items.Add(textResult);
                this.textResult = null;
            }
        }
        public void ShowMyDialogBox()
        {
            AddFriend_Tela testDialog = new AddFriend_Tela();

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.textResult = testDialog.txtFriendCode.Text;
            }
            testDialog.Dispose();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lbBanda.Items.Remove(lbBanda.SelectedItem);
        }
    }
}
