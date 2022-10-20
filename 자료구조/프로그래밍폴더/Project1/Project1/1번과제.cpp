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
	string* que = new string[max];
	//string* que = new string[max];(�����Ҵ� ��)
public:
	int size();
	bool is_empty_user();
	bool is_full();
	void AddQue(string data);
	string DelQue();
	void print_front_rear();
	void print_que() {

		for (int i = front+1; i <= rear; i++)//���⼭ i<size()�� �ع����� �ȵ�! why-> ���� ������! size()���ϸ� �ǽð����� ���� ����
			//�׷��Ƿ� i���� front�� ������ ���� rear������ ���� !
		{
			cout << que[i] << " " ;;//que��ü�� ��� ��
			
		}
		cout << endl;
		cout << "���� que�� ���� : " << size() << endl;
	}
};
//���� ������ �ִ� ť�� ������ ���� ����Լ� ���� �κ�
int CircleQue::size() {
	return (rear - front + max) % max;
	//�ĸ�-���� + (�������� �ִ밪) % �ִ밪 ��ⷯ -> �����ϴ� ť ũ�� ��ȯ
}
//ť�� ������� Ȯ���ϴ� ����Լ� ���� �κ�
bool CircleQue::is_empty_user() {//true= ���� false=����ƴ�
	if (front == rear)
		return true;
	else
		return false;
}

//ť�� ���� á���� Ȯ���ϴ� ����Լ� ���� �κ�
bool CircleQue::is_full() {
	if ((front % max) == (rear + 1) % max)	//%�����ڸ� �̿��Ͽ� -�� ������ ����á���� Ȯ��
		return true;
	else
		return false;
}


//ť�� �߰��ϴ� ����Լ� ���� �κ�
void CircleQue::AddQue(string data) {
	if (is_full()) {
		cout << "����!(ť�� �� ��)" << endl;
	}
	else {
		rear = (rear + 1) % max;//���Ƿ� que�� �� �� ������� ������? %������ �̿��Ͽ� ť�� �߰��� why-> ����ť�� Ư���� 8�� �Ѿ �� ����
		//�ε����� 8�ȿ� �־���ϹǷ� ������ ������ �̿�
		que[rear] = data;
	}
}
//ť�� �����ϴ� ����Լ� ���� �κ� 
string CircleQue::DelQue() {
	string Del_value;
	if (is_empty_user()) {
		cout << "����!(ť�� �����)" << endl;
	}
	else {
		front = (front + 1) % max;
		return que[front];
	}
}
//front�� rear Ȯ���ϴ� �Լ� ���� �κ�
void CircleQue::print_front_rear() {
	cout << "front_index>>"<<front<<"  ,rear_index>> "<<rear << endl;//front�� rear�� ��ġ�� ��Ÿ���� Ŭ���� ����Լ�
}


void select_menu(int op,CircleQue &temp) { //& ���� �Ű������� ����� �������� ������.(���� ��ü�� �����Ͽ��� �ش� �Լ��� ����� �� �ִ�.)
	string temp_string;//���� ���ڸ� �ޱ� ���� �ӽ� ��Ʈ��
	while (true) {// ���� ���� (1) -----> break�� if���� �ɾ�����Ѵ�.(switch������ ��ü����)
		if (op == 1) {//(1) ���� ��
			cout << "������ ���ڸ� �Է����ּ���>>";
			cin >> temp_string;
			temp.AddQue(temp_string);//ť Ŭ���� - �߰� �κ�

			//is_full�� �ι��̶� ��ȿ�������� �ʴ���? - AddQue���� ��� �������� ���� x , ������ �������� �����Ͽ� ó���� �� �ְ�����,
			//break�� �ݺ��������� ����� �� �ִ� �������̹Ƿ� �ش� ����� ä���Ͽ���. 
			if (temp.is_full())//�ش� �۾��� ���� ������ ����ť�� Ư�� ������ �����Ͱ� ����ؼ� ��ø�ؼ� ���Եȴ�.
				break;

			//que�� ���� ���� �ʾ�����
			cout << "���� �߰��Ϸ� " << endl;
			break;
		}

		else if (op == 2) {//(2) ���� ��
			cout << "���ڸ� �����մϴ�. " << endl;
			temp_string = temp.DelQue();
			//����ť�� ���� ��Ŀ������ front�� +1�� �Ͽ� �����͸� �ٸ����� ����Ű�� �ϴ°��̴�. 
			if (temp.is_empty_user())//�׷��Ƿ� �ش� �۾��� ���������� ����ť�� Ư�� ������ �����Ͱ� �ٽ� ���� �� �ִ�!
				break;
			cout << "������ ����: " << temp_string << endl;//������ ���ڸ� ǥ��.(Ȯ�ο�)
			break;

		}
		
		else if (op == 3) { //���� ť�� ����ִ� ������ ���
			cout << "���� ť�� ����ִ� ������ ����մϴ�" << endl;
			temp.print_que();
			break;
		}

		else if (op == 4) {
			temp.print_front_rear();
			break;

		}

		else {
			cout << "���������� �ʴ� �Է��Դϴ�.�ٽ� �Է����ּ���" << endl;
		}
	}
}


int main() {
	CircleQue cq ;//��ü ����
	string temp;
	int op=0;

	cout << "===Que ó�����α׷�===" << endl;
	
	while (true) {
		//�ݺ� �ӿ� �ݺ������� , cq�� �ٸ� ������� ���� �ϴµ� �����ϰ� �� �� �ִ�. main���� while�� �ϳ������ε� �����ϴ�. 
		cout << "1.���� 2. ���� 3.���� ť ��� 4.front�� rear ������Ȯ�� 5. ���� >> ";
		cin >> op;

		if (op == 5) {//���� ��� : 5��
			cout << "���α׷��� �����մϴ�..." << endl;
			break;
		}
		else {
			select_menu(op, cq);//menu����
		}
	}

}