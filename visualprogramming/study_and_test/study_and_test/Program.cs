using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_and_test
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            int start = 2;
            int end = 5;
            while (end<=9) {
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = start; j <= end; j++)
                    {
                        Console.Write("{0,1} * {1,1} = {2,2}  ", j, i, i * j);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
                start = end + 1;
                end = end + 4;
            }

        }
        */
        static void Main(string[] args)
        {
            int result;
            int sum1=1;
            int count=1;

            while (count <= 10)
            {
                result = sum1 * count;
                
                count++;
            }

            Console.WriteLine(sum);

        }
    }
}
