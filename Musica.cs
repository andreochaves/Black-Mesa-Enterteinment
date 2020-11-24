using System;
using System.Collections.Generic;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lets_Musics
{
    class Musica
    {
        public string Path { get; set; }
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public string Banda { get; set; }

        Mp3Lib.Mp3File file;
        //genero

        public Musica(string p) 
        {
            Path = p;
            file = new Mp3Lib.Mp3File(p);
            Nome = file.TagHandler.Title;
            Artista = file.TagHandler.Artist;
            Duracao = 0;
            string[] d = file.TagHandler.Length.ToString().Split(':');
            for (int i = 0; i < d.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Duracao += 60 * 60 * int.Parse(d[i]);
                        break;
                    case 1:
                        Duracao += 60 * int.Parse(d[i]);
                        break;
                    case 2:
                        Duracao += int.Parse(d[i]);
                        break;
                }
            }
        }
    }
}
