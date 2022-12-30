using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //project 2
            //write a c# program to find the perfect numbers from n1 to n2
            //the input: n1 and n2
            //the output: the list of perfect numbers from n1 to n2
            //example: for the input numbers: n1 = 5 and n2 =30, the output should be //6 //28

            int n1, n2;

            Console.WriteLine("enter n1");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter n2");
            n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
                {
                    if (isperfect(i)) ;
                }
            }
        }
        static bool isperfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }

            }
            return sum == n;
        }
    }
}
