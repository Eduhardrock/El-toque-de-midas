using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Constantes
{
    public static class RegexConstants
    {
        public static string CARACTERES_NO_ALFANUMERICOS = @"[^a-zA-Z0-9]";
        public static string CARACTERES_NO_NUMERICOS = @"\D+";
    }
}
