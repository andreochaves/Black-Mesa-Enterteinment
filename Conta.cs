using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Musics
{
    abstract class Conta
    {
        protected static int Codigo_Geral { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool PossuiBanda { get; set; }
        public int Tipo_Conta { get; set; }
        public string playlistscodes { get; set; }
        public List<Playlist> playlists = new List<Playlist>();
        public List<Conta> amigos = new List<Conta>();

        public string musicas_Path;

        public void Criar_Playlist(string nome)
        {
            playlists.Add(new Playlist(nome));
        }
        public string GetPlaylistsNomes()
        {
            string r = "";
            foreach(Playlist p in playlists)
            {
                r += p.Id+";";
            }
            return r;
        }
        public void Adicionar_Amigo(Conta m)
        {
            amigos.Add(m);
        }
        public void Excluir_Amigo(Conta m)
        {
            amigos.Remove(m);
        }
        public string GetAmigosNomes()
        {
            string r = "";
            foreach (Conta c in amigos)
            {
                r += c.Nome + ";";
            }
            return r;
        }
        public void Mudar_Senha(string nova_Senha)
        {
            this.Senha = nova_Senha;
        }
        public void Participar_Torneio(string codigo_Torneio)
        {
            //Não ia dar Tempo.
        }
        public static Conta operator+(Conta a, Conta b)
        {
            Conta c = a;
            c.Adicionar_Amigo(b);
            return c;
        }
        public static Conta operator-(Conta a, Conta b)
        {
            Conta c = a;
            c.Excluir_Amigo(b);
            return c;
        }
    }
}
