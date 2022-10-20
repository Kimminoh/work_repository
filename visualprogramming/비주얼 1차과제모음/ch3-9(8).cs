using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 2, end = 5;//시작을 2단으로 시작, 단위는 4개의 단부터 끝 (끝단 -1 만큼!)

            while (end <= 10)//목표 단수가 9단이므로(만약 더많은 결과를 출력하고싶을 시 해당 부분의 숫자만을 조절하면된다.)
            {

                for (int i = 1; i <= 9; i++)//2x1, 3x1.. 처럼 열 단위로 출력 
                {
                    for (int j = start; j <= end; j++)// 시작 단을 start변수, 종료단을 end변수로 둠으로써 변수로 컨트롤하게끔 만듬
                    {
                        Console.Write("{0,2} * {1,2}  =  {2,2}, ", j, i, i * j);//포맷팅 기술 : { 0, 2 } 는 2칸 공백 만드는 기술
                    }
                    Console.WriteLine("");//열단위로 끊어내는 개행(이것을 통해 세로 행 출력이 가능)
                }
                Console.WriteLine("");// 해당 부분도 마찬가지
                //해당 부분을 통해 4단씩 출력 가능(while문으로만 통제)
                start = end + 1;
                end = end + 4;

            }

        }


    }
}