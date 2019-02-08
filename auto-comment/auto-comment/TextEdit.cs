using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_comment
{
    class TextEdit
    {
        public static string[] Split(string wholetext)
        {
            wholetext = wholetext.Trim('\t'); //premahva vsichki tabove ot texta
            string[] splittext = wholetext.Split('\n'); //vrushta array ot stringove kato vseki ot tozi string suvpada s redovete
            return splittext; //just to push smth
        }
        public static string SpecificLine(string wholetext, int index)
        {
            string[] splittext = Split(wholetext); 
            return splittext[index];
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
