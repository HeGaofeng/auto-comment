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
            wholetext = wholetext.Remove('\t');
            string[] splittext = wholetext.Split('\n');
            return splittext;
        }
    }
}
