using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt101Exerc03
{
    class StringSearcher
    {
        Char firstChar;

        public StringSearcher(Char firstChar)
        {
            this.firstChar = Char.ToUpper(firstChar);
        }

        public bool StartsWith(String s)
        {
            if (String.IsNullOrEmpty(s)) return false;

            if (s.Substring(0, 1).ToUpper() == firstChar.ToString())
                return true;
            else
                return false;
        }
    }
}
