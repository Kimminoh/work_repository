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
	string *que=new string[max];
	//string* que = new string[max];(동적할당 시)
public:
	int size();
	bool is_empty_user();
	bool is_full();
	void AddQue(string data);
	string DelQue();
	void print_que() {
		//

		//print_que에서 원본 que를 훼손 시키면 계속 출력하기 힘듬!
		int size_check = size();
		for (int i = 0; i < size_check; i++)//여기서 i<size()를 해버리면 안됨! why-> size는 큐에따라 유동적으로 바뀌는 함수! 값을 받아놔야함!
		{
			cout << que[i] << " ";//que자체를 출력 시

		}
	}
};

int CircleQue::size() {
	return (rear - front + max) % max;
	//후면-전면 + (음수대비용 최대값) % 최대값 모듈러 -> 존재하는 큐 크기 반환
}

bool CircleQue::is_empty_user() {//true= 공백 false=공백아님
	if (front == rear)
		return true;
	else
		return false;
}


bool CircleQue::is_full() {
		if ((front % max) == (rear + 1) % max)
			return true;
		else
			return false;
}


void CircleQue::AddQue(string data) {
	if (is_full()) {
		cout << "오류!(큐가 꽉 참)" << endl;

	}

	rear = (rear + 1) % max;//임의로 que를 한 개 비워놓는 유연성?
	que[rear] = data;
}

string CircleQue::DelQue(){
	string Del_value;
	if (is_empty_user()) {
		cout << "오류!(큐가 비었음)" << endl;
	}
	front = (front + 1) % max;
	return que[front];
}



int main(){
	CircleQue cq;//객체 생성
	string temp;

	//flag 사용 --> 메뉴판을 만들어라!!!!
	while (true) {
		
		cout << "삽입할 문자를 입력하시오>>";
		cin >> temp;
		cq.AddQue(temp);
		if (temp == "stop") break;
	}
	
	cq.print_que();

	
}