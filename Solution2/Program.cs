using System;
using System.Collections;
using System.Linq;

namespace Solution2
{
    class Program
    { 
        public static void Main() 
        {       
            string text = "this, is, a, sentence";
            
            Console.WriteLine(string.Join(",", text.Split(", ").Reverse())); 
        }
    }
}

