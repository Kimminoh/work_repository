using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /* 1번 : get,set 함수로 구성
        class Squ {
            private double garo, sero;

            public double getGaro() { return garo; }
            public void setGaro(double garo) { this.garo = garo; }

            public double getSero() { return sero; }
            public void setSero(double sero) { this.sero = sero; }

            public double Area()
            {
                return garo * sero;
            }
            public double Girth()
            {
                return garo + sero;
            }
        
        }
        */

        /* 2번: get,set 프로퍼티로
        class Squ
        {
            private double garo, sero;
            public double Garo
            {
                get { return garo; } 
                set { garo = value; }
            }
            public double Sero
            {
                get { return sero; }
                set { sero = value; }
            }
            public double Area()
            {
                return garo * sero;
            }
            public double Girth()
            {
                return garo + sero;
            }
        }
        */

        class Squ {
            public double garo { get; set; }
            public double sero { get; set; }
            public double Area()
            {
                return garo * sero;
            }
            public double Girth()
            {
                return garo + sero;
            }
        }

        static void Main(string[] args)
        {
            /* 1번 : get,set 함수로 구성
            Squ x = new Squ();
            Console.Write("가로 길이 >> ");
            x.setGaro(double.Parse(Console.ReadLine()));

            Console.Write("세로 길이 >> ");
            x.setSero(double.Parse(Console.ReadLine()));

            Console.WriteLine("넓이 : {0:F2}", x.Area());
            Console.WriteLine("둘레 : {0:F2}", x.Girth());
            */
            /* 2번: get,set 프로퍼티로
            Squ x = new Squ();
            Console.Write("가로 길이 >> ");
            x.Garo=double.Parse(Console.ReadLine());

            Console.Write("세로 길이 >> ");
            x.Sero=double.Parse(Console.ReadLine());

            Console.WriteLine("넓이 : {0:F2}", x.Area());
            Console.WriteLine("둘레 : {0:F2}", x.Girth());
            */

            //3번: 자동프로퍼티
            Squ x = new Squ();
            Console.Write("가로 길이 >> ");
            x.garo = double.Parse(Console.ReadLine());

            Console.Write("세로 길이 >> ");
            x.sero = double.Parse(Console.ReadLine());

            Console.WriteLine("넓이 : {0:F2}", x.Area());
            Console.WriteLine("둘레 : {0:F2}", x.Girth());
        }
    }
}
