using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextQuickFixer
{
    class StringFixer
    {
        public string remove_n_r(string  inputStr) 
        {
            var outputString = inputStr.Replace("\n", "");
            outputString = outputString.Replace("\r", "");
            return outputString;
        }
        /// <summary>
        /// 移除多余空格
        /// </summary>
        /// <returns></returns>
        public string removeBlanks(string str)
        {
            int len0 = str.Length;
            int len1 = 0;
            do
            {
                len0 = len1;
                str = str.Replace("  ", " ");
                len1 = str.Length;
            } while (len1!=len0);
            return str;

        }

        public string sb_Append(string str)
        {
            
            var strArray = str.Split('\n');
            var output = "";
            foreach (var s in strArray)
            {
                var ss = s.Replace("\n","").Replace("\r", "");
                output = output + "sb.Append(\" " + ss + " \");\n";
            }
            output = removeBlanks(output);
            return output;
        }
    }
}
