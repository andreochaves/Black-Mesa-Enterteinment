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
    public partial class Dashboard_Tela : Form
    {
        ControladorContas cc = new ControladorContas();
        public Dashboard_Tela()
        {
            InitializeComponent();
            this.LabelNomeConta.Text = cc.getAtual().Nome;
        }

        private void Dashboard_Tela_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {
                Program.tela_login.Close();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.tela_login.Show();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            this.Close();
            Config_Tela cTela = new Config_Tela();
            cTela.Show();
        }
    }
}
