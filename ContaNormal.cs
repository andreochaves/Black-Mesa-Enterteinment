using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Musics
{
    class ContaNormal : Conta
    {
        public ContaNormal(string nome, string senha, string email)
        {
            this.Codigo = ++Codigo_Geral;
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.PossuiBanda = false;
            this.Tipo_Conta = 0;
        }
        public void Mudar_Plano()
        {

        }
    }
}
