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
    public partial class AddFriente_Tela : Form
    {
        public AddFriente_Tela()
        {
            InitializeComponent();
        }

        private void txtFriendCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult  = DialogResult.OK;
        }
    }
}
