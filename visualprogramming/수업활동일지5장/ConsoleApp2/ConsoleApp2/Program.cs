using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 { 
class Fraction
{
    public int numerator;//분자
    public int denominator;//분모

    //(1) 한 개의 정수를 받아 초기화하는 생성자
    public Fraction(int numerator)
    {
        this.numerator = numerator;
    }
    //(2) 두 개의 정수를 받아 초기화 하는 생성자
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }
    //(3) 하나의 분수를 분자/분모 형태로 변환하는 ToString()메소드 
    override public string ToString()//public 과 override 위치는 바뀌어도 상관없다
    {
        return (numerator + "/" + denominator);
        //return base.ToString(); 원래 해당 문구로 인해 오리지널 출력값이다. 여기서 우리가 override시키는 것이다!
    }

    //(4) 최대공약수를 구하는 메소드 & 기약 분수로 만드는 메소드 
    //최대공약수-> 두 수 이상의 공통된 약수를 의미 
    // 최대공약수 = 두수 곱한 것 / 최소 공배수 이므로 최소 공배수 구하는 메소드 작성
    public int gcd(int num1, int num2)
    {

        int max = num1;// 큰수로 가정 max는 최대공약수를 담을 필드
        int min = num2;// 작은 수로 가정 min은 최소 공배수를 담을 필드
        int temp;       // 값을 계속 옮긴 임시 변수

        while (true)
        {
            //(1)
            temp = max % min;//큰 수에서 작은 수를 0이 될때까지 나누면 최소공배수
                             //이 때 0이라는 뜻은 딱 나누어 떨어졌다는 뜻!

            //(2)
            max = min; // 반복하기 위한 방법1

            //(pause-조건체크)
            if (temp == 0)//0이 되었을 때의 탈출 조건
            {
                break;
            }
            //(3) -> (1)로!
            min = temp;// 해당 부분 배치 이유 : 0이 딱 되었을 때 min에 들어가는 값은 최소공배수인데 min=temp 시, min은 반드시 0이 됨

        }
        // 탈출했을 때의 min= 최대공약수
        //max = (num1 * num2)/ min;

        return min;//바로 전 단계의 나머지를 가져옴!
    }

    //기약분수 만드는 메소드-> 분자와 분모의 최대공약수로 나눈다면 구할 수 있다. 
    public void reducedFraction(Fraction f)
    {

        int gcd_value = gcd(f.numerator, f.denominator); //최대 공약수 구하기
        f.numerator = f.numerator / gcd_value;            //그걸로 약분 하기~!
        f.denominator = f.denominator / gcd_value;


    }

    // (5) 분수에 대한 사칙 연산을 수행하는 메소드 

    // (5-1) AddFraction
    public Fraction AddFraction(Fraction f1, Fraction f2)
    {
        Fraction result = new Fraction(1);//임의의 결과를 받을 분수 받기

        int result_numerator;
        int result_denominator;

        result_numerator = f1.numerator * f2.denominator + f1.denominator * f2.numerator;
        result_denominator = f1.denominator * f2.denominator;

        result.numerator = result_numerator;
        result.denominator = result_denominator;

        result.reducedFraction(result);//기약분수로 나누는 알고리즘으로 식을 정리
        return result;//결과 분수 반환 
    }


    // (5-2) SubFraction
    public Fraction SubFraction(Fraction f1, Fraction f2)
    {
        Fraction result = new Fraction(1);//임의의 결과를 받을 분수 받기

        int result_numerator;
        int result_denominator;

        result_numerator = f1.numerator * f2.denominator - f1.denominator * f2.numerator;
        result_denominator = f1.denominator * f2.denominator;

        result.numerator = result_numerator;
        result.denominator = result_denominator;

        result.reducedFraction(result);//기약분수로 나누는 알고리즘으로 식을 정리
        return result;
    }

    // (5-3) MulFraction
    public Fraction MulFraction(Fraction f1, Fraction f2)
    {
        Fraction result = new Fraction(1, 1);//임의의 결과를 받을 분수 받기

        int result_numerator;
        int result_denominator;

        result_numerator = f1.numerator * f2.numerator;
        result_denominator = f1.denominator * f2.denominator;
        result.numerator = result_numerator;
        result.denominator = result_denominator;

        result.reducedFraction(result);//기약분수로 나누는 알고리즘으로 식을 정리

        return result;
    }

    // (5-4) DivFraction
    public Fraction DivFraction(Fraction f1, Fraction f2)
    {
        Fraction result = new Fraction(1);//임의의 결과를 받을 분수 받기

        int result_numerator;
        int result_denominator;

        result_numerator = f1.numerator * f2.denominator;
        result_denominator = f1.denominator * f2.numerator;

        result.numerator = result_numerator;
        result.denominator = result_denominator;

        result.reducedFraction(result);//기약분수로 나누는 알고리즘으로 식을 정리

        return result;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Fraction result = new Fraction(1);
        Fraction num = new Fraction(12, 28);
        Fraction num2 = new Fraction(11, 28);

        Console.WriteLine("임의의 분수 : (1) => {0} , (2) => {1}", num, num2);


        Console.Write("분수 덧셈>>");
        result = result.AddFraction(num, num2);
        Console.WriteLine(result);

        Console.Write("분수 뺄셈>>");
        result = result.SubFraction(num, num2);
        Console.WriteLine(result);

        Console.Write("분수 곱셈>>");
        result = result.MulFraction(num, num2);
        Console.WriteLine(result);

        Console.Write("분수 나눗셈>>");
        result = result.DivFraction(num, num2);
        Console.WriteLine(result);




    }
}
}

