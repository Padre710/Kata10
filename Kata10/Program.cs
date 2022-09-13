using System;
using System.Collections.Generic;
using System.Linq;

//    Complete the solution so that it splits the string into pairs of two characters.
//   If the string contains an odd number of characters then it should replace the
//    missing second character of the final pair with an underscore('_').

//Examples:

//    *'abc' =>  ['ab', 'c_']
//*'abcdef' => ['ab', 'cd', 'ef']

namespace Kata10
{
    public class SplitString
    {
        
        public static string[] Solution(string str)
        {
             string[] array = Array.Empty<string>();
            List<string> list = new List <string>();
            string x = string.Empty;
            if (str.Length% 2 != 0)
            {
                str = str + "_";
            }

            Console.WriteLine(str);

            for (int i =0; i < str.Length; i++)
            {
                if (x.Length == 2)
                {
                    list.Add(x);
                    x = string.Empty;
                    x = x + str[i];
                }
                else
                {
                    x = x + str[i];
                }
            }
                  list.Add(x);

            array = list.ToArray();
             foreach(var e in array)
            {
                Console.WriteLine(e);
            }




            return array ;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine( SplitString.Solution("abc"));
            Console.WriteLine(SplitString.Solution("abcdefghijklmnop"));

        }
    }
}
