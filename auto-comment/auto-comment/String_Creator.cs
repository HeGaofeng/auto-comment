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
        static string return_from_linecheker = ""; //string used to store linecheckerretrun return values
        static string return_from_linecheker_using = ""; //reeeee maiche e muda
        static string text = ""; //text received from the user
        static string[] split_curr;
        static string[] curr_copy;
        static string commeneted_variable_string_global;
        static string commeneted_using_string_global;
        //tuka noiv neshta opitvam
        static bool isUsing = false;
        static bool isInt = false;
        static bool isString = false;
        static bool isFloat = false;
        static bool isDouble = false;
        static bool isBool = false;
        static bool isConsole = false;
        static string[] check_these = { "int", "double", "float", "string", "char", "using" }; //keywords to check for
        static int index_keyword = 0;

        public static string GetCommentedVersion(string curr)
        {
            curr_copy = TextEdit.Split(curr);
            string return_string = "";
            foreach (string element in curr_copy) //minava prez vseki red v koda
            {
                for (int i = 0; i < check_these.Length; i++) //provera dali reda sadurja nqkoa duma ot check_these
                {
                    if (element.Contains(check_these[i])) //dobavq komentar v string
                    {
                        index_keyword = i;//namira na koi index ot check these e namerenia keyword
                        return_string += "//Variable found is " + check_these[i] + '\n'; 
                    }
                    else
                    {
                        return_string += "//Nothing found here \n";
                    }
                }
            }
            return return_string;
            /*
            if (split_curr[0] == "using")
            {
                isUsing = true;
            }
            else if (split_curr[0] == "int")
            {
                isInt = true;
            }
            else if (split_curr[0] == "string")
            {
                isString = true;
            }
            else if (split_curr[0] == "float")
            {
                isFloat = true;
            }
            else if (split_curr[0] == "double")
            {
                isDouble = true;
            }
            else if (split_curr[0] == "bool")
            {
                isBool = true;
            }
            else if (split_curr[0] == "Console")
            {
                isConsole = true;
            }
            //if(split_curr[0] == "for")
            //{
            //    return_string = "For";
            //    return_from_linecheker = return_string;//maiche e neshto staro de ne se izpolzva, vikai ot tuka funciata?

            //    return return_string;
            //}
            //else if(split_curr[0] == "Console")
            //{
            //    return_string = "Console";
            //    return_from_linecheker = return_string;
            //    return return_string;
            //}
            //else if(split_curr[0] == "if")
            //{
            //    return_string = "If";
            //    return_from_linecheker = return_string;
            //    return return_string;
            //}
            //if (split_curr[0] == "using")
            //{
            //    //tva maiche trebva taka da go prenapishem
            //    return_string = "using";
            //    return_from_linecheker_using = curr_copy;
            //    return return_using;
            //}
            return null;
            */
        }
        public static string BoolCheckerAndFunctionCaller(string BoolCheckerAndFunctionCaller_null)
        {
            if (isUsing == true)
            {
                StringCreator_using(null);
            }
            if (isInt == true)
            {

            }
            return BoolCheckerAndFunctionCaller_null;
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
            /*
            if(split_curr[4] == "")//this check shows that when the ; is split into the last of split_curr it is empty and making a check if it is empty returns true
            {
                DialogResult test2 = MessageBox.Show("yee");
            }
            */
            return commented_line_input;
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
