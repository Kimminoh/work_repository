using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        class Min_Max
        {
            double[] num;
            double min, max;


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

            public double Max()
            {
                double max = -100;

                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] > max)
                        max = num[i];
                }

                return max;

            }

            public double Min()
            {
                double min = 100;

                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] < min)
                        min = num[i];
                }

                return min;

            }

        }

            public static void Main(string[] args)
            {
                Min_Max arr = new Min_Max();
                double min, max;
                
            Console.WriteLine("============");
                Console.WriteLine("0. 데이터 입력 (5개)");
                Console.WriteLine("1. 최소값");
                Console.WriteLine("2. 최대값");
                Console.WriteLine("3. 프로그램 종료");

                
                while (true)
                {
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        case "0":
                            arr.input();
                            break;
                        case "1":
                            min=arr.Min();
                            break;
                        case "2":
                            max = arr.Max();
                            break;
                        case "3":
                            Console.WriteLine("프로그램을 종료합니다.");
                            break;
                        default:
                            Console.WriteLine("1~3까지 메뉴를 선택하세요\n");
                            break;
                    }
                }
            }
        }
    }


/* 예제4.2
int instance_var;
static int staticinstance_var;
public static void Main(string[] args)
{
    Program obj = new Program();
    obj.instance_var = 10;
    //Program.instance_var = 20;  에러! 클래스 이름으로 할 수 없음
    Program.staticinstance_var = 20;
    //obj.staticinstance_var = 10; 클래스 이름으로 할 수 없음. 객체는 instance_var로!
    Console.WriteLine("instance_var={0}, staticinstance_var={1}",obj.instance_var,Program.staticinstance_var);
}
*/
/*
class CallbyValue
{
    static void Swap(int x,int y)//전역함수로 사용하기 위해 static 선언
    {
        int temp;
        temp= x;
        x = y;
        y = temp ;

        Console.WriteLine("Swap: x={0}, y={1}", x, y);


    }
    public static void Main(string[] args)
    {
        int x = 1, y = 2;
        Console.WriteLine("Before: x={0}, y={1}", x, y);
        Swap(x, y);
        Console.WriteLine("After: x={0}, y={1}", x, y);

    }
}

}
}
*/



















/*
static void Main(string[] args)
{

}
*/
/* 기초 실습의 기본 클래스
class Std
{
    string name = "김민오";
    string num = "2019";
    string major = "컴퓨터공학과";


    public Std()
    {
        Console.WriteLine("학생입니다.");
    }

    public void Output()
    {
        Console.WriteLine(major + "입니다.");
        Console.WriteLine(num + "입니다.");
        Console.WriteLine(name + "입니다.");
    }

}
*/

// 클래스 객체 , 필드 기초 실습   
/*
class Fraction
{
    public int num;//이게 정답은 아님!
    int denum;

    public Fraction(int num,int denum)
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
*/



