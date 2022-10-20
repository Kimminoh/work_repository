using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /* 예제 3-15 foreach 문 
        static void Main(string[] args)
        {
            char[] name_alphabet = { 'M', 'I', 'N', 'o', 'h', '!' };
            foreach (char c in name_alphabet)
            {
                //Console.WriteLine(c);
                Console.Write(c);
                
            }
            Console.WriteLine();
        }
        */
        /* 예제 3-18 함수 
        static void Main(string[] args)
        {
            int n, s, i;

            for (; ; )
            {
                Console.Write("Enter a number : ");
                n = Int32.Parse(Console.ReadLine());//왜 (int)s는 안될까?
                if (n == 0) break;
                else if (n < 0) continue;
                for (s = 0, i = 1; i <= n; ++i)
                {
                    s = sum(s, i);
                }
                Console.WriteLine("n={0}, sum={1}", n, s);


            }
            Console.WriteLine("End of Main");

        }
        static int sum(int s, int i)
        {
            return s + i;
        }

        */

        /* 예제 3-19
        static void Main(string[] args)
        {
            int i, max = int.MaxValue;
            try
            {
                Console.WriteLine("Start");
                i = max + 1;//오버플로우 발생
                Console.WriteLine("Middle_ overflow");

                unchecked
                {
                    i = max + 1;
                }
                Console.WriteLine("unchecked_overflow");
                checked
                {
                    i = max + 1;
                }
                Console.WriteLine("checked_overflow");

            }catch(OverflowException e)
            {
                Console.WriteLine("caught an Overflow");

            }
        }
        */

        // 예제 3-23 문자열 포맷팅
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("1) {0,-5},{1,5},{2,5}", 1.2, 1.2, 123.45);
            double d = Math.PI;

            Console.WriteLine("2) {0}", d);
            Console.WriteLine("3) {0:c}", d);
            Console.WriteLine("4) {0:E}", d);
            Console.WriteLine("5) {0:f}",d);
            Console.WriteLine("6) {0:G}", d);
            Console.WriteLine("7) {0:P}", d);
            Console.WriteLine("8) {0:R}", d);
            Console.WriteLine("9) {0,5:X}", 255);
        }
       */

        //-----------------------------------------------
        /* 수업활동일지 1번 문제 
        static void Main(string[] args)
        {
            string op="";// 평점 알파벳 a,b,c,d,f
            while (true)
            {
                Console.Write("점수를 입력하시오 :");
                op =Console.ReadLine();
                if ((op == "a") || (op == "A"))
                {
                    Console.WriteLine("90점 이상입니다.");
                }
                else if ((op == "b") || (op == "B"))
                {
                    Console.WriteLine("80점에서 89점 사이입니다.");
                }
                else if ((op == "c") || (op == "C"))
                {
                    Console.WriteLine("70에서 79점 이상입니다.");
                }
                else if ((op == "d") || (op == "D"))
                {
                    Console.WriteLine("60점 에서 69점이상입니다.");
                }
                else if ((op == "f") || (op == "F"))
                {
                    Console.WriteLine("60점 이하입니다.");
                }
                else if ((op == "end") || (op == "END"))
                    break;

            }
                
        }
        */

        //-----------------------------------------------
        //수업활동일지 2번째 문제, -->입력, 최대,최소도 함수로 만들기
        /*
        static void Main(string[] args)
        {
            int[] age_main = new int[5];
            int max_number = 0;
            int min_number = 0;

            Console.WriteLine("==5명 학생의 나이 입력");


            input(age_main);
            Console.WriteLine();
            Console.WriteLine();
            

            Console.WriteLine("==나이 그래프 출력");
            output(age_main); //참조 개념으로 접근!
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("==최대 나이와 최소 나이 출력");
            //최대나이 함수 for
            for (int i = 0; i < 5; i++)
                max_number = Max(age_main);

            for (int i = 0; i < 5; i++)
                min_number = Min(age_main);

            Console.WriteLine("최대나이: {0}", max_number);

            Console.WriteLine("최소나이: {0}", min_number);
        }

        static void input(int[] age) //나이 입력 함수
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}번째 학생 :", i + 1);
                age[i] = int.Parse(Console.ReadLine());
            }
        }

        static void output(int[] age)// 그래프 출력 함수
        {
            for (int i = 0; i < 5; i++)
            {
                int graph = age[i]; //그래프에 나이 수를 저장
                Console.Write("{0}번", i + 1);
                for (int j = 1; j <= graph; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }


        static int Max(int[] age)
        {
            int max = -100;
            for(int i = 0; i < age.Length; i++)
            {
                if (age[i] > max)
                    max = age[i];
            }

            return max;

        }

        static int Min(int[] age)
        {
            int min = 100000;
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] < min)
                    min = age[i];
            }

            return min;

        }

        //함수 4개로 분리!
        */

        //-----------------------------------------------
        //수업활동일지 3번째문제 
        /*
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = i; j < 6; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        */
        //-----------------------------------------------

        // 수업활동일지 4번째 문제 
        static void Main(string[] args)
        {
            int row = 2, col = 3;
            int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 } };
            int i, j;
            Console.WriteLine("==={0} by {1} transpose Mat===", row, col); //col과 row만 바꾼것
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            transpose(mat, row, col);


        }

        static void transpose(int[,] mat, int row, int col)
        {
            //transpose에는 row와 col을받아 그대로 바꿔 출력하는 역할(복사 x)

            int i, j;
            Console.WriteLine("==={0} by {1} transpose Mat===", col, row); //col과 row만 바꾼것
            for (i = 0; i < col; i++)
            {
                for (j = 0; j < row; j++)
                {
                    Console.Write(mat[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
        

        
    }
}
