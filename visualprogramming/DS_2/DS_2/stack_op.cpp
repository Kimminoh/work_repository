#include <iostream>
using namespace std;

template <class T>
class stack {
	int top;
	T data[];//�ϴ� ���Ƿ� ����
public:
	
	stack();
	void push(T element);
	T pop();
	int size() { return top + 1; }//���� ������ ũ�⸦ �� �� �ִ� �Լ�
};

template <class T>
stack<T>::stack() {
	top = -1;//������ �ʱ⿡ ��������� ��
}

template<class T>
void stack<T>::push(T element) {
	if (top == 10) {
		cout << "������ ������" << endl;//is_full ó��
		
	}
	top++;
	data[top] = element;
}

template <class T>
T stack<T>::pop() {
	T pop_data;
	if (top == -1) {
		cout << "������ �����" << endl;//is_empty()ó��
		return 0; //����ǥ��� ����
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