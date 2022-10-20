using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    /* 프로퍼티 첫번째 예(1)
    class Oper
    {
        double num1;
        double num2;
        public void setNum1(double num1) { this.num1 = num1; }
        public void setNum2(double num2) { this.num2 = num2; }

        public double getNum1() { return num1;}
        public double getNUm2() { return num2; }

        public double Add()
        {
            return num1 + num2;
        }
    }
    */
    /*프로퍼티 두번째 예- 사용하는 방법,수동 프로퍼티(2)
    class Oper {
        double num1;
        double num2;
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public double Add()
        {
            return num1 + num2;
        }
    */
    /*프로퍼티 세번 째 - 자동 프로퍼티(3)
    class Oper
    {
        //double num1;
        //double num2; 자동 프로퍼티는 값을 주석처리하거나 선언자체 x
        public double Num1
        {
            get;
            set;
        }
        public double Num2//<--해당 이름이 필드명이자 자동 프로퍼티가 됨
        {
            get;
            set;
        }
        public double Add()
        {
            return Num1 + Num2;
        }



    }
    */

    /* 속성조각 코드
    class Test
    {
        public int MyProperty { get; set; }


        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        indexer 후 Tab 2번 -> 인덱스 기본 코드

    }
    */

    /*인덱서 예제(4)
    class Color
    {
        private string[] color = new string[5];
        public string this[int index]
        {
            get { return color[index]; }
            set { color[index]=value; }//해당 value값은 해당 this[int index]의 반환형을 따라간다.
        }

    }
    */
    /* 예제 4-24(5)
    class Complex
    {
        private double realPart;
        private double imagePart;

        public Complex(double realPart, double imagePart)
        {
            this.realPart = realPart;
            this.imagePart = imagePart;
        }
        public static Complex operator+(Complex x1,Complex x2)
        {
            Complex x = new Complex(0, 0);
            x.realPart = x1.realPart + x2.realPart;
            x.imagePart = x1.imagePart + x2.imagePart;
            return x;
        }
        public static Complex operator -(Complex x1, Complex x2)
        {
            Complex x = new Complex(0, 0);
            x.realPart = x1.realPart - x2.realPart;
            x.imagePart = x1.imagePart - x2.imagePart;
            return x;
        }

        public override string ToString()
        {
            return "(" + realPart + "," + imagePart + "i)";//(실수+허수i) 형태
        }
    }
    */


    // 실습문제 4-17 연산자 중복+인덱서 이용(Main문제)
    class Vector {
        public int size;
        private int[] v;


        public Vector(int size)
        {
            v = new int[size];
            this.size = size;
        }

        public int this[int index]
        {
            get { return v[index]; }
            set { v[index]=value; }
        }

        public static Vector operator ++(Vector v)
        {
            Vector a = new Vector(v.size);
            for (int i = 0; i < v.size; i++)
            {
                a[i] = v[i] + 1;
            }
            return a;
        }
        public static Vector operator--(Vector v)
        {
            Vector a = new Vector(v.size);
            for (int i = 0; i < v.size; i++)
            {
                a[i] = v[i] - 1;
            }
            return a;
        }


    }
    



    internal class Program
    {
        static void Main(string[] args)
        {
            // 실습문제 4-17 연산자 중복+인덱서 이용(Main문제)
            Vector vector = new Vector(5);
            for(int i = 0; i < 5; i++)
            {
                vector[i] = 10 + i;
            }
            for(int i = 0; i < 5; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();

            vector++;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();

            vector--;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();

            

    /*프로퍼티 첫번째 예(1)
    double num1 = 10, num2 = 20;
    Oper op = new Oper();
    op.setNum1(num1);
    op.setNum2(num2);
    Console.WriteLine("결과: {0}+{1}={2}", op.getNum1(), op.getNUm2(), op.Add()) ;
    */
    /*프로퍼티 두번째 예- 사용하는 방법(2)
    double num1 = 10, num2 = 20;
    Oper op = new Oper();
    op.Num1 = num1;//프로퍼티는 변수처럼 사용하는 느낌익히기
    op.Num2 = num2;
    Console.WriteLine("결과: {0}+{1}={2}", op.Num1, op.Num2, op.Add());//프로퍼티는 괄호를 안쓰는 것을 습관화
    */
    /* 프로퍼티 세번 째 - 자동 프로퍼티(3)
    double num1 = 10, num2 = 20;
    Oper op = new Oper();
    op.Num1 = num1;//프로퍼티는 변수처럼 사용하는 느낌익히기
    op.Num2 = num2;
    Console.WriteLine("결과: {0}+{1}={2}", op.Num1, op.Num2, op.Add());//프로퍼티는 괄호를 안쓰는 것을 습관화
    */

    /* 인덱서 예제(4) 
    Color c = new Color();
    for (int i = 0; i < 5; i++)
    {
        c[i] = Console.ReadLine();
    }

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Color is " + c[i]);
    }
    */

    /* 예제 4-24(5)
    Complex c, c1, c2;
            c1 = new Complex(1, 2);
            c2 = new Complex(3, 4);
            c = c1 + c2;
            Console.WriteLine(c1 + " + " + c2 + " = " + c);
    */
        }
    }
}
