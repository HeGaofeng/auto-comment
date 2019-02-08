using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_comment
{
    class TextEdit
    {
        public static string[] split(string wholetext)
        {
            wholetext = wholetext.Remove('\t'); //premahva vsichki tabove ot texta
            string[] splittext = wholetext.Split('\n'); //vrushta array ot stringove kato vseki ot tozi string suvpada s redovete
            return splittext;
        }
    }
}
