﻿using System;
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
    public partial class Torneio_Tela : Form
    {
        public Torneio_Tela()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dashboard_Tela dTela = new Dashboard_Tela();
            this.Close();
            dTela.Show();
        }
    }
}
