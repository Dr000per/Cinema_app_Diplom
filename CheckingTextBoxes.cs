using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cinema_app_Diplom
{
    public class CheckingTextBoxes
    {
        public Boolean CyrillicCheck(char ch)
        {
            if (Regex.IsMatch(ch.ToString(), @"\p{IsCyrillic}") || ch == '\b')
            {
                return true;
            }

            return false;
        }

        public Boolean NumCheck(char ch)
        {
            if (char.IsNumber(ch) || ch == '\b')
            {
                return true;
            }

            return false;
        }

        public Boolean LengthCheck(string str, int i)
        {
            if(str.Length < i)
            {
                return false;
            }

            return true;
        }

        public Boolean EmailCheck(char ch)
        {
            if ((ch < 'A' || ch > 'z') && ch != '\b' && ch != '.' && !NumCheck(ch))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
