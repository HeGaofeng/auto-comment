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
        static string[] check_these = { "using", "void", "{", "}", "for", "(", ")", "double", "float", "string", "char", "int", "bool" }; //keywords to check for
        //izobshto trebva li void?
        static string keyword_found = string.Empty;
        static string[] split_sentence;
        static string result = string.Empty;
        static string checked_value;
        static string gore_dolu;
        static string inner_variable_name;
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
                    else
                    {
                        return_string[i] = Comment("default"); //tuk ni e komentara koito shte dobavim v kraq na reda
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
                if (var_type == "int" && var_type != "for")
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
                else if (var_type == "void") //void functions
                {
                    for (int i = 0; i < split_sentence.Length; i++)
                    {
                        if (split_sentence[i] == var_type)
                        {
                            var_name = split_sentence[i + 1];
                        }
                    }
                    comment = " //Void function with the name " + var_name + Environment.NewLine;
                    return comment;
                }
                //else if (var_type == "{")
                //{
                //    if (inNamespace == false && inClass == false && inFunction == false)
                //    {
                //        comment = " //entering namespace" + Environment.NewLine;
                //        inNamespace = true;
                //    }
                //    else if (inNamespace == true && inClass == false && inFunction == false)
                //    {
                //        comment = " //entering class" + Environment.NewLine;
                //        inNamespace = true;
                //        inClass = true;
                //    }
                //    else if (inNamespace == true && inClass == true && inFunction == false)
                //    {
                //        comment = " //entering function" + Environment.NewLine;
                //        inNamespace = true;
                //        inClass = true;
                //        inFunction = true;
                //    }
                //    return comment;
                //}
                //else if (var_type == "}") //ade ot namespace }
                //{
                //    if (inNamespace == true && inClass == false && inFunction == false)
                //    {
                //        comment = " //exiting namespace" + Environment.NewLine; //mahnah } raboti s nekoi failove s nekoi ne nz ko mu stava
                //        inNamespace = false;
                //        inClass = false;
                //        inFunction = false;
                //    }
                //    else if (inNamespace == true && inClass == true && inFunction == false)
                //    {
                //        comment = " //exiting class" + Environment.NewLine;
                //        inClass = false;
                //        inNamespace = true;
                //        inFunction = false;
                //    }
                //    else if (inNamespace == true && inClass == true && inFunction == true)
                //    {
                //        comment = " //exiting function" + Environment.NewLine;
                //        inFunction = false;
                //        inNamespace = true;
                //        inClass = true;
                //    }
                //    return comment;
                //}
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
                else if (var_type == "bool")
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
                    comment = " //The bool (true or false) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
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
                        if (split_sentence[i] == "for(int" || split_sentence[i] == "for(double" || split_sentence[i] == "for(float" || split_sentence[i] == "for(char" || split_sentence[i] == "for(string")
                        {
                            inner_variable_name = split_sentence[i + 1];
                        }
                        if (split_sentence[i] == "int")
                        {
                            inner_variable_name = split_sentence[i + 2];
                        }
                        if(split_sentence[i] == "=")
                        {
                            checked_value = split_sentence[i - 1] + " and " + split_sentence[i - 1].Trim(';') + " are equal";
                        }
                        if (split_sentence[i] == "<") //checkva kav check she ima
                        {
                            checked_value = split_sentence[i + 1].Trim(';') + " is higher";
                        }
                        if (split_sentence[i] == ">")
                        {
                            checked_value = split_sentence[i + 1].Trim(';') + " is lower";
                        }
                        if (split_sentence[i] == inner_variable_name + "++)") //checkva dali she adne ili she mahne edno
                        {
                            gore_dolu = "plus 1 (one) to " + inner_variable_name;
                        }
                        if (split_sentence[i] == inner_variable_name + "--)")
                        {
                            gore_dolu = "minus 1 (one) to " + inner_variable_name;
                        }
                    }
                    comment = " //A for loop with inner variable named " + inner_variable_name + " is equal to " + checked_value + ", then " + gore_dolu + Environment.NewLine;
                    return comment;
                }
            }
            return null; //no matter what it should never return null but I put it here just in case
        }
    }
}
/*
namespace auto_comment
{
    public class Options_Items
    {
        public void Commentmethod
		{
			bitch
		}
    }
ne bachka ^, dava greshka che // nemoge da empty



using System;
string read = Console.ReadLine();
int n = 10;
for(int i = 0; i < n; i++)
blyat
bachka ^
*/