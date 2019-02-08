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
            int input_lenght = vremenen_input.Length;
            for(int i = 0; i<input_lenght; i++)
            {
                LineTypeChecker(vremenen_input[i]);
            }
            LineTypeChecker(vremenen_input[0]);
        }
        public static string LineTypeChecker(string curr)
        {
            string return_string = "";
            string[] split_curr = curr.Split(' ', '.');
            if(split_curr[0] == "int" || split_curr[0] == "double" || split_curr[0] == "float" || split_curr[0] == "string" || split_curr[0] == "char")
            {
                return_string = "Variable";
                return return_string;
            }
            else if(split_curr[0] == "for")
            {
                return_string = "For";
                return return_string;
            }
            else if(split_curr[0] == "Console")
            {
                return_string = "Console";
                return return_string;
            }
            return null;
        }

        //public static string StringCreator(string need)
        //{

        //}
    }

}
