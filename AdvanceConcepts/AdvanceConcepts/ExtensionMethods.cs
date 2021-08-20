using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts
{
   static class ExtensionMethods
    {
        public static bool IsGreaterThan(this int i,int val)
        {
            return i > val;
        }

        static void Main()
        {
            int num = 10;
            bool result = num.IsGreaterThan(5);
            Console.WriteLine(result?"Number1 is Greater than Number2": "Number2 is Greater than Number1");
            Console.ReadLine();
        }    
    }
}
