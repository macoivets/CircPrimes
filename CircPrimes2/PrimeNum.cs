using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircPrimes
{
    class PrimeNum
    {
        public static List<int> findPrimes(int uplim)
        {
            List<int> res = new List<int>();
            for (int i = 2; i < uplim; i++)
            {
                if (i % 2 == 0 && i != 2)
                {

                }
                else
                {
                    if (isPrime(i))
                    {
                        res.Add(i);
                    }
                }
            }
            return res;
        }

        public static bool isPrime(double i)
        {
            for (int j = 3; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0 && i != j)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> findCircularPrimes(List<int> lstPrimes)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < lstPrimes.Count; i++)
            {
                double num = lstPrimes[i];
                if (lstPrimes[i] < 10)
                {
                    res.Add(lstPrimes[i]);
                }
                else if (lstPrimes[i].ToString().Contains('2') || lstPrimes[i].ToString().Contains('4') || lstPrimes[i].ToString().Contains('6') || lstPrimes[i].ToString().Contains('8') || lstPrimes[i].ToString().Contains('0') || lstPrimes[i].ToString().Contains('5'))
                {

                }
                else
                {
                    bool isCirCulPrime = true;
                    for (int j = 0; j < lstPrimes[i].ToString().Length; j++)
                    {
                        num = Rotate(num, lstPrimes[i].ToString().Length);
                        if (!isPrime(num))
                        {
                            isCirCulPrime = false;
                        }
                    }
                    if (isCirCulPrime)
                    {
                        res.Add(lstPrimes[i]);
                    }
                }
            }
            return res;
        }

        public static double Rotate(double iNumber, int noDigits)
        {
            double givenNo = iNumber;
            int reminder = (int)iNumber % 10;
            int quotient = (int)iNumber / 10;
            return ((reminder * Math.Pow(10, noDigits - 1)) + quotient);
        }
    }
}
