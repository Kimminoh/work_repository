#include <iostream>
#include <string>//string��ü�� �̿���
#include <stack>//stack STL�� �̿���
using namespace std;

//�������� �켱������ ���ϴ� �Լ�-> 1�̸� +,- , 2�̸� *�� /, 0�̸� �� ���� ��� �����
int level_op(char c) {
	int return_value = 0;
	if (c == '+' || c == '-') {
		return return_value + 1;
	}

	if (c == '*' || c == '/') {
		return return_value + 2;
	}

	return 0;
}



int main(void) {
	string input;//���ڿ��� ǥ����� �޴´�.
	string result;//����� ���� ���ڿ� 

	char c;
	stack<char> num_stack;
	stack<char> op_stack;
	int pro;

	op_stack.push('0');//�����ǰ��� �־� �� ���� x



	cout << "������� �Է��ϼ���>>";
	cin >> input;

	for (int i = 0; i < input.length(); i++) {//i�� �迭ó��!string��ü�� �̿�
		c = input[i];//�ѱ��ھ� �˻�


		//1. �ǿ����ڸ� ��������
		if (c >= '0' && c <= '9') {
			result += c;//�ٷ� ��ºκ����� �ѱ�
			continue;// �ش� continue���� ������ ���� ���� �ݺ� ����
		}


		//2. �����ڸ� ������ ��
		if (c == '+' || c == '-' || c == '*' || c == '/') {
			if (!op_stack.empty()) {
				op_stack.push(c);//op_stack�� ó���̶�� �ٷ� push
				
			}
			// ������ top�� level_op���� ũ��-> pop �ݺ� �� push
			if (level_op(c) <= level_op(op_stack.top())) {
				result += op_stack.top();
				op_stack.pop();
				op_stack.push(c);
			}

			//������ top�� level_op���� ������ -> push
			if (level_op(c) > level_op(op_stack.top())) {
				op_stack.push(c);
				continue;
			}
		}
	}

	cout << result << endl;

}
	
	
