﻿using System;
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

        }
    }
}
