using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Musics
{
    class ContaPremium : Conta
    {
        public ContaPremium(string nome, string senha, string email, string musicaspath)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.PossuiBanda = false;
            this.musicas_Path = musicaspath;
            this.Tipo_Conta = 1;
        }
        public void Compartilhar_Arquivos()
        {

        }
    }
}
