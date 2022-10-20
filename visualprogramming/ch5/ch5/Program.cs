using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
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
        abstract class AbClass { 
            
        }

        //12개 전부 실습 후 전부 수업활동일지 업로드 ==>

        static void Main(string[] args)
            {

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

