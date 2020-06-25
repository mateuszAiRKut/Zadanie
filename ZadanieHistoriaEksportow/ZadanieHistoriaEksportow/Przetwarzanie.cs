using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieHistoriaEksportow
{
    public static class Przetwarzanie
    {
        public static void ZamianaNaDateGodzine(out string data, out string godzina, string dane)
        {
            string[] tablica = dane.Split(' ');

            if(tablica.Length == 2)
            {
                data = zamianaFormatData(tablica[0]);
                godzina = zamianaFormatGodzina(tablica[1]);
            }
            else
                data = godzina = "";
        }

        private static string zamianaFormatData(string dane)
        {
            return dane.Replace('/', '-');
        }

        private static string zamianaDormatDataWersja2(string dane)
        {
            string[] tablica = dane.Split('/');
            return new StringBuilder(tablica[2]).Append('-').Append(tablica[0]).Append('-').Append(tablica[1]).ToString();
        }

        private static string zamianaFormatGodzina(string dane)
        {
            int i = dane.LastIndexOf(':');

            if (i != -1)
                return dane.Substring(0, i);
            return dane;
        }
    }
}
