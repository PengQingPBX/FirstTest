using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write( string.IsNullOrWhiteSpace("value"));
            Console.Write( string.IsNullOrWhiteSpace(""));
            Console.Write( string.IsNullOrWhiteSpace("  "));
            //query_Rtn + string.Empty
            string query_Rtn = null;
            Console.Write((query_Rtn+"").Length+"\n\r");
            string url = string.Format("ui", 3, 2);
            Console.Write(url);
        }
    }
}
