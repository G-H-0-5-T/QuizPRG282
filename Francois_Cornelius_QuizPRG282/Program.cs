using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Francois_Cornelius_QuizPRG282
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
            Application.Run(new Form1());
            string[] users = File.ReadAllLines(@"C:\Users\fcorn\source\repos\Francois_Cornelius_QuizPRG282\Francois_Cornelius_QuizPRG282\bin\Debug\Users.txt");
            listBox1.Items.AddRange(users);
        }
    }
}
