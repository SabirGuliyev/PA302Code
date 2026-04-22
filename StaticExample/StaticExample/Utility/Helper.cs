using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample.Utility
{
    internal static class Helper
    {
        public static string OffMail { get; set; } = "code@edu.az";
        public static string Capitalize(string test)
        {  //Sabir  

            return test.Substring(0, 1).ToUpper() + test.Substring(1).ToLower();
        }
    }
}
