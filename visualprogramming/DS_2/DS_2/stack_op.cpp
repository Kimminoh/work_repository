#include <iostream>
using namespace std;

template <class T>
class stack {
	int top;
	T data[];//일단 임의로 지정
public:
	
	stack();
	void push(T element);
	T pop();
	int size() { return top + 1; }//현재 스택의 크기를 알 수 있는 함수
};

template <class T>
stack<T>::stack() {
	top = -1;//스택이 초기에 비어있음을 뜻
}

template<class T>
void stack<T>::push(T element) {
	if (top == 10) {
		cout << "스택이 가득참" << endl;//is_full 처리
		
	}
	top++;
	data[top] = element;
}

template <class T>
T stack<T>::pop() {
	T pop_data;
	if (top == -1) {
		cout << "스택이 비었음" << endl;//is_empty()처리
		return 0; //오류표기와 연결
	}
	pop_data = data[top--];
	return pop_data;
}

template <class T>






int main(void) {
	stack<char> *p=new stack<char>();


	p->push('o');
	p->push('+');
	cout << p->pop() << endl;
	cout << p->pop() << endl;
	delete p;
}