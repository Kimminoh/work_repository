#include <iostream>
#include <string>
#include <stack>//stack STL(ǥ�� ���̺귯��) ���
#include <vector>
using namespace std;


void char_printing(stack<char> str) {
	while (!str.empty()) {//empty�� ��� �ȴٸ� 1�� ��ȯ�ϸ�, while ������ ������ �Ǿ� ���ǹ��� �����.
		cout << str.top() << "\t";//top()�� �ڷᱸ������ peek()�� ���� ���
		str.pop();
	}
}


char* sort_printing(stack<char> str) {//������ �迭�� ������ �����ϴ� �˰���
	int arr_size=str.size();
	char* sort_arr = new char[arr_size];

	for (int i=0;!str.empty();i++) {
		sort_arr[(arr_size-1) - i] = str.top();
		str.pop();
	}

	for (int i = 0; i < arr_size; i++) {
		cout<<sort_arr[i] << "\t";
	}
	cout << endl;

	return sort_arr;
}

void Bracket_checking(stack<char> str) {
	stack<char> bracket_check;//��ȣ �˻�� ����
	char * temp;

	temp = sort_printing(str);
	



	for (int i = 0; i < str.size(); i++) {
		if (str.top() == '(' || str.top() == '[' || str.top() == '{') {
			temp = str.top();//temp�� ��ȣ�� �ް�
			str.pop();// �ش� �κ��� pop
			bracket_check.push(temp);
		}



		else
			str.pop();
	}

}


int main(void) {
	stack<char> S;
	char operating_num;
	char* temp;

	cout << "������� �ۼ��Ͻÿ�(�� �ڸ���, p�� �Է¹��� �� �Է�����,���ڸ��� ���ڿ����մϴ�.)>>";
	cout << endl;
	while (true) {
		cin >> operating_num;
		if (operating_num == 'p') {
			break;
		}
		S.push(operating_num);


	}

	//char_printing(S);
	temp=sort_printing(S);
	
	cout << temp << endl;


}