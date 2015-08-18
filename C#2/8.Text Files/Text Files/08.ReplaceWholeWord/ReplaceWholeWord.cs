﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.ReplaceWholeWord
{
    class ReplaceWholeWord
    {
        /*
         Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
         */
        static void Main()
        {
            StreamReader replace = new StreamReader(@"..\..\..\08StartFinish.txt");
            StreamWriter replaceWrite = new StreamWriter(@"..\..\..\08Write.txt");
            using (replace)
            {
                using (replaceWrite)
                {
                    string text = String.Empty;
                    text = (replace.ReadToEnd());
                    string word = "finish";
                    //string wordInText = "start";
                    string pattern = @"\bstart\b";
                    text = Regex.Replace(text, pattern, word);
                    replaceWrite.Write(text);
                }

            }
        }
    }
}
