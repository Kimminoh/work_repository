using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
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

        /* (8)번 문제
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
        */
        static void Main(string[] args)
        {
            int thing = 974;//물건가격
            int money = thing;//해당 물건 가격을 돈 계산 프로그램 알고리즘에 넣기위해 money라는 변수에 대입
            
            //money 입력받기 
            
            int ex_500 = money / 500;//최대금액에서 500원짜리 갯수
            money = money % 500;//나머지는 남은 금액으로 이월

            int ex_100 = money / 100
            money = money % 100;
            int ex_50 = money / 50;
            money = money % 50;
            int ex_10 = money / 10;
            money = money % 10;
            int ex_5 = money / 5;
            money = money % 5;
            int ex_1 = money;



            Console.WriteLine("물건 가격 : {0}원", thing);
            Console.WriteLine("===최적의 거스름돈===");
            Console.WriteLine("500원 : {0}개, 100원 : {1}개, 50원 : {2}개, 10원 :{3}, 5원 : {4}, 1원 :{5}", ex_500,ex_100,ex_50,ex_10,ex_5,ex_1) ;

        }
    }
}
