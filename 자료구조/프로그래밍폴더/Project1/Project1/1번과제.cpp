#include <iostream>
#include <string>

//flag사용???

using namespace std;

class CircleQue {
	//const int max = 8;
private:
	//큐의 내용은 문자열을 담기로 함
	int front = 0;
	int rear = 0;
	int max = 8;
	string* que = new string[max];
	//string* que = new string[max];(동적할당 시)
public:
	int size();
	bool is_empty_user();
	bool is_full();
	void AddQue(string data);
	string DelQue();
	void print_front_rear();
	void print_que() {

		for (int i = front+1; i <= rear; i++)//여기서 i<size()를 해버리면 안됨! why-> 값은 유동적! size()를하면 실시간으로 값이 변경
			//그러므로 i값을 front로 끝나는 값을 rear값으로 생각 !
		{
			cout << que[i] << " " ;;//que자체를 출력 시
			
		}
		cout << endl;
		cout << "현재 que의 갯수 : " << size() << endl;
	}
};
//값을 가지고 있는 큐의 개수를 세는 멤버함수 구현 부분
int CircleQue::size() {
	return (rear - front + max) % max;
	//후면-전면 + (음수대비용 최대값) % 최대값 모듈러 -> 존재하는 큐 크기 반환
}
//큐가 비었는지 확인하는 멤버함수 구현 부분
bool CircleQue::is_empty_user() {//true= 공백 false=공백아님
	if (front == rear)
		return true;
	else
		return false;
}

//큐가 가득 찼는지 확인하는 멤버함수 구현 부분
bool CircleQue::is_full() {
	if ((front % max) == (rear + 1) % max)	//%연산자를 이용하여 -를 방지해 가득찼는지 확인
		return true;
	else
		return false;
}


//큐를 추가하는 멤버함수 구현 부분
void CircleQue::AddQue(string data) {
	if (is_full()) {
		cout << "오류!(큐가 꽉 참)" << endl;
	}
	else {
		rear = (rear + 1) % max;//임의로 que를 한 개 비워놓는 유연성? %연산자 이용하여 큐를 추가함 why-> 원형큐의 특성상 8을 넘어갈 수 있음
		//인덱스는 8안에 있어야하므로 나머지 연산자 이용
		que[rear] = data;
	}
}
//큐를 삭제하는 멤버함수 구현 부분 
string CircleQue::DelQue() {
	string Del_value;
	if (is_empty_user()) {
		cout << "오류!(큐가 비었음)" << endl;
	}
	else {
		front = (front + 1) % max;
		return que[front];
	}
}
//front와 rear 확인하는 함수 구현 부분
void CircleQue::print_front_rear() {
	cout << "front_index>>"<<front<<"  ,rear_index>> "<<rear << endl;//front와 rear의 위치를 나타내는 클래스 멤버함수
}


void select_menu(int op,CircleQue &temp) { //& 참조 매개변수를 사용해 유연성을 높였다.(많은 객체를 생성하여도 해당 함수를 사용할 수 있다.)
	string temp_string;//삽입 문자를 받기 위한 임시 스트링
	while (true) {// 무한 루프 (1) -----> break를 if마다 걸어줘야한다.(switch문으로 대체가능)
		if (op == 1) {//(1) 삽입 시
			cout << "삽입할 문자를 입력해주세요>>";
			cin >> temp_string;
			temp.AddQue(temp_string);//큐 클래스 - 추가 부분

			//is_full이 두번이라 비효율적이지 않느냐? - AddQue같은 경우 리턴형이 존재 x , 임의의 리턴형을 삽입하여 처리할 수 있겠지만,
			//break는 반복문에서만 사용할 수 있는 지정어이므로 해당 방법을 채택하였다. 
			if (temp.is_full())//해당 작업을 하지 않으면 원형큐의 특성 때문에 데이터가 계속해서 중첩해서 삽입된다.
				break;

			//que가 가득 차지 않았으면
			cout << "문자 추가완료 " << endl;
			break;
		}

		else if (op == 2) {//(2) 삭제 시
			cout << "문자를 삭제합니다. " << endl;
			temp_string = temp.DelQue();
			//원형큐의 삭제 매커니즘은 front를 +1을 하여 데이터를 다른곳을 가르키게 하는것이다. 
			if (temp.is_empty_user())//그러므로 해당 작업을 하지않으면 원형큐의 특성 때문에 데이터가 다시 보일 수 있다!
				break;
			cout << "삭제된 문자: " << temp_string << endl;//삭제된 문자를 표기.(확인용)
			break;

		}
		
		else if (op == 3) { //현재 큐가 담겨있는 내용을 출력
			cout << "현재 큐에 담겨있는 내용을 출력합니다" << endl;
			temp.print_que();
			break;
		}

		else if (op == 4) {
			temp.print_front_rear();
			break;

		}

		else {
			cout << "정상적이지 않는 입력입니다.다시 입력해주세요" << endl;
		}
	}
}


int main() {
	CircleQue cq ;//객체 생성
	string temp;
	int op=0;

	cout << "===Que 처리프로그램===" << endl;
	
	while (true) {
		//반복 속에 반복이지만 , cq를 다른 방식으로 삽입 하는등 유연하게 할 수 있다. main문에 while문 하나만으로도 가능하다. 
		cout << "1.삽입 2. 삭제 3.현재 큐 출력 4.front와 rear 포인터확인 5. 종료 >> ";
		cin >> op;

		if (op == 5) {//종료 방법 : 5번
			cout << "프로그램을 종료합니다..." << endl;
			break;
		}
		else {
			select_menu(op, cq);//menu선택
		}
	}

}