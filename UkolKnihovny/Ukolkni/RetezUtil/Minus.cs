using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetezUtil
{
    public class Minus
    {
        /// <summary>
        /// Vymazani (odecteni) stringu
        /// </summary>
        string text;
        public Minus(string text)
        {
            this.text = text;
        }

        static public string operator -(Minus x, Minus y)
        {
            return x.text.Replace(y.text, "");
        }
    }
}
