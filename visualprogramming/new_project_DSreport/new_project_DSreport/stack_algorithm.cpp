#include <iostream>
#include <string>
#include <stack>//stack STL(표준 라이브러리) 사용

using namespace std;


void char_printing(stack<char> str) {//스택 출력 함수
	while (!str.empty()) {//empty가 비게 된다면 1을 반환하며, while 조건이 거짓이 되어 조건문이 멈춘다.
		cout << str.top() << "  ";//top()이 자료구조에서 peek()와 같은 기능
		str.pop();
	}
}


stack<char> sort_printing(stack<char> str) {//스택을 배열로 정방향 정렬하는 알고리즘(중위표기식)
	char first, second, temp;
	int s_size=str.size();
	

	
	return str;

}

void postfix_printing(stack<char> str) {//후위 수식 표기
	stack<char> new_stack;
	int first=48, second=48;//아스키코드 0이 48로 책정 char 문자에서 0을 빼면 그대로의 값을 내려고함

	while (!str.empty()) {//항목탐색
		if (((int)str.top() >= 48) && ((int)str.top() <= 57)) {//int로 강제 형변환-> 아스키코드로?
			new_stack.push(str.top());
			str.pop();
		}
		if ((str.top() == 42 || str.top() == 43 || str.top() == 45 || str.top() == 47)) {//자동형변환!
			;
		}



	}
}



void postfix_calc(stack<char> str) {//후위 수식 계산알고리즘
	stack<char> only_number;//오직 숫자만 담을 스택하나 생성
	
	while (!str.empty()) {
		//아스키코드의 숫자 문자값은 48-> 0부터 57-> 9까지이다. 
		if ((str.top() >= 48) || (str.top() <= 57)) {
			only_number.push(str.top());//해당 값을 push 한다.
			str.pop();//그리고 그 값은 str에서 뺴내는 느낌으로 pop한다!
		}
		

	}
}



void Bracket_checking(stack<char> str) {
	//stack<char> bracket_check;//괄호 검사용 스택
	//char* temp;

}//괄호 검사 함수(미구현)


int main(void) {
	stack<char> first_stack;//연산식을 담을 최초의 스택
	stack<char> infix_stack;
	char operating_num;// 스택에 연산식을 담을 변수

	cout << "연산식을 작성하시오(한 자리수, p를 입력받을 시 입력종료,끝자리는 숫자여야합니다.)>>" << endl<<">>";
	cout << endl;

	while (true) {
		cin >> operating_num;
		if (operating_num == 'p') {
			break;
		}
		first_stack.push(operating_num);
	}
	cout << "스택에 있는것 그대로 출력>>  ";
	char_printing(first_stack);
	cout << endl;

	cout << "중위 표기식 출력 >>  "; 
	sort_printing(first_stack);

	cout << "후위 표기식 출력 >> ";

	
}