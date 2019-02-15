using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace auto_comment
{
    class TextEdit
    {
        public static string[] Split(string wholetext)
        {
            string[] splittext = wholetext.Split('\n'); //vrushta array ot stringove kato vseki ot tozi string suvpada s redovete
            return splittext; //just to push smth
        }
        public static string SpecificLine(string wholetext, int index)
        {
            string[] splittext = Split(wholetext);
            return splittext[index];
        }
        public static string[] SplitLine(string line)
        {
            Regex pattern = new Regex(@"\s");
            string[] splitsentence = pattern.Split(line);
            return splitsentence;
        }
        public static string DestroyLine(string wholetext, int index)
        {
            string[] splittext = Split(wholetext);
            splittext[index] = "";
            wholetext = splittext.ToString();
            return wholetext;
        }
    }
}
