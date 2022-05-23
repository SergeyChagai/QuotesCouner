using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ReadKey();

                var enter = Console.ReadLine();

                var result = Parser.CheckQuotesEquality(enter);
                Console.WriteLine(result);

                Console.ReadKey();
            }
        }
    }
}
