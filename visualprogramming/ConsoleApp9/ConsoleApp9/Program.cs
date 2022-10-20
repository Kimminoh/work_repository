using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Stack {
        private int[] stack;
        int sp = -1;
        public Stack(int size)
        {
            stack = new int[size];

        }

        //(1) 디폴트 생성자 생성(기본 크기는 100)
        public Stack()
        {
            stack = new int[100];
        }



        public void Push(int data)
        {
            if (sp == stack.Length)
            {//스택이 꽉찼다면
                Console.WriteLine("스택이 꽉 찼습니다.");
            }
            else
            {
                sp = sp + 1;//sp를 1 증가(최상위층 번호 올리기)
                stack[sp] = data; //해당 부분에 데이터 삽입(push)
            }
        }

        public int Pop()
        {
            int sp_data;
            if (sp == -1)
            {//스택이 비었다면
                Console.WriteLine("스택이 비었습니다.");
                return 0;
            }
            else
            {
                sp_data = stack[sp];
                sp = sp - 1;
                return sp_data;
            }
        }

        public int getsp() { return sp; }//꼭대기 참조 
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Stack reverse_integer = new Stack();//배열이 100인 스택 생성
            int  number;//입력 받을 숫자
            while (true)
            {
                Console.Write("정수를 입력하시오(입력종료 시 0을 입력)>>");
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                    break;
                else
                {
                    reverse_integer.Push(number);
                }
                
            }
            Console.WriteLine(reverse_integer.getsp());

            Console.Write("입력한 정수의 역순 출력 >>");
            int i = reverse_integer.getsp();
            for(; i >= 0; i--)
            {
                Console.Write(reverse_integer.Pop()+" ");
            }





            


        }
    }
}
