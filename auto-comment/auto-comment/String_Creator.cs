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
        static int keyword_location = 0;
        static string return_from_linecheker_using = "";
        static string commeneted_using_string_global = "";
        static string[] split_curr;
        static string splcommeneted_variable_string_globalit_curr = "";
        static string commeneted_variable_string_global = "";
        static string keyword_found = "";
        static string[] split_sentence;

        public static string GetCommentedVersion(string curr)
        {
            curr_copy = TextEdit.Split(curr);
            string[] return_string = new string[curr_copy.Length];
            string result = "";
            for (int i = 0; i < curr_copy.Length; i++) //minava prez vseki red v koda
            {
                for (int j = 0; j < check_these.Length; j++) //provera dali reda sadurja nqkoa duma ot check_these
                {
                    if (curr_copy[i].Contains(check_these[j])) //dobavq komentar v string
                    {
                        keyword_location = i; //namira na koi index ot check these e keyworda v nachaloto
                        keyword_found = check_these[j]; //namerenia keyword (s dumi a ne indeksa mu)
                        split_sentence = TextEdit.SplitLine(curr_copy[i]); //razdela tokushtia red na array ot dumi
                        return_string[i] = Comment(keyword_found); //tuk ni e komentara koito shte dobavim v kraq na reda
                        //return_string[i] = " //Variable found is " + check_these[j] + '\n';
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
        static string Comment(string var_type)
        {
            int indexofkeyword = 0;
            string var_name = "";
            string var_value = "";
            string comment = "";

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

            return null; //no matter what it should never return null but I put it here just in case
        }

        public static string StringCreator_using(string selector_input_using)
        {
            string commeneted_using_string = return_from_linecheker_using + " //Adds library";
            commeneted_using_string_global = commeneted_using_string;
            DialogResult test2 = MessageBox.Show(commeneted_using_string_global);
            return selector_input_using;
        }
        public static string String_creator_int(string String_creator_int_null)
        {

            return String_creator_int_null;
        }
        public static string StringCreator_variable(string StringCreator_variable_input_string)
        {
            string commeneted_variable_string = "";
            if (curr_copy.Contains("Console.ReadLine") == true)
            {
                commeneted_variable_string = " //This is " + split_curr[1] + " a " + split_curr[0] + " type variable and it is entered by the user.";
                commeneted_variable_string_global = commeneted_variable_string;
            }
            else
            {
                //int inx_equals = curr_copy.IndexOf(@"=");
                //int inx_needed = 
                commeneted_variable_string = " //This is a " + split_curr[0] + " type variable and it is currently equal to ";
                commeneted_variable_string_global = commeneted_variable_string;
            }
            return null;
        }
        public static string StringCreator_selector(string selector_input_string)
        {
            return selector_input_string;
        }
        public static string CommenetedLineWriter(string commented_line_input)
        {
            DialogResult test = MessageBox.Show(commeneted_variable_string_global);
            return commented_line_input;
        }
    }
}
