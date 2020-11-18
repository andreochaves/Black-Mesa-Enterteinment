using System;
using System.Windows.Forms;

namespace Lets_Musics
{
    static class Program
    {
        public static Login_Tela tela_login;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(tela_login = new Login_Tela());
            tela_login = new Login_Tela();
            tela_login.Show();

        }
    }
}
