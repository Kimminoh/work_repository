using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /* 피라미드 연습 
        static void Main(string[] args)
        {
            int spacing = 4;
            for (int i = 1; i <= 9; i ++)
            {
                for (int s = 1; s <= 9-i; s++)
                    Console.Write(" ");
                for (int j = 1; j <= 2*i-1; j++)
                    Console.Write("*");
                Console.WriteLine(" ");

            }
            

            for(int i = 7; i >= 0; i --)
            {
                for(int s = 1; s <= 7-i; s++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" "); 
            }
        }
        */
        static void trans(int[][] mat, int row, int col)
        {

        }


        static void Main(string[] args)
        {
            int row = 2;
            int col = 3;
            int temp = 1;
            
            // 객체를 지정하는 방법(2차원 배열)
            int[][] mat = new int[2][];
            for (int i = 0; i < row; i++)
                mat[i] = new int[col];
            
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    mat[i][j] = temp;
                    temp++;

                }
                
                }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(mat[i][j] +" ");
                }
                Console.WriteLine(" ");
            }


        }

            
    /* for문 연습 */
    /*
    static void Main(string[] args)//for문 반복문 익히기
    {
        for (int i = 1; i <= 6; i++)
        {
            for(int j = 0; j < i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine(" ");
        }

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        for (int i = 5; i >= 0; i--) //맨 앞줄에서 세로로 떨어지는 것을 보고 식을 파악
        {
            for(int j = i; j >=0; j--)//i는 행, j은 열을 담당 -> j는 5부터 i값 까지 도달 (행 마다!)
            {
                Console.Write(j);
            }
            Console.WriteLine(" ");
        }

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        for(int i = 0; i <= 5; i++)
        {
            for(int j = i; j <= 5; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        for(int i = 5; i >= 0;i--)//원리-> 바깥을 제어라고 늘 생각하여라 
            // 012345 가 행마다 출력되어야하는데 거기서 후방을 뺼 생각을 한다면
            // 제어를 밖에 두고 뺄 것을 정하여라 그리고 안의 j는 i를 따라가게 하면된다. j와 i의 콜라보
        {
            for(int j = 0; j <=i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine(" ");
        }

    }
    */

    // for문 실습문제 

    /*
    static void Main(string[] args)
    {
        int[] num_storage = new int[8];

        Console.WriteLine("==정수 8개를 입력하시오==");

        for (int i = 0; i < num_storage.Length; i++)
        {
            Console.WriteLine("{0}번째 숫자를 입력하시오", i + 1);
            num_storage[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("==입력받은 숫자를 역순으로 출력==");
        for (int i = num_storage.Length-1;i>=0;i--)
        {
            Console.Write(num_storage[i] + " ");

        }

        Console.WriteLine(" ");

    }
    */
}
}
