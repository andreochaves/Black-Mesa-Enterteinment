using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_Musics
{
    class Playlist
    {
        public static int IdGeral = 0;
        public int Id { get; }
        public List<Musica> Musicas = new List<Musica>();
        public int [] ordemTemp;
        public int[] ordemNormal;
      

        public string Autor { get; set; }

        public int Duracao { get; set; }

        // public string

        //subgenero

        public string Nome { get; set; }
        public Playlist(string n)
        {
            Id = ++IdGeral;
            Nome = n;
        }
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

        public void Proxima_Musica(Musica m, int p)
        {

        }

        public void Anterior_Musica(Musica m, int p)
        {

        }
       
        public static Playlist operator+(Playlist p, Musica m)
        {
            Playlist jota = p;
            jota.Adicionar_Musica(m);
            return jota;
        }
        public static Playlist operator-(Playlist p, Musica m)
        {
            Playlist jota = p;
            jota.Excluir_Musica(m.Nome);
            return jota;
        }
    }




}
