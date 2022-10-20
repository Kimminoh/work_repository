using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; ) { 
            //문자로된 점수의 더블쿼터가 있으므로 string이용
                string point;
                Console.Write("점수 입력 : ");
                point = Console.ReadLine();

                if ("end" == point) break;

                switch (point)
                {
                    case "a":
                    case "A":
                        Console.WriteLine("90점 이상");
                        break;
                    case "B":
                    case "b":
                        Console.WriteLine("80점~89점 사이");
                        break;

                    default:
                        Console.WriteLine("잘못된 입력");

                        break;
                }
            }


        }
    }
}
