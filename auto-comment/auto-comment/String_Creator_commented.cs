using System; //Here we are declaring a namespace
using System.Collections.Generic; //Here we are declaring a namespace
using System.ComponentModel; //Here we are declaring a namespace
using System.Data; //Here we are declaring a namespace
using System.Drawing; //Here we are declaring a namespace
using System.Linq; //Here we are declaring a namespace
using System.Text; //Here we are declaring a namespace
using System.Threading.Tasks; //Here we are declaring a namespace
using System.Windows.Forms; //Here we are declaring a namespace
using System.Diagnostics; //Here we are declaring a namespace
using System.IO; //Here we are declaring a namespace
//get type check daloi funci pochva s _ ili char ne cifra +
{
    {
        static string[] curr_copy; //The collection of strings curr_copy; is declared
        static string[] check_these = //The collection of strings check_these is declared
        { "byte ", "bool ", "decimal ", "using ", "double ", "float ", "string ", "string[]", "char ", "int ", "var ", "continue;", "break;" }; //The byte (whole number from 0 to 255)  is declared and it's value is 
        //keywords to check for
        static string keyword_found = string.Empty; //The string (a collection of characters)  is declared and it's value is string.Empty;
        static string[] split_sentence; //The collection of strings split_sentence; is declared
        static string result = string.Empty; //The string (a collection of characters)  is declared and it's value is string.Empty;
        public static string GetCommentedVersion(string curr) //The string (a collection of characters)  is declared and it's value is 
        {
            curr_copy = TextEdit.Split(curr);
            string[] return_string = new string[curr_copy.Length]; //The string (a collection of characters)  is declared and it's value is new
            for (int i = 0; i < curr_copy.Length; i++) //minava prez vseki red v koda +
            {
                for (int j = 0; j < check_these.Length; j++) //provera dali reda sadurja nqkoa duma ot check_these +
                {
                    //ako {} ili () gi nqma v check_these tva VUTRE v ifa ne se uzpulnqva koeto shte reche ne vliza v comment funkciata i ottam v textedit i zatova izqjda reda
                    if (curr_copy[i].Contains(check_these[j])) //dobavq komentar v string
                    {
                        keyword_found = check_these[j]; //namerenia keyword (s dumi a ne indeksa mu)
                        split_sentence = TextEdit.SplitLine(curr_copy[i]); //razdela tokushtia red na array ot dumi
                        return_string[i] = Comment(keyword_found); //tuk ni e komentara koito shte dobavim v kraq na reda
                        break; //The break statement terminates the closest enclosing loop or switch statement
                    }
                    else if (curr_copy[i].Contains("{") || curr_copy[i].Contains("}") || curr_copy[i].Contains("(") || curr_copy[i].Contains(")") || curr_copy[i].Contains("for") || curr_copy[i].Contains("if") || curr_copy[i].Contains("else") || curr_copy[i].Contains("return") || curr_copy[i].Contains(".") || curr_copy[i].Contains("="))
                    {
                        keyword_found = "default";
                        return_string[i] = Comment(keyword_found);
                    }
                }
            }
            for (int i = 0; i < curr_copy.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
            {
                if (return_string[i] != null)
                {
                    result += TextEdit.Connect(curr_copy[i], return_string[i]);
                }
                else
                {
                    continue; //The continue statement passes control to the next iteration of the enclosing loop or switch statement
                }
            }
            return result;
        }
        private static string Comment(string var_type) //The string (a collection of characters)  is declared and it's value is 
        {
            string var_name = ""; //The string (a collection of characters)  is declared and it's value is "";
            string var_value = ""; //The string (a collection of characters)  is declared and it's value is "";
            string comment = ""; //The string (a collection of characters)  is declared and it's value is "";
            if (string.Join(" ", split_sentence).Contains("//") || var_type == "default")
            {
                if (var_type == "default")
                    return Environment.NewLine;
                else
                    return " +" + Environment.NewLine;
            }
            else
            {
                if (var_type == "int ") //The integer (a whole number)  is declared and it's value is 
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                else if (var_type == "double ") //The double (precision: 15-17)  is declared and it's value is 
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                    comment = " //The double (precision: 15-17) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine; +
                    return comment;
                }
                else if (var_type == "float ") //The float (precision: 6-9)  is declared and it's value is 
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                    comment = " //The float (precision: 6-9) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine; +
                    return comment;
                }
                else if (var_type == "decimal ") //The decimal (preicion: 28-29)  is declared and it's value is 
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                    comment = " //The decimal (preicion: 28-29) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine; +
                    return comment;
                }
                else if (var_type == "break;") //The break statement terminates the closest enclosing loop or switch statement
                {
                    comment = " //The break statement terminates the closest enclosing loop or switch statement" + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "continue;") //The continue statement passes control to the next iteration of the enclosing loop or switch statement
                {
                    comment = " //The continue statement passes control to the next iteration of the enclosing loop or switch statement" + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "var ") //StOp UsInG vAr GaY FaGgOt
                {
                    comment = " //StOp UsInG vAr GaY FaGgOt" + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "string ") //The string (a collection of characters)  is declared and it's value is 
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                    comment = " //The string (a collection of characters) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine; +
                    return comment;
                }
                else if (var_type == "string[]") //The collection of strings  is declared
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                    comment = " //The collection of strings " + var_name + " is declared" + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "char ") //The char (a unicode character)  is declared and it's value is 
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                    comment = " //The char (a unicode character) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine; +
                    return comment;
                }
                else if (var_type == "bool ") //The boolean (true or false)  is declared and it's value is 
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                    comment = " //The boolean (true or false) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                    return comment;
                }
                else if (var_type == "byte ") //The byte (whole number from 0 to 255)  is declared and it's value is 
                {
                    for (int i = 0; i < split_sentence.Length; i++) //The integer (a whole number)  is declared and it's value is 0;
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
                    comment = " //The byte (whole number from 0 to 255) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine; +
                    return comment;
                }
                else if (var_type == "using ") //Here we are declaring a namespace
                {
                    comment = " //Here we are declaring a namespace" + Environment.NewLine;
                    return comment;
                }
            }
            return Environment.NewLine;
        }
    }


