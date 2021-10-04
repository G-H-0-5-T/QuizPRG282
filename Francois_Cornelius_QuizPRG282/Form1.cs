using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Francois_Cornelius_QuizPRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            //Step 16
            lbMain.DataSource = File.ReadAllLines(@"C:\Users\fcorn\source\repos\Francois_Cornelius_QuizPRG282\Francois_Cornelius_QuizPRG282\bin\Debug\Users.txt");

        }
    }
}
