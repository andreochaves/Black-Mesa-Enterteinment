using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Musics
{
    class Genero
    {
        public string Nome { get; set; }
        public List<string> Subgeneros { get; set; }

        public Genero(string n, List<string> sub)
        {
            Nome = n;
            Subgeneros = sub;
        }
    }
}
