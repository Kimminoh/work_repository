using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
         //(7)-1번문제
         /*
        static void Main(string[] args)
        {
            int a = 1, b = 1, sum = 0;
           
            for (int i = 1; i <= 10; i++)
            {
                a = a * b;//제일 처음 값을 만들기 위해 a=1, b=1을 채택
                b++;//b를 증가 후 루프 종료 
                sum = sum + a;//해당 증가분인 a는 sum에 더해짐 (괄호 느낌)
            }
            // factorial 덧셈 문제! 재귀로도 처리가 가능할지도?
            Console.WriteLine("결과값:{0}", sum);
        }
        */

        // (7)-2번 문제
        static void Main(string[] args)
        {
            double mol = 1, demol = 1, sum = 0;//mol은 분자 , demol은 분모이다.

            Console.Write("S = ");//결과값 출력 형태 : (S=)
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)//해당 분수에서는 1에서부터 시작하므로 짝수번째 순서일때 실제연산은 - 연산을 하고 표기는 +로 한다.
                {
                    Console.Write("({0}/{1}) +",mol,demol);//후위 표기는 + 표기
                    sum = sum - (mol / demol);//전위 실제 계산은 - 연산
                }

                else if (i % 2 == 1)// 홀수번째 순서 일 때, 실제 연산은 + 연산을 하고 표기는 - 로 한다.
                {
                    Console.Write("({0}/{1}) -", mol, demol);//- 표기
                    sum = sum + (mol / demol);//+ 연산
                }

                demol++;//분수가 1씩 증가하므로 루프가 종료될때마다 ++ 연산을 해준다.
            }
            Console.WriteLine("");
            Console.WriteLine("결과값:{0}", sum);//최종 결과 값 표기

        }
        
        

    }
}