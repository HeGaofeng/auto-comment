using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_comment
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
            string text = "i tell u wah t you fat little cunt       i will soft pick you" +
                "bas \n eat 4 am faggot";
            string[] test = TextEdit.split(text);
            foreach(string elemnt in test)
            {
                MessageBox.Show(elemnt);
            }
            
        }
    }
}
