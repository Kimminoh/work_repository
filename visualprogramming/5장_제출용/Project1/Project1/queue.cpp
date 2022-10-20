#include <iostream>
#include <string>

//flag���???

using namespace std;

class CircleQue {
	//const int max = 8;
private:
	//ť�� ������ ���ڿ��� ���� ��
	int front = 0;
	int rear = 0;
	int max = 8;
	string *que=new string[max];
	//string* que = new string[max];(�����Ҵ� ��)
public:
	int size();
	bool is_empty_user();
	bool is_full();
	void AddQue(string data);
	string DelQue();
	void print_que() {
		//

		//print_que���� ���� que�� �Ѽ� ��Ű�� ��� ����ϱ� ����!
		int size_check = size();
		for (int i = 0; i < size_check; i++)//���⼭ i<size()�� �ع����� �ȵ�! why-> size�� ť������ ���������� �ٲ�� �Լ�! ���� �޾Ƴ�����!
		{
			cout << que[i] << " ";//que��ü�� ��� ��

		}
	}
};

int CircleQue::size() {
	return (rear - front + max) % max;
	//�ĸ�-���� + (�������� �ִ밪) % �ִ밪 ��ⷯ -> �����ϴ� ť ũ�� ��ȯ
}

bool CircleQue::is_empty_user() {//true= ���� false=����ƴ�
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
		cout << "����!(ť�� �� ��)" << endl;

	}

	rear = (rear + 1) % max;//���Ƿ� que�� �� �� ������� ������?
	que[rear] = data;
}

string CircleQue::DelQue(){
	string Del_value;
	if (is_empty_user()) {
		cout << "����!(ť�� �����)" << endl;
	}
	front = (front + 1) % max;
	return que[front];
}



int main(){
	CircleQue cq;//��ü ����
	string temp;

	//flag ��� --> �޴����� ������!!!!
	while (true) {
		
		cout << "������ ���ڸ� �Է��Ͻÿ�>>";
		cin >> temp;
		cq.AddQue(temp);
		if (temp == "stop") break;
	}
	
	cq.print_que();

	
}