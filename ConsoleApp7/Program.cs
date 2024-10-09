using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class Program
    {
        static void Main(string[] args)
        {
          
            int K1 = 5;
            int K2 = 10;
            int[] A = { 3, 6, 9, 12, 15 };
            int[] B = { 4, 7, 2, 11, 8 };

            
            int[] result = A.Where(x => x > K1).Concat(B.Where(x => x < K2)).ToArray();

            
            Array.Sort(result);

            
            Console.WriteLine("Result:");
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        int[] sequence = { -3, 12, 45, 27, 9, 18, 52, 36, 5, 2, 7 };

        
        int[] lastDigits = sequence.Where(x => x > 0).Select(x => x % 10).ToArray();

        
        int[] uniqueLastDigits = lastDigits.Distinct().ToArray();

        
        Console.WriteLine("Result:");
        foreach (int digit in uniqueLastDigits)
        {
            Console.WriteLine(digit);
        }
    }
}