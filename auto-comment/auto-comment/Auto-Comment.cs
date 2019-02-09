using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace auto_comment
{
    public partial class Form1 : Form
    {
        static string return_from_linecheker = "";//string used to store linecheckerretrun return value
        static string return_from_stringcreator = "";//string used to store stringcreator return value
        static string text = ""; //text received from the user

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_twitter_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://twitter.com/FLasersights"); //slagame linka koito iskame da otvorim tuk
            Process.Start(sInfo); //otvara goreposochenia link s default browsera (tozi koito potrebitelq e izbral kato default za negovia comp)
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            //ot tuk nadolu vsichko e copy pasta taka che nz kolko e dobro
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt| C# Files (*.cs)|*.cs";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    if (fileContent != null)
                    {
                        text = fileContent;
                    }
                }
            }
        }
        private void btn_comment_Click(object sender, EventArgs e)
        {
            string[] input = GetText();
            //put input string when you make it
            //string[] vremenen_input = { "int n = int.Parse(Console.ReadLine())", "int z = int.Parse(Console.ReadLine())", "for(int i = 0; i<n; i++)", "{", "z+=1", "}", "Console.WriteLine(z)" };
            for(int i = 0; i < input.Length; i++)//feeds linetype checker every line
            {
                LineTypeChecker(input[i]);
                return_from_stringcreator = return_from_linecheker;
                StringCreator(return_from_stringcreator);
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
                    return_from_linecheker = return_string;//gets the foken value, copy paste this shit
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static string[] GetText() //pulni array s texta vzet ot user
        {
            if (text == "")
            {
                return null;
            }
            else
            {
                string[] return_text = TextEdit.Split(text);
                return return_text;
            }
        }
    }
}
