using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    interface IOperation
    {
        void Insert(string str);
        string Delete();
        bool search(string str);
        string GetCurrentElt();
        int NumOfElements();

    }
    class Stack : IOperation
    {
        private string[] stacking;
        public int top = -1;//처음 시작할 때 -1로 초기화
        public Stack()
        {
            stacking = new string[10];//생성자 생성시 10개의 스택 생성
        }
        //우선 비었을 때, 꽉 찼을 때, 무시, 임의로 10개의 스택 생성
        public string Delete()
        {
            return stacking[top--];
        }
        public string GetCurrentElt()
        {
            return stacking[top];//현재 top에 있는 원소 반환
        }
        public void Insert(string str)
        {
            stacking[++top] = str;
        }
        public int NumOfElements()
        {
            return (top + 1);//top은 실질적으로 인덱스 값 , 그러므로 +1로 하여 실 갯수 맞춤 
        }
        public bool search(string str)
        {
            for (int i = 0; i <= top; i++)
            {
                if (stacking[i] == str)
                    return true;//동일한게있으면 true
            }
            return false;

        }
    }
    class Queue : IOperation
    {
        private string[] que_user;
        int rear = -1;
        int front = -1;//rear은 데이터가 들어가는 후면, front는 데이터가 나가는 면이 전면
        public Queue()
        {que_user = new string[10];}//생성자 생성 시, 큐 담을 배열 생성
        public string Delete()
        {    //front = front + 1;
            return que_user[++front];//front에 있는 값 return 주기(1 증가 시킨 값)
        }
        public string GetCurrentElt()
        { return que_user[front + 1]; }//값만 반환
        public void Insert(string str)
        { que_user[++rear] = str; }//rear을 한칸 전진 + 전진한 rear 인덱스에 데이터 삽입 
        public int NumOfElements()
        { return ((rear - front + 10) % 10); }//값 마이너스를 막기 위한 모듈러 연산을 이용해 갯수를 세기
        public bool search(string str)
        {
            for (; front <= rear + 1; front++)
            {
                if (que_user[front] == str)
                    return true;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            //스택 테스트
            Console.WriteLine("===========스택테스트===========");
            //insert 테스트
            s.Insert("o");
            s.Insert("love");
            s.Insert("OMG");
            //GetCurrentElt 테스트
            Console.WriteLine("현재 최상층에 있는 원소확인 : " + s.GetCurrentElt());
            //Delete 테스트
            Console.WriteLine("방금 삭제된 원소 : " + s.Delete());
            //NumOfElements 테스트
            Console.WriteLine("스택에 존재하는 원소의 갯수(예상:2) : " + s.NumOfElements());
            //Search 테스트
            Console.WriteLine("현재 love라는 단어가 스택에 있는가? 있으면 true, 없으면 false : " + s.search("love"));



            Console.WriteLine("");

            //que 테스트
            
            Console.WriteLine("===========큐 테스트===========");
            Queue q = new Queue();
            //insert 테스트
            q.Insert("o");
            q.Insert("lov");
            q.Insert("OMG");
            //GetCurrentElt 테스트
            Console.WriteLine("현재 front(앞)에 있는 원소 : " + q.GetCurrentElt());
            //Delete 테스트
            Console.WriteLine("방금 삭제된 원소 : " + q.Delete());
            Console.WriteLine("현재 front에 있는 원소 : " + q.GetCurrentElt());//delete 후 삭제된 원소 확인 
            //NumOfElements 테스트
            Console.WriteLine("스택에 존재하는 원소의 갯수(예상:2) : " + q.NumOfElements());

            //Search 테스트
            Console.WriteLine("현재 love라는 단어가 스택에 있는가? 있으면 true, 없으면 false : " + q.search("love"));




        }
    }
}