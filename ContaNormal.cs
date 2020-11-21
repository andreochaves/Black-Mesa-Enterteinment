using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Musics
{
    class ContaNormal : Conta
    {
        public ContaNormal(string nome, string senha, string email, string musicaspath)
        {
            this.Codigo = ++Codigo_Geral;
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.PossuiBanda = false;
            this.Tipo_Conta = 0;
            this.musicas_Path = musicaspath;
        }
        public void Mudar_Plano()
        {

        }
    }
}
