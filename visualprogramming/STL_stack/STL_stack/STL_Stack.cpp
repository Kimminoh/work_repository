#include <iostream>
#include <string>
#include <stack>//stack STL(표준 라이브러리) 사용
#include <vector>
using namespace std;


void char_printing(stack<char> str) {
	while (!str.empty()) {//empty가 비게 된다면 1을 반환하며, while 조건이 거짓이 되어 조건문이 멈춘다.
		cout << str.top() << "\t";//top()이 자료구조에서 peek()와 같은 기능
		str.pop();
	}
}


char* sort_printing(stack<char> str) {//스택을 배열로 정방향 정렬하는 알고리즘
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
	stack<char> bracket_check;//괄호 검사용 스택
	char * temp;

	temp = sort_printing(str);
	



	for (int i = 0; i < str.size(); i++) {
		if (str.top() == '(' || str.top() == '[' || str.top() == '{') {
			temp = str.top();//temp는 괄호를 받고
			str.pop();// 해당 부분은 pop
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

	cout << "연산식을 작성하시오(한 자리수, p를 입력받을 시 입력종료,끝자리는 숫자여야합니다.)>>";
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