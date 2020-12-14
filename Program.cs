using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Possible_combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = 26;//number of letters
            var m = 4;//max number of digits
            for (int j = 1; j < m + 1; j++)
                for (int i = 0; i < Math.Pow(p, j); i++)
                {
                    for (int k = 1; k < j + 1; k++) //Console.WriteLine();
                        Console.Write((char)((i / Math.Pow(p, k - 1) % p) + 'a'));
                   
                    //Console.Write((char)((i % 2 )+'a'));


                    Console.Write(" | ");
                    for (int k = j; k > 0; k--) Console.Write(Math.Pow(p, k - 1) + " "); Console.Write(" | ");

                    Console.Write(i % p + "\t");
                    Console.Write(i / p + "\t");

                    Console.Write(" | ");for (int k = 1; k < j + 1; k++) Console.Write((int)((i / Math.Pow(p, k - 1) % p))+" ");


                    Console.WriteLine();


                }

            
            Console.ReadKey();
        }
    }
}
