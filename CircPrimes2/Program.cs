using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircPrimes
{
    class Program
    {

        static void Main(string[] args)
        {
            int limit = 1000000;
            List<int> Primes = new List<int>();
            Primes = Prime.findPrimes(limit);
            Primes = Prime.findCircularPrimes(Primes);
            Console.WriteLine("The number of ciruclar primes below {0} is {1}", limit, Primes.Count);

            Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < Primes.Count; i++)
            {
                Console.WriteLine("{0}", Primes[i]);
            }
            
            Console.ReadLine();
        }
    }
}
