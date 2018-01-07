using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPISP_V21
{
    class String
    {
        public char[] str;

        public String(char[] str)
        {
            this.str = str;
        }

        public String(string str)
        {
            this.str = str.ToCharArray();
        }

        public String(String str)
        {
            this.str = str.str;
        }

        public String() { }

        public string toString()
        {
            string newStr = "";
            foreach (char c in str)
            {
                newStr += c;
            }
            return newStr;
        }

        /// <summary>
        /// клонирование объекта
        /// </summary>
        /// <returns></returns>
        public String Clone()
        {
            return new String(str);
        }

        /// <summary>
        /// функция сравнения двух строк
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static bool EqualsValue(String left, String right)
        {
            if (left.str.Length == right.str.Length)
            {
                for (int i = 0; i < left.str.Length; i++)
                {
                    if (left.str[i] != right.str[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(String left, String right)
        {
            return EqualsValue(left, right);
        }

        public static bool operator !=(String left, String right)
        {
            return !EqualsValue(left, right);
        }

        public static bool operator >=(String left, String right)
        {
            return left.str.Length >= right.str.Length;
        }

        public static bool operator <=(String left, String right)
        {
            return left.str.Length <= right.str.Length;
        }
    }
}
