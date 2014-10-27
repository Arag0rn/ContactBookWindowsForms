using ContactBookText.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBookText
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin formLogin = new FormLogin();
            DialogResult loginResult = formLogin.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                Application.Run(new FormManager());
            }
        }
    }
}
