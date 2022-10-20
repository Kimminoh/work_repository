using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        /* (7)-1번문제
        static void Main(string[] args)
        {
            int a = 1, b = 1, sum = 0;
           
            for (int i = 1; i <= 10; i++)
            {
                a = a * b;
                b++;
                sum = sum + a;
            }
            // factorial 덧셈 문제! 재귀로도 처리가 가능할지도?
            Console.WriteLine("결과값:{0}", sum);
        }
        */
        
        /* (7)-2번 문제
        static void Main(string[] args)
        {
            double mol = 1, demol = 1, sum = 0;

            Console.Write("S = ");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("({0}/{1}) +",mol,demol);
                    sum = sum - (mol / demol);
                }

                else if (i % 2 == 1)
                {
                    Console.Write("({0}/{1}) -", mol, demol);
                    sum = sum + (mol / demol);
                }

                demol++;
            }
            Console.WriteLine("");
            Console.WriteLine("결과값:{0}", sum);

        }
        */

        static void Main(string[] args)
        {
            int start = 2, end = 5;

            while (end<=10)
            {
                
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = start; j <= end; j++)
                    {
                        Console.Write("{0,2} * {1,2}  =  {2,2}, ", j, i, i * j);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                start = end + 1;
                end = end + 4;

            }
            
        }
    }
}
