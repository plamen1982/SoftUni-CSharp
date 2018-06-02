using System;

namespace _4.SieveOfEratoshtenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] prime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                prime[i] = true;
            }

            prime[0] = false;
            prime[1] = false;

            for (int j = 2; j * j <= n; j++)
            {
                if (prime[j] == true)
                {
                    for (int k = j * 2; k <= n; k += j)
                    {
                        prime[k] = false;
                    }
                }
            }

            for (int p = 0; p < prime.Length; p++)
            {
                if (prime[p] == true)
                {
                    Console.Write($"{p} ");
                }
            }
            
        }
    }
}
