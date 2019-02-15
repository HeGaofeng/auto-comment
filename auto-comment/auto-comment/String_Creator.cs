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
    class String_Creator
    {
        static string[] curr_copy;
        static string[] check_these = { "int", "double", "float", "string", "char", "using" }; //keywords to check for
        static string commeneted_variable_string_global = "";
        static string keyword_found = "";
        static string[] split_sentence;
        static string result = "";

        public static string GetCommentedVersion(string curr)
        {
            curr_copy = TextEdit.Split(curr);
            string[] return_string = new string[curr_copy.Length];
            for (int i = 0; i < curr_copy.Length; i++) //minava prez vseki red v koda
            {
                for (int j = 0; j < check_these.Length; j++) //provera dali reda sadurja nqkoa duma ot check_these
                {
                    if (curr_copy[i].Contains(check_these[j])) //dobavq komentar v string
                    {
                        keyword_found = check_these[j]; //namerenia keyword (s dumi a ne indeksa mu)
                        split_sentence = TextEdit.SplitLine(curr_copy[i]); //razdela tokushtia red na array ot dumi
                        return_string[i] = Comment(keyword_found); //tuk ni e komentara koito shte dobavim v kraq na reda
                        break;
                    }
                }
            }
            for (int i = 0; i < curr_copy.Length; i++)
            {
                if (return_string[i] != null)
                {
                    result += curr_copy[i] + return_string[i];
                }
                else
                {
                    continue;
                }
            }
            return result;
        }

        //funciata ne e testvana napulno no bi trabvalo da raboti
        //probvah s nqkolko fila i nqmashe greshki no koda ne e perfekten taka che vnimavai kade pipash
        //Bugs found:
        //ako imame array ignorva dumata zashtoto stringa e SOMETHINGHERE[] vmesto SOMETHINGHERE a nie v momenta chekvame samo vtoroto
        //
        private static string Comment(string var_type)
        {
            int indexofkeyword = 0;
            string var_name = "";
            string var_value = "";
            string comment = "";

            if (split_sentence.Contains("//"))
            {
                return "";
            }
            else
            {
                if (var_type == "int")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            indexofkeyword = i;
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = "//The integer (a whole number) " + var_name + " is declared and it's value is " + var_value + '\n';
                    return comment;
                }
                //down from here is probably not working and requires testing
                else if (var_type == "double")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            indexofkeyword = i;
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = "//The integer (a whole number) " + var_name + " is declared and it's value is " + var_value + '\n';
                    return comment;
                }
                else if (var_type == "float")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            indexofkeyword = i;
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = "//The float (a floating point number) " + var_name + " is declared and it's value is " + var_value + '\n';
                    return comment;
                }
                else if (var_type == "string")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            indexofkeyword = i;
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = "//The string (a collection of characters) " + var_name + " is declared and it's value is " + var_value + '\n';
                    return comment;
                }
                else if (var_type == "char")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            indexofkeyword = i;
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = "//The char (a unicode character) " + var_name + " is declared and it's value is " + var_value + '\n';
                    return comment;
                }
                else if (var_type == "using")
                {
                    comment = "//Here we are declaring a namespace" + '\n';
                    return comment;
                }
            }

            return null; //no matter what it should never return null but I put it here just in case
        }

        private static string CommenetedLineWriter(string commented_line_input)
        {
            DialogResult test = MessageBox.Show(commeneted_variable_string_global);
            return commented_line_input;
        }
    }
}
