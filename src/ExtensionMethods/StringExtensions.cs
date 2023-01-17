using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Revert(this string valor) =>
            new string(valor.ToCharArray().Reverse.ToCharArray());
    }
}