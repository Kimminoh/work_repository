using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Stack //스택의 기본구조를 따라감
    {
        private int[] stack;//스택을 담을 배열
        int sp = -1;//스택의 제일 위를 표시할 수 (top이라고도 불림)
        public Stack(int size)//생성 자 생성 시, 매개변수 있게 생성 때, 해당 매개변수만큼 배열을 동적할당
        {
            stack = new int[size];

        }

        //(1) 디폴트 생성자 생성(기본 크기는 100)
        public Stack()//생성자 생성 시, 매개변수 없이 생성할 때, 100개를 기본으로 동적할당
        {
            stack = new int[100];//int[] stack = new int[100] 과 동일 표현
        }
        
        public void Push(int data)//Push 메소드
        {
            if (sp == stack.Length)//만약 sp가 스택 배열의 제일 위 라고 한다면
            {//스택이 꽉찼다면
                Console.WriteLine("스택이 꽉 찼습니다.");//오류문구 출력 
            }
            else//일반 상황...
            {
                sp = sp + 1;//sp를 1 증가(최상위층 번호 올리기)
                stack[sp] = data; //해당 부분에 데이터 삽입(push)
            }
        }

        public int Pop()//Pop 메소드 
        {
            int sp_data;//pop 되는 임의의 데이터를 받을 int 임시 변수
            if (sp == -1) 
            {//스택이 비었다면
                Console.WriteLine("스택이 비었습니다.");
                return 0;
            }
            else//스택이 비지않는 일반적인 상황 
            {
                sp_data = stack[sp];//pop된 데이터를 임시 필드 sp_data에 삽입 
                sp = sp - 1;//sp를 감소시켜 아래로 내려감을 표시
                return sp_data;//pop되는 데이터는 리턴으로
            }
        }
        public int getsp() { return sp; }//꼭대기 참조 , main문의 루프를 위해(sp의 보안상태때문에 접근용으로!)
        //only read 용도
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack reverse_integer = new Stack();//배열이 100인 스택 생성
            int number;//입력 받을 숫자
            while (true)
            {
                Console.Write("정수를 입력하시오(입력종료 시 0을 입력)>>");
                number = int.Parse(Console.ReadLine());//int형으로 받기 위해 int.Parse()로 ReadLine감싸주기
                if (number == 0)
                    break;
                else
                {
                    reverse_integer.Push(number);//스택에 값 그대로 푸시(0이 나올때까지)
                }

            }
            

            Console.Write("입력한 정수의 역순 출력 >>");
            //제일 위를 가르키는 값을 받아서 pop()할떄마다 값을 출력하는 방식 채택
            //즉, 푸시된 스택을 그대로 빼어서 출력하면 그것이 역순 출력이 되어진다.(먼저 들어간건 제일 마지막에 나오는 스택의 특성)
            for (int i = reverse_integer.getsp(); i >= 0; i--)//초기화 값 i값을 getsp()메소드를 통해서 제일 위에있는 값을 가져옴
            {
                Console.Write(reverse_integer.Pop() + " "); //하나씩 출력 
            }
            Console.WriteLine("");//개행
        }
    }
}
