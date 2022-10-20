using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5장_예제실습
{
    internal class Program
    {
        /*(1) 예제 5-1
        class Baseclass {
            protected int a = 1;//상속
            protected int b = 2;//상속 필드
        }

        class Derivedclass : Baseclass {
            new int a = 3;//여기서 상속받지않고 new를 입력시, 숨기지않아도된다고 뜸!
            new double b = 4.5;

            public void Output()
            {
                Console.WriteLine("BaseClass : a={0}, DeviedClass : a ={1}", base.a, a);//base키워드

                Console.WriteLine("BaseClass : b={0}, DeviedClass : b ={1}", base.b, b);//base키워드
            }
        */

        //예제 5-2
        /*
        class BaseClass
        {
            public BaseClass()
            {
                Console.WriteLine("베이스 클래스 생성자 작동");
            }//생성자 생성

        }
        class DerviedClass : BaseClass
        {
            public DerviedClass()
            {
                Console.WriteLine("파생 클래스 생성자 작동");
            }
        }
        */
        /*
        class Baseclass
        {
            public int a, b;
            public Baseclass()
            {
                a = 1; b = 2;
            }
            public Baseclass(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }

        class Derivedclass : Baseclass
        {
            public int c = 3;
            public Derivedclass()
            {
                c = 1;
            }


            public Derivedclass(int a, int b, int c)
            {
                this.c = c;
            }

          */

        //예제 5-4
        /*
        class BaseCalss
        {
            public void m_a()
            {
                Console.WriteLine("베이스클래스 메소드");
            }
        }

        class DerviedClass : BaseCalss {
            new public void m_a()
            {
                Console.WriteLine("파생클래스입니다. 오버라이딩 된다면 해당 문구 출력");
            }
            public void m_a(int i)
            {
                Console.WriteLine("파생클래스입니다. 오버로딩(중복)된다면 해당 문구를 출력합니다.");

            }
        }
        */

        //예제 5-5 메소드 재정의
        /*
        class BaseClass
        {
            virtual public void m_a()
            {
                Console.WriteLine("베이스 A메소드입니다.");
            }
            virtual public void m_b()
            {
                Console.WriteLine("베이스 B메소드입니다.");
            }
            virtual public void m_c()
            {
                Console.WriteLine("베이스 C메소드입니다.");
            }
        }

        class DerivedClass : BaseClass 
        {
            new public void m_a()
            {
                Console.WriteLine("파생 A메소드입니다.해당 문구가 출력된다면 Virtual키워드가 있다면 해당 문구는 출력되지않습니다. 이유는 new" +
                    "접근 수정자로 있습니다.");
            }
            override public void m_b()
            {
                Console.WriteLine("베이스 B메소드입니다.해당 문구가 출력된다면 오버라이드 접근수정자가 있는 것 입니다.");
            }
            public void m_c()
            {
                Console.WriteLine("베이스 C메소드입니다. 정의 형태에 따라 해당 문구가 출력될 수 있습니다.");
            }
        }
        */
        //예제 5-6 추상 클래스
        /*
        abstract class AbClass
        {
            public abstract void m_a();
            public void m_b()
            {
                Console.WriteLine("추상클래스의 메소드 B입니다.");

            }
        }
        class impclass : AbClass { 
            override public void m_a()
            {
                Console.WriteLine("메소드A가 오버라이드 되었습니다.");
            }
        }
        */
        //예제 5-7
        /*
        class Baseclass
        {
            public void m_a()
            {
                Console.WriteLine("베이스 클래스입니다.");
            }
        }
        class Derviedclass : Baseclass { 
            new public void m_a()
            {//new 키워드로 인해 
                base.m_a();//base는 부모 클래스의 메소드를 가져오게된다.
                Console.WriteLine("파생클래스의 메소드가 작동되었습니다.");
            }
        }
        */

        //예제 5-8
        /*
        class CLanguage
        {
            public bool Equal(object obj)//object객체는 모든 객체를 받는 형태이다.
            {
                if (obj is CLanguage) return true; // obj가 CLanguage 객체이면 true반환
                else return false;
            }
            

        }
        class Csharp : CLanguage
        {
            new public bool Equal(object obj)
            {
                return (obj is Csharp) ? true : false;//3항연산자로도 가능
            }
        }
        */
        //예제 5-9
        /*
        class BaseClass { 
            public virtual void Output()
            {
                Console.WriteLine("베이스클래스입니다...");
            }
        }
        class DerviedClass : BaseClass {
            public override void Output()
            {
                Console.WriteLine("파생클래스입니다...");
            }
        }



        static void Print(BaseClass obj)
        {
            obj.Output();
        }
        */
        //예제 5-10
        /*
        class CLanguage
        {
            virtual public void Print()
            {
                Console.WriteLine("CLanguage의 클래스...");
            }
        }
        class Java : CLanguage {
            override public void Print()
            {//메소드 오버라이딩 
                Console.WriteLine("Java의 클래스...");
            }
        }

        */
        //예제 5-11
        /*

        interface IRect
        {
            void Area(int width, int height);
        }
        interface ITri
        {
            void Area(int width, int height);
        }
        class Shape : IRect, ITri
        {
            void IRect.Area(int width, int height)
            {
                Console.WriteLine("사각형 넓이 : " + (width * height));
            }
            void ITri.Area(int width, int height)
            {
                Console.WriteLine("삼각형 넓이 : " + (width * height) / 2);
            }
        }
        */

        //예제 5-12
        interface ix { void xmethod(int i); }
        interface iy :ix{ void ymethod(int i); }//인터페이스 끼리 상속

        class A : ix
        {
            private int a;
            public int prop_A
            {
                get { return a; }
                set { a = value; }
            }
            public void xmethod(int i) { a = i; }
        }

        class B : A,iy
        {
            private int b;
            public int prop_B
            {
                get { return b; }
                set { b = value; }
            }
            public void ymethod(int i) { b = i; }
        }



        static void Main(string[] args)
        {
            //예제 5-12
            B obj = new B();
            obj.ymethod(10);
            obj.xmethod(5);

            Console.WriteLine("a={0}, b={1}", obj.prop_A, obj.prop_B);


            //예제 5-11
            /*
            Shape s = new Shape();
            ((IRect)s).Area(20, 20);//캐스팅업
            ((ITri)s).Area(20, 20);//캐스팅업 
            IRect r = s;//인터페이스 객체로 캐스팅업
            ITri t = s;//인터페이스 객체로 캐스팅 업 
            r.Area(30, 30);//인터페이스 객체로 캐스팅업 후에는 해당 문구처럼 사용 가능
            t.Area(30, 30);
            //s.Area(30,30)-> 해당 문구는 사용 불가!(모호함)
            */

            //예제 5-10
            /*
            CLanguage c = new Java();//해당 선언이 중요! 상속 개체를 new 옆에!(Java클래스의 객체를 가르킴, 자료형은 CLanguage)
            c.Print();//Print메소드 호출 -> 가르키는 객체 우선 -> override
            */
            //예제 5-9
            /*
            BaseClass obj1 = new BaseClass();
            DerviedClass obj2 = new DerviedClass();
            Print(obj1);//BaseClass obj = obj1 과 같은 표현 -> 같은 클래스 형태로 베이스클래스 그대로 출력
            Print(obj2);//BaseClass obj = obj2->Dervied객체임! -> 오버라이드된 형태(상속관계의 객체)
            */



            //예제 5-8
            /*
            CLanguage c = new CLanguage();
            Csharp cs = new Csharp();

          

            if (c.Equal(cs))//상향식 캐스팅 상황
                Console.WriteLine("업캐스팅 상황입니다. 성공");
            else
                Console.WriteLine("업캐스팅이 유효하지않습니다.");
            if (cs.Equal((Csharp)c))//하향식 캐스팅 상황 -> 실행은 안됨 !
                Console.WriteLine("다운캐스팅입니다. 유효합니다.");
            else
                Console.WriteLine("다운캐스팅입니다. 유효하지않습니다.");
            */


            //예제 5-7
            /*
            Derviedclass obj = new Derviedclass();
            obj.m_a();  
            */

            //예제 5-6
            /*
            impclass obj = new impclass();
            obj.m_a();
            obj.m_b();
            */


            //예제 5-5
            /*
            BaseClass s = new DerivedClass();//해당 구문은 Virtual을 이용하기 위한 구문
            s.m_a();
            s.m_b();
            s.m_c();
            */

            //예제 5-4
            /*
            BaseCalss obj1 = new BaseCalss();
            DerviedClass obj2 = new DerviedClass();
            obj1.m_a();//메소드 출력
            obj2.m_a();//메소드 오버라이딩
            obj2.m_a(1);//메소드 중복 
            */
            // 예제 5-1
            /*
            Derivedclass obj = new Derivedclass();
            obj.Output();
            */

            //예제 5-2
            /*
            DerviedClass obj = new DerviedClass();
            Console.WriteLine("메인 문 작동");
            */

            //예제 5-3
            /*
            Derivedclass obj1 = new Derivedclass();
            Derivedclass obj2 = new Derivedclass(1, 2, 3);
            Console.WriteLine("a={0},b={1},c={2}", obj1.a, obj1.b, obj1.c);

            Console.WriteLine("a={0},b={1},c={2}", obj2.a, obj2.b, obj2.c);
            */

            //예제 5-4


        }

    }

}