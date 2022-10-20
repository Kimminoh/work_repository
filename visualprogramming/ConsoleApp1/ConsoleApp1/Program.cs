using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /*실습 예제2-2
static void Main(string[] args)
{
    int i = 255, h = 0xff;
    long l = 0xffL;
    Console.WriteLine("i="+i+", "+ "h="+h);
    if (h ==l)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");//Write는 줄바꿈 없으며 , Writeline은 자동으로 줄바꿈
}
*/

        /* 실습 예제 안전하지않는 코드
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("Before:x =" + x + " y= " + y);
            unsafe
            {
                Swap(&x, &y);
            }
            Console.WriteLine("After:x=" + x + " y=" + y);
        }
        unsafe public static void Swap(int* px, int* py)
        {
            int tmp = *px;
            *px = *py;
            *py = tmp;

        }
        */

        /*실습 예제 2-10 
        static void Main(string[] args)
        {
            int[] ia = new int[3];
            int[] ib = { 1, 2, 3 };
            int i;

            for (i = 0; i < ia.Length; i++)
                ia[i] = ib[i];
            for(i=0; i<ia.Length; i++)
                Console.Write(ia[i]+" ");//해당 문구를 WriteLine으로 할 시, 강제 개행 된다.
            Console.WriteLine(); // 이 문구를 삽입하지않으면, 끝문구가 이어서 출력
            
        }
        */
        /* 예제2.11: 이차원 배열 
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            int i, j;
            for (i = 0; i < array.Length; i++)
                array[i] = new int[i + 3];// 배열을 생성하되, 각 행마다 +3 씩!
            for (i = 0; i < array.Length; i++)
                for (j = 0; j < array[i].Length; j++)
                    array[i][j] = i * array[i].Length + j;// 행의 번호 x 해당행의 길이 + 현재 열의 번호

            for(i=0; i < array.Length; i++)
            {
                for (j = 0; j < array[i].Length; j++)
                    Console.Write(" " + array[i][j]);
                Console.WriteLine();
            }
        }
        */
        /* 예제 3-21
        static void Main(string[] args)
        {
            int time, hour, minute, second;
            Console.Write("*** Enter an integral time : ");
            time = int.Parse(Console.ReadLine()); //읽어들이는 라인을 정수로 변환하여 Time 에 저장 !
            hour = time / 10000;
            minute = time / 100 % 100;
            second = time % 100;
            Console.WriteLine("*** Time is " + hour + ":" +
                minute + ":" + second);
        }
        */

        /*예제 2-21
        static void Main(string[] args)
        {
            int a, b, c;
            int m;
            Console.Write("Enter three numbers:");
            a = int.Parse(Console.ReadLine());
        // 여기서 본문 예제대로 -'0'을 하지않는 이유
        // -0의 의미 자체가 입력하는 값을 정수로 암시하고 해당 문자로 들어오는 정수를 정수로 만들기위함
        // int.Parse로 들어오는 입력값을 바로 정수로 만들어주므로!
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            m = (a > b) ? a : b;
            m = (m > c) ? m : c;
            Console.WriteLine("The Largest number =" + m);

        }
        */

        /*예제 2-29
        static void Main(string[] args)
        {
            int foo = 526;
            object bar = foo; // 박싱 , foo라는 데이터 값을 상자 안으로, bar라는 object변수로 foo 값을 참조
            // foo에 담긴 값을 박싱해서 bar라는 힙에 저장한 꼴
            Console.WriteLine(bar);
            try
            {
                double d = (short)bar; //언박싱, bar에 담긴값을 언박싱하여 스택에 있는 d에 저장한 꼴
                //해당 문구로 인해 오류가 발생하므로, 같은 자료형인 int로 언박싱이 이루어져야한다. 
                //double d = (int)bar;
                Console.WriteLine(d);

            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e + "Error");

            }

        }
        */

        //수업활동일지 내용 
        static void Main(string[] args)
        {
            double value, value2;

            Console.WriteLine("1번째 값을입력하세요 :");
            value = double.Parse(Console.ReadLine());
            Console.WriteLine("2번째 값을입력하세요 :");
            value2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("{0:F2} + {1:F2} = {2:F2}", value, value2, value + value2);
            Console.WriteLine("{0:F2} * {1:F2} = {2:F2}", value, value2, value * value2);
            Console.WriteLine("{0:F2} - {1:F2} = {2:F2}", value, value2, value - value2);
            Console.WriteLine("{0:F2} / {1:F2} = {2:F2}", value, value2, value / value2);

        }
    }
}
