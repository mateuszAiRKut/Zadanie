using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ZadanieHistoriaEksportow
{
    public static class Polaczenie
    {
        public static string PolaczenieWartosc(string nazwa)
        {
            return ConfigurationManager.ConnectionStrings[nazwa].ConnectionString;
        }
    }
}
