using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Musics
{
    class Playlist
    {
        public List<Musica> Musicas = new List<Musica>();
        public int [] ordemTemp;
        public int[] ordemNormal;
      

        public string Autor { get; set; }

        public int Duracao { get; set; }

        // public string

        //subgenero

        public string Nome { get; set; }

        public void Adicionar_Musica(Musica m)
        {
            Musicas.Add(m);
        }

        public void Excluir_Musica(string n)
        {
            foreach (Musica m in Musicas) {
                if (m.Nome == n)
                {
                    Musicas.Remove(m);                    
                }
            }
        }

        public void Alterar_Ordem(Musica m, int p)
        {
            
        }

        public void Filtro (string t)
        {

        }
       
    }




}
