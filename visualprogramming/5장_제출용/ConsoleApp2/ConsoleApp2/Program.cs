using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Complex
    {
        public double real;//실수부
        public double image;//허수부

        //(예제 4-12에 있는 부분 참조)
        public Complex(double temp)
        {
            real = temp;
            image = 0;
        }
        
        public Complex(double real, double image)
        {
            this.real = real;
            this.image = image;
        }
        //(1) 사직연산 중복 정의-> 핵심은
        //public static으로 선언, 이항 연산자는 매개변수는 2개이며, 한개는 반드시 자신이 클래스 형태여야하고
        //반환형은 모든자료형이 가능하다.      
        public static Complex operator +(Complex x, Complex y)
        {
            Complex result = new Complex(0);
            result.real = x.real + y.real;
            result.image = x.image + y.image;

            return result;
        }
        public static Complex operator -(Complex x, Complex y)
        {
            Complex result = new Complex(0);
            result.real = x.real - y.real;
            result.image = x.image - y.image;

            return result;
        }

        public static Complex operator *(Complex x, Complex y)
        {
            Complex result = new Complex(0);
            result.real = x.real*y.real - x.image*y.image;
            result.image = x.real*y.image + x.image*y.real;

            return result;
        }

        public static Complex operator /(Complex x, Complex y)
        {
            Complex result = new Complex(0);
            result.real = (x.real * y.real + x.image * y.image) / ((x.image * x.image) + (y.image * y.image));
            result.image =((x.image*y.real)-(x.real*y.image))/ ((x.image * x.image) + (y.image * y.image));

            return result;
        }

        //(2)복소수를 위하 ToString메소드
        override public string ToString()//public 과 override 위치는 바뀌어도 상관없다
        {
            // Console.WriteLine(Complex객체)하면 아래의 형태로 출력된다.
            return ("("+ real + "," + image + ")");//(실수부,허수부) 형태
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //임의의 복소수 2개 생성(생성자로 초기화)
            Complex x = new Complex(1, 3);
            Complex y = new Complex(2, 4);
            Console.WriteLine("==테스트클래스 : 복소수 ==");
            Console.WriteLine("테스트할 복소수 >> {0} 과 {1} ", x, y);//Tostring으로 이렇게해도 (실수부,허수부)로 출력
            Console.WriteLine("덧셈 >> ({0})+({1})i", (x + y).real, (x + y).image);//(x+y) 시 결과값은 result -> result.real, result.image과 동일 값 
            Console.WriteLine("뺄셈 >> ({0})+({1})i", (x - y).real, (x - y).image);
            Console.WriteLine("곱셈 >> ({0})+({1})i", (x * y).real, (x * y).image);
            Console.WriteLine("나눗셈 >> ({0})+({1})i", (x / y).real, (x / y).image);

        }
    }
}
