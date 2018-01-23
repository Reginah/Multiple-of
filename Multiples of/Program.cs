using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;
            for (int i = 1;  i<1000; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("Yes");
                    total = total + i;
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
