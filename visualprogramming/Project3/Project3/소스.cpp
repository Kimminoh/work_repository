#include <iostream>
#include <string>//string객체를 이용함
#include <stack>//stack STL을 이용함
using namespace std;

//연산자의 우선순위를 정하는 함수-> 1이면 +,- , 2이면 *와 /, 0이면 그 외의 모든 연산들
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
	string input;//문자열로 표기식을 받는다.
	string result;//결과를 받을 문자열 

	char c;
	stack<char> num_stack;
	stack<char> op_stack;
	int pro;

	op_stack.push('0');//임의의값을 넣어 빈 상태 x



	cout << "연산식을 입력하세요>>";
	cin >> input;

	for (int i = 0; i < input.length(); i++) {//i를 배열처럼!string객체를 이용
		c = input[i];//한글자씩 검사


		//1. 피연산자를 만났을때
		if (c >= '0' && c <= '9') {
			result += c;//바로 출력부분으로 넘김
			continue;// 해당 continue문을 만나는 순간 다음 반복 진행
		}


		//2. 연산자를 만났을 때
		if (c == '+' || c == '-' || c == '*' || c == '/') {
			if (!op_stack.empty()) {
				op_stack.push(c);//op_stack이 처음이라면 바로 push
				
			}
			// 스택의 top이 level_op보다 크면-> pop 반복 후 push
			if (level_op(c) <= level_op(op_stack.top())) {
				result += op_stack.top();
				op_stack.pop();
				op_stack.push(c);
			}

			//스택의 top이 level_op보다 작으면 -> push
			if (level_op(c) > level_op(op_stack.top())) {
				op_stack.push(c);
				continue;
			}
		}
	}

	cout << result << endl;

}
	
	
