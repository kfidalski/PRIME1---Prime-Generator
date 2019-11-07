using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME1___Prime_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            // number of test
            int n = Convert.ToInt32(Console.ReadLine());
            string input = "";
            int a, b = 0;

            int[] tabA = new int[n];
            int[] tabB = new int[n];

            if (n <= 10)
            {
                for (int i = 0; i < n; i++)
                {
                    input = Console.ReadLine();
                    string[] data = input.Split(' ');
                    a = Convert.ToInt32(data[0]);
                    b = Convert.ToInt32(data[1]);

                    if(b >= 1 && b<= 1000000000 && (a-b) <= 1000000000) { 

                    tabA[i] = a;
                    tabB[i] = b;
                        }
                }

                for (int i = 0; i < n; i++)
                {
                    GetPrime(tabA[i], tabB[i]);
                    Console.WriteLine("");
                }
            }


            Console.ReadKey();
        }

        public static void GetPrime(int n , int m)
        {
            int[] numbers = new int[m+1];
            int[] primes = new int[m+1];
            int counter = 0;

            for (int i = n; i <= m; i++)
            {
                numbers[i] = i;
            }

            for (int i = n; i <= m; i++)
            {
                //   Console.WriteLine($" {numbers[i]}");
               if(CheckIfPrime(numbers[i]))
                {
                    primes[counter] = i;
                    counter++;
                }
               
            }
            for(int i = 0; i < counter; i++)
            {
                Console.WriteLine($"{primes[i]}");
            }

        }

        public static bool CheckIfPrime(int liczba)
        {
            int t = liczba;
            int count = 0;

            for(int i = 1; i <= t; i++)
            {
                if((liczba % i) == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
             //   Console.WriteLine($"{liczba} jest liczbą pierwszą , dzielniki {count}");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

