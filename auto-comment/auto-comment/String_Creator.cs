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
        static string[] check_these = { "int", "double", "float", "string", "char", "using", "for", "{", "}"}; //keywords to check for
        static string commeneted_variable_string_global = string.Empty;
        static string keyword_found = string.Empty;
        static string[] split_sentence;
        static string result = string.Empty;
        static string checked_value;
        static string gore_dolu1;
        static int funk; //chekva v kvo sme, 0 e klas

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
                    result += TextEdit.Connect(curr_copy[i], return_string[i]);
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
                    if (split_sentence.Contains("["))
                    {
                        var_type += "[]";
                        for (int i = 0; i < split_sentence.Length; i++)
                        {
                            if (split_sentence[i] == var_type)
                            {
                                var_name = split_sentence[i + 1];
                            }
                            if (split_sentence[i] == "=")
                            {
                                var_value = split_sentence[i + 1];
                            }
                        }
                        comment = " //The integer array (a whole numbers array) " + var_name + " is declared." + Environment.NewLine;
                        return comment;
                    }
                    else
                    {
                        for (int i = 0; i < split_sentence.Length; i++)
                        {
                            if (split_sentence[i] == var_type)
                            {
                                var_name = split_sentence[i + 1];
                            }
                            if (split_sentence[i] == "=")
                            {
                                var_value = split_sentence[i + 1];
                            }
                        }
                        comment = " //The integer (a whole number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                        return comment;
                    }
                }
                //down from here is probably not working and requires testing
                else if (var_type == "double")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = " //The integer (a whole number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "float")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = " //The float (a floating point number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "string")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = " //The string (a collection of characters) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "char")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                    }
                    comment = " //The char (a unicode character) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "using")
                {
                    comment = " //Here we are declaring a namespace" + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "for")
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == "(") //checkva za otvarane na scobite na for
                        {
                            var_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "=")
                        {
                            var_value = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "<" || split_sentence[i] == ">") //checkva kav check she ima
                        {
                            checked_value = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "++") //checkva dali she adne ili she mahne edno
                        {
                            gore_dolu1 = var_name + "plus 1 (one)";
                        }
                        if (split_sentence[i] == "--")
                        {
                            gore_dolu1 = var_name + "minus 1 (one)";
                        }
                    }
                    comment = " //A for loop with inner variable " + var_name + "  equal to" + var_value + " then it is checked against " + checked_value + ", " + gore_dolu1 + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "{")//opravi koda tva e maiche dobar base
                {
                    if(funk == 0)
                    {
                        comment = " //The float (a floating point number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                        funk++;
                        return comment;
                    }
                    else if(funk == 1)
                    {
                        comment = " //The float (a floating point number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                        funk++;
                        return comment;
                    }

                }
            }

            return null; //no matter what it should never return null but I put it here just in case
        }
        //muda?
        private static string CommenetedLineWriter(string commented_line_input)
        {
            DialogResult test = MessageBox.Show(commeneted_variable_string_global);
            return commented_line_input;
        }
    }
}
