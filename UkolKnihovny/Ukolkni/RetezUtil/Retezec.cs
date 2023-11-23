namespace RetezUtil
{
    public class Retezec
    {

        /// <summary>
        /// Smaže číslice ve    řetězci
        /// </summary>
        /// <param name="vstup">Řetězec string</param>
        static public string Smaz(string vstup)
        {
            
            foreach (char c in vstup)
            {
                if (c >= '0' && c <= '9') vstup=vstup.Replace(c,' ');
            }

            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  ", " ");
            }
            return vstup;
        }

        /// <summary>
        /// Vypíše řetězec
        /// </summary>
        /// <param name="vstup">Řetězec</param>
        /// <returns>Vrací Upravený řetězec </returns>
        static public string Zobraz(string vstup)
        {
            return vstup;
        }
    }
}