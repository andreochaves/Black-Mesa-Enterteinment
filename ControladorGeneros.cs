using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Musics
{
    class ControladorGeneros
    {
        public static List<Genero> generos { get; set; }
        string nome;
        List<string> subgeneros;


        public ControladorGeneros() 
        {
            generos = new List<Genero>();
            subgeneros = new List<string>();
        }
        public void CarregarGeneros()
        {
            string contas_File = File.ReadAllText("../../Generos.txt");
            string[] load_contas = contas_File.Split('}');

            foreach (string k in load_contas)
            {

                int count = 0;
                string[] conta_info = k.Split(',');
                if (count == 0)
                {
                    nome = conta_info[0];
                }
                else
                {
                    string[] sub = conta_info[1].Split(';');
                    foreach(string j in sub)
                    {
                        subgeneros.Add(j);
                    }
                }
            }
            generos.Add(new Genero(nome, subgeneros));
        }
    }
}
