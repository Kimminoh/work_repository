using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class sum_and_prod
        {
            private int sum_result;
            private int prod_result;

            private int[] num = new int[10];

            public sum_and_prod()
            {

            }

            public int Sum_result
            {
                get { return sum_result; }
                set { sum_result = value; }
            }

            public int Prod_result
            {
                get { return prod_result; }
                set { prod_result = value; }
            }


            public int this[int index]
            {

                get { return num[index]; }
                set
                {

                    num[index] = value;
                }

            }

            public void cal_sum(int size)
            {
                for (int i = 0; i <= size; i++)
                    Sum_result += num[i];

            }

            public void cal_prod(int size)
            {
                Prod_result = 1;//Prod_result가 기본값이 0으로 초기화 -> 1로 초기화해준다!
                for (int i = 0; i <= size - 1; i++) //값을 +1을 한 대신 , 범위를 -1을 해준다!
                    Prod_result *= (num[i] + 1);
            }



        }
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하시오 :");
            int op = int.Parse(Console.ReadLine());

            sum_and_prod myclass = new sum_and_prod();

            for (int i = 0; i <= op; i++)
            {
                myclass[i] = i;
            }

            myclass.cal_sum(op);
            myclass.cal_prod(op);
            Console.Write("합계: {0}     곱:{1} ",myclass.Sum_result,myclass.Prod_result);
            Console.WriteLine();

        }
    }
}


