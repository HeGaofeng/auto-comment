using System;//Here we are declaring a namespace++
using System.Collections.Generic;//Here we are declaring a namespace++
using System.ComponentModel;//Here we are declaring a namespace++
using System.Data;//Here we are declaring a namespace++
using System.Drawing;//Here we are declaring a namespace++
using System.Linq;//Here we are declaring a namespace++
using System.Text;//Here we are declaring a namespace++
using System.Threading.Tasks;//Here we are declaring a namespace++
using System.Windows.Forms;//Here we are declaring a namespace++
using System.Diagnostics;//Here we are declaring a namespace++
using System.IO;//Here we are declaring a namespace++
//get type check daloi funci pochva s _ ili char ne cifra+++
{
    {
        static string[] curr_copy;//The string array curr_copy; is declared and it's elements are ++
        static string[] check_these = { "byte ", "bool ", "decimal ", "using ", "double ", "float ", "string ", "string[]", "char ", "int ", "var ", "continue;", "break;" };//The byte (whole number from 0 to 255)  is declared and it's value is {++
        static string keyword_found = string.Empty;//The string (a collection of characters)  is declared and it's value is string.Empty;++
        static string[] split_sentence;//The string array split_sentence; is declared and it's elements are ++
        static string result = string.Empty;//The string (a collection of characters)  is declared and it's value is string.Empty;++
        public static string GetCommentedVersion(string curr)//The string (a collection of characters)  is declared and it's value is ++
        {
            curr_copy = TextEdit.Split(curr);
            string[] return_string = new string[curr_copy.Length];//The string (a collection of characters)  is declared and it's value is new++
            for (int i = 0; i < curr_copy.Length; i++) //minava prez vseki red v koda+++
            {
                for (int j = 0; j < check_these.Length; j++) //provera dali reda sadurja nqkoa duma ot check_these+++
                {
                    //ako {} ili () gi nqma v check_these tva VUTRE v ifa ne se uzpulnqva koeto shte reche ne vliza v comment funkciata i ottam v textedit i zatova izqjda reda
                    if (curr_copy[i].Contains(check_these[j])) //dobavq komentar v string
                    {
                        keyword_found = check_these[j]; //namerenia keyword (s dumi a ne indeksa mu)
                        split_sentence = TextEdit.SplitLine(curr_copy[i]); //razdela tokushtia red na array ot dumi
                        return_string[i] = Comment(keyword_found); //tuk ni e komentara koito shte dobavim v kraq na reda
                        break;// The break statement terminates the closest enclosing loop or switch statement++
                    }
                    else if (curr_copy[i].Contains("{") || curr_copy[i].Contains("}") || curr_copy[i].Contains("(") || curr_copy[i].Contains(")"))
                    {
                        return_string[i] = Comment(keyword_found);
                    }
                }
            }
            for (int i = 0; i < curr_copy.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
            {
                if (return_string[i] != null)
                {
                    result += TextEdit.Connect(curr_copy[i], return_string[i]);
                }
                {
                    continue;// The continue statement passes control to the next iteration of the enclosing loop or switch statement++
                }
            }
        }
        private static string Comment(string var_type)//The string (a collection of characters)  is declared and it's value is ++
        {
            string var_name = "";//The string (a collection of characters)  is declared and it's value is "";++
            string var_value = "";//The string (a collection of characters)  is declared and it's value is "";++
            string comment = "";//The string (a collection of characters)  is declared and it's value is "";++
            if (string.Join(" ", split_sentence).Contains("//") || var_type == "default")
            {
                if (var_type == "default")
            }
            {
                if (var_type == "int ")//The integer (a whole number)  is declared and it's value is ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The integer (a whole number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                }
                else if (var_type == "double ")//The double (precision: 15-17)  is declared and it's value is ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The double (precision: 15-17) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "float ")//The float (precision: 6-9)  is declared and it's value is ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The float (precision: 6-9) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "decimal ")//The decimal (preicion: 28-29)  is declared and it's value is ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The decimal (preicion: 28-29) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "break;")// The break statement terminates the closest enclosing loop or switch statement++
                {
                }
                else if (var_type == "continue;")// The continue statement passes control to the next iteration of the enclosing loop or switch statement++
                {
                }
                else if (var_type == "var ")// StOp UsInG vAr GaY FaGgOt++
                {
                }
                else if (var_type == "string ")//The string (a collection of characters)  is declared and it's value is ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The string (a collection of characters) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "string[]")//The string array  is declared and it's elements are ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The string array " + var_name + " is declared and it's elements are " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "char ")//The char (a unicode character)  is declared and it's value is ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The char (a unicode character) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "bool ")//The boolean (true or false)  is declared and it's value is ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The boolean (true or false) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                }
                else if (var_type == "byte ")//The byte (whole number from 0 to 255)  is declared and it's value is ++
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = "//The byte (whole number from 0 to 255) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "using ")//Here we are declaring a namespace++
                {
                }
            }
        }
        private static string Comment(string var_type)//The string (a collection of characters)  is declared and it's value is ++
        {
            string var_name = "";//The string (a collection of characters)  is declared and it's value is "";++
            string var_value = "";//The string (a collection of characters)  is declared and it's value is "";++
            string comment = "";//The string (a collection of characters)  is declared and it's value is "";++
            if (split_sentence.Contains("//"))
            {
            }
            {
                if (var_type == "int" && var_type != "for")
                {
                    if (split_sentence.Contains("["))
                    {
                        for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                        {
                            if (split_sentence[i] == var_type)
                            {
                            }
                            if (split_sentence[i] == "=")
                            {
                            }
                        }
                        comment = " //The integer array (a whole numbers array) " + var_name + " is declared." + Environment.NewLine;
                    }
                    {
                        for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                        {
                            if (split_sentence[i] == var_type)
                            {
                            }
                            if (split_sentence[i] == "=")
                            {
                            }
                        }
                        comment = " //The integer (a whole number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                    }
                }
                else if (var_type == "void") //void functions
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                    }
                }
                else if (var_type == "{")
                {
                    if (innamespace == false && inclass == false && infunction == false)
                    {
                    }
                    else if (innamespace == true && inclass == false && infunction == false)
                    {
                    }
                    else if (innamespace == true && inclass == true && infunction == false)
                    {
                    }
                }
                else if (var_type == "}") //ade ot namespace }
                {
                    if (innamespace == true && inclass == false && infunction == false)
                    {
                        comment = " //exiting namespace" + Environment.NewLine; //mahnah } raboti s nekoi failove s nekoi ne nz ko mu stava
                    }
                    else if (innamespace == true && inclass == true && infunction == false)
                    {
                    }
                    else if (innamespace == true && inclass == true && infunction == true)
                    {
                    }
                }
                else if (var_type == "double")
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = " //The integer (a whole number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;
                }
                else if (var_type == "bool")
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = " //The bool (true or false) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "float")
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = " //The float (a floating point number) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "string")
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = " //The string (a collection of characters) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "char")
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == var_type)
                        {
                        }
                        if (split_sentence[i] == "=")
                        {
                        }
                    }
                    comment = " //The char (a unicode character) " + var_name + " is declared and it's value is " + var_value + Environment.NewLine;+++
                }
                else if (var_type == "using")
                {
                }
                else if (var_type == "for")
                {
                    for (int i = 0; i < split_sentence.Length; i++)//The integer (a whole number)  is declared and it's value is 0;++
                    {
                        if (split_sentence[i] == "for(int" || split_sentence[i] == "for(double" || split_sentence[i] == "for(float" || split_sentence[i] == "for(char" || split_sentence[i] == "for(string")
                        {
                        }
                        if (split_sentence[i] == "int")
                        {
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
                }
            }
        }
    }

