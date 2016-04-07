using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int result = 0;
            int count = 0;

            if (sum == 0)
            {
                if (count == 0)
                    result = 0;
            }
                else result = 1;

            Console.WriteLine("Result: " + result);

            Console.ReadKey();

        }
    }
}
