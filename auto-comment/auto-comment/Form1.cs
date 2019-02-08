using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_comment
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            //TextEdit
        }

        private void btn_comment_Click(object sender, EventArgs e)
        {
            //put input string when you make it
            string[] vremenen_input = { "int n = int.Parse(Console.ReadLine())", "int z = int.Parse(Console.ReadLine())", "for(int i = 0; i<n; i++)", "{", "z+=1", "}", "Console.WriteLine(z)" };
            LineTypeChecker(vremenen_input[0]);
        }
        public static string LineTypeChecker(string curr)
        {
            if (curr.Contains("int")) ;
        }
    }

}
