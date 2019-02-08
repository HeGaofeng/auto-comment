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
        static string return_from_linecheker = "";//string used to store linecheckerretrun return value
        static string return_from_stringcreator = "";//string used to store stringcreator return value
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
<<<<<<< HEAD
            for(int i = 0; i < vremenen_input.Length; i++)
=======
            int input_lenght = vremenen_input.Length;
            for(int i = 0; i<input_lenght; i++)//feeds linetype checker evry line
>>>>>>> 85b07e9a3a9cdb3edf3498b08ed375a9e8e47208
            {
                LineTypeChecker(vremenen_input[i]);
                return_from_stringcreator = return_from_linecheker;
                StringCreator(return_from_stringcreator);
                test = "fuck";
            }
            
        }
        public static string LineTypeChecker(string curr)
        {
            string return_string = "";
            string[] split_curr = curr.Split(' ', '.');
            string[] check_these = {"int", "double", "float", "string","char" };
            foreach (string element in check_these)
            {
                if (split_curr[0].Contains(element))
                {
                    return_string = "Variable found is " + element;
                    return_from_linecheker = return_string;//get the foken value, copy paste this shit
                    return return_string;
                }
            }
            if(split_curr[0] == "for")
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
        public static string StringCreator(string need_second_function)
        {
            return "";
        }
    }

}
