using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_Musics
{
    class ControladorContas
    {
        public static List<Conta> ListaGeralContas = new List<Conta>();
		string nome, senha, email;
    	int tipo;
    	bool pBanda;
        public ControladorContas(){}
        public List<Conta> GetContas()
        {
            return ListaGeralContas;
        }
        public void AtualizarContas()
        {
        	LimparContas();
        	ListaGeralContas = new List<Conta>();
        	CarregarContas();
        }
        public void LimparContas()
        {
        	ListaGeralContas = null;
        }
        public void CarregarContas()
        {
        	string contas_File = File.ReadAllText("../../Contas.txt");
            string[] load_contas = contas_File.Split('}');
        	
        	foreach (string k in load_contas)
            {
                
                int count = 0;
                string[] conta_info = k.Split(',');
                foreach (string j in conta_info)
                {
                    switch (count)
                    {
                        case 1:
                            tipo = int.Parse(j.Split(':')[1]);
                            break;
                        case 2:
                            nome = j.Split(':')[1];
                            break;
                        case 3:
                            senha = j.Split(':')[1];
                            break;
                        case 4:
                            email = j.Split(':')[1];
                            break;
                        case 5:
                            pBanda = bool.Parse(j.Split(':')[1]);
                            break;
                        
                    }
                    count++;
                }
                if (tipo == 0)
                {
                    ListaGeralContas.Add(new ContaNormal(nome, senha, email));
                }
                else
                {
                    ListaGeralContas.Add(new ContaPremium(nome, senha, email));
                }
                ListaGeralContas.Last().PossuiBanda = pBanda;
                
            }
        }
    }
    
}
