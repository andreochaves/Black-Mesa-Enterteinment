﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Musics
{
    class ContaPremium : Conta
    {
        public ContaPremium(string nome, string senha, string email, bool banda)
        {
            this.Codigo = ++Codigo_Geral;
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.PossuiBanda = banda;
            this.Tipo_Conta = 1;
        }
        public void Compartilhar_Arquivos()
        {

        }
    }
}
