﻿using System;
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

        public string musicas_Path;
        public void Criar_Playlist(string nome)
        {

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
        public void Adicionar_Amigo(string codigo)
        {

        }
        public void Mudar_Senha(string nova_Senha)
        {
            this.Senha = nova_Senha;
        }
        public void Participar_Torneio(string codigo_Torneio)
        {

        }
        public void Upload_Musica(string musica_path)
        {

        }
    }
}
