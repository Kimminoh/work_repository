#include <iostream>
#include <string>
#include <stack>//stack STL(ǥ�� ���̺귯��) ���

using namespace std;


void char_printing(stack<char> str) {//���� ��� �Լ�
	while (!str.empty()) {//empty�� ��� �ȴٸ� 1�� ��ȯ�ϸ�, while ������ ������ �Ǿ� ���ǹ��� �����.
		cout << str.top() << "  ";//top()�� �ڷᱸ������ peek()�� ���� ���
		str.pop();
	}
}


stack<char> sort_printing(stack<char> str) {//������ �迭�� ������ �����ϴ� �˰���(����ǥ���)
	char first, second, temp;
	int s_size=str.size();
	

	
	return str;

}

void postfix_printing(stack<char> str) {//���� ���� ǥ��
	stack<char> new_stack;
	int first=48, second=48;//�ƽ�Ű�ڵ� 0�� 48�� å�� char ���ڿ��� 0�� ���� �״���� ���� ��������

	while (!str.empty()) {//�׸�Ž��
		if (((int)str.top() >= 48) && ((int)str.top() <= 57)) {//int�� ���� ����ȯ-> �ƽ�Ű�ڵ��?
			new_stack.push(str.top());
			str.pop();
		}
		if ((str.top() == 42 || str.top() == 43 || str.top() == 45 || str.top() == 47)) {//�ڵ�����ȯ!
			;
		}



	}
}



void postfix_calc(stack<char> str) {//���� ���� ���˰���
	stack<char> only_number;//���� ���ڸ� ���� �����ϳ� ����
	
	while (!str.empty()) {
		//�ƽ�Ű�ڵ��� ���� ���ڰ��� 48-> 0���� 57-> 9�����̴�. 
		if ((str.top() >= 48) || (str.top() <= 57)) {
			only_number.push(str.top());//�ش� ���� push �Ѵ�.
			str.pop();//�׸��� �� ���� str���� ������ �������� pop�Ѵ�!
		}
		

	}
}



void Bracket_checking(stack<char> str) {
	//stack<char> bracket_check;//��ȣ �˻�� ����
	//char* temp;

}//��ȣ �˻� �Լ�(�̱���)


int main(void) {
	stack<char> first_stack;//������� ���� ������ ����
	stack<char> infix_stack;
	char operating_num;// ���ÿ� ������� ���� ����

	cout << "������� �ۼ��Ͻÿ�(�� �ڸ���, p�� �Է¹��� �� �Է�����,���ڸ��� ���ڿ����մϴ�.)>>" << endl<<">>";
	cout << endl;

	while (true) {
		cin >> operating_num;
		if (operating_num == 'p') {
			break;
		}
		first_stack.push(operating_num);
	}
	cout << "���ÿ� �ִ°� �״�� ���>>  ";
	char_printing(first_stack);
	cout << endl;

	cout << "���� ǥ��� ��� >>  "; 
	sort_printing(first_stack);

	cout << "���� ǥ��� ��� >> ";

	
}