using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /*
    internal class Program
    {

         예제 4-4
        class CallbyValue
        {
            static void Swap(int x, int y)//전역함수로 사용하기 위해 static 선언
            {
                int temp;
                temp = x;
                x = y;
                y = temp;

                Console.WriteLine("Swap: x={0}, y={1}", x, y);


            }
        */

        /*예제 4-5
        class CallbyreferenceApp 
        {
            static void Swap(ref int x,ref int y)
            {
                int temp;
                temp = x;
                x = y;
                y = temp;
                Console.WriteLine("Swap: x={0}, y={1}", x, y);
            }
        
        */
        /*예제 4-6
        class Integer
        {
            public int i;
            public Integer(int i)
            {
                this.i = i;
            }
        }

        class Callbyobjectreference { 
            static void Swap(Integer x,Integer y)
            {
                int temp = x.i;
                x.i = y.i;
                y.i = temp;
                Console.WriteLine("Swap: x={0}, y={1}", x.i, y.i);
            }
            public static void Main(string[] args)
                {
                Integer x = new Integer(1);
                Integer y = new Integer(2);
                Console.WriteLine("Before: x={0}, y={1}", x.i, y.i);
                Swap(x, y);
                Console.WriteLine("After: x={0}, y={1}", x.i, y.i);

            }
        }
    }
}
        */

        /*// 예제 4-1
        {


            class Fraction
            {
                public int num;//이게 정답은 아님!
                int denum;

                public Fraction(int num, int denum)
                {
                    this.num = num;
                    this.denum = denum;
                }

                public Fraction()
                {
                    Console.WriteLine("김민오");
                }

                public void PrintingFraction()
                {
                    Console.WriteLine(num + "/" + denum);

                }
            }

            internal class Program
            {
                static void Main(string[] args)
                {
                    Fraction f = new Fraction(3, 1);
                    f.num = 10;
                    Fraction f1 = new Fraction();
                    f.PrintingFraction();

                }


            }
        }
        */
























        // 실습문제 : 최대,최소 클래스로 ! 
        class Min_Max
        {
            double[] num;
            double min = 100, max = -100;


            public Min_Max()
            {
                num = new double[5] { 0, 0, 0, 0, 0 };
            }//기본 생성자는 double에 0으로 기본으로 초기화

            public void input()
            {
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write("{0}번째 값 입력:", i + 1);
                    num[i] = double.Parse(Console.ReadLine());
                }
            }
            /*

            public double Min()
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] < min)
                        min = num[i];
                }

                return min;


            }

            public double Max()
            {


                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] > max)
                        max = num[i];
                }

                return max;


            }
            */

            public void max_and_min()
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] > max)
                        max = num[i];
                }

                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] < min)
                        min = num[i];
                }
            }

            public double get_min() { return min; }
            public double get_max() { return max; }

        }
        internal class Program
        {

            static void Main(string[] args)
            {
                Min_Max arr = new Min_Max();

                double min, max;

                Console.WriteLine("========================");
                Console.WriteLine("0. 데이터 입력 (5개)");
                Console.WriteLine("1. 최소값");
                Console.WriteLine("2. 최대값");
                Console.WriteLine("3. 프로그램 종료");
                Console.WriteLine("========================");

                while (true)
                {
                    Console.Write("메뉴 선택 >>");
                    int select = int.Parse(Console.ReadLine());

                    if (select == 0)
                    {
                        arr.input();
                        arr.max_and_min();
                    }

                    else if (select == 1)
                    {
                        //min = arr.Min();
                        min = arr.get_min();
                        Console.WriteLine("최소값:{0}\n", min);
                    }

                    else if (select == 2)
                    {
                        //max = arr.Max();
                        max = arr.get_max();
                        Console.WriteLine("최대값:{0}\n", max);
                        //실수한 부분 : 해당 출력 부분을 적지않고 실행해서 잘못을 찾음 
                        // 출력부분이없으면 함수를 사용하지않았다고 뜸
                    }

                    else if (select == 3)
                    {
                        Console.WriteLine("프로그램을 종료합니다.\n");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("1~3까지 메뉴를 선택하세요\n");
                    }

                }







            }
        }
    }

