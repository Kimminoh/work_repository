using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp1
{
    
    internal class Program
    {
        abstract class Fig
        {
            abstract public void Area();
            abstract public void Girth();

            abstract public void Draw();
        }

        class Rect : Fig
        {
            int width;
            int height;

            public Rect()//기본생성자
            {
                width = 1;
                height = 1;
            }
            public Rect(int width, int height)//매개변수가 있는 생성자
            {
                this.width = width;
                this.height = height;
            }

            public override void Area()
            {
                Console.WriteLine("넓이 : " + width * height);
            }

            public override void Girth()
            {
                Console.WriteLine("둘레 : " + (width + height));
            }

            public override void Draw()
            {
                Console.WriteLine("====사각형====");
            }


        }

        class Circle : Fig
        {
            double rad;

            public Circle()//생성자
            {
                rad = 1.0;
            }

            public Circle(double rad)//매개변수있는 생성자
            {
                this.rad = rad;
            }

            public override void Area()
            {
                Console.WriteLine("넓이 : " + (3.14 * rad * rad));
            }

            public override void Girth()
            {
                Console.WriteLine("둘레 : " + (2 * 3.14 * rad));
            }

            public override void Draw()
            {
                Console.WriteLine("====원====");
            }


        }

        static void Main(string[] args)
        {

            Rect a = new Rect(10, 20);
            Circle b = new Circle(5);
            Console.WriteLine("추상클래스를 이용한 테스트프로그램 >>");

            Console.WriteLine(" ");
            a.Area();
            a.Girth();
            a.Draw();

            Console.WriteLine(" ");
            b.Area();
            b.Girth();
            b.Draw();

        }
    }
}
