using System;
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

        public ControladorContas(){}
        public List<Conta> GetContas()
        {
            return ListaGeralContas;
        }
    }
    
}
