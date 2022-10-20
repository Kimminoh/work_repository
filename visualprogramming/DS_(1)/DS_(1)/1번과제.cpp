#include <iostream>
const int ROW = 15;
const int COL= 8;
using namespace std;

typedef int(*arrpointer)[3];
// �迭 �����͸� �̿��� 2���� �迭�� ���� ����
// �迭 ������ = �����Ϳ� �迭�� �ּҸ� ����-> �����Ϳ� �迭�� �ּҵ��� ���������ν� 
// ������ �迭 = �����͸� �迭�� ������

arrpointer three_element_arr(int arr[][8], int row, int col) {
	int temp; // �迭�� ġȯ�ϱ� ���� �ӽ� ���� ����
	int count = 1;//count=1�� �����Ͽ� ù �� [0]�� �������� �ϱ� ���� �־���.
	static int three_arr[7][3] = { {15,8,6},{},{},{},{},{},{} }; //�ش� �Լ��� ����� �ش� �迭�� ���ư�
	// new�� malloc ���� ���� ����!
	//new�� ����?

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (arr[i][j] != 0) {
				three_arr[count][0] = i;
				three_arr[count][1] = j;

				//���⼭ �ٽ�-> �迭�� ġȯ�ϴ� ���
				// ġȯ���������� �����÷� ����?
				temp = arr[i][j];
				arr[i][j] = three_arr[count][2];
				three_arr[count][2] = temp;
				count++;
			}
		}
	}
	return three_arr;//�ϼ��� 3���� ��� ����

}

arrpointer trans_three_element_arr(int arr[][COL], int row, int col, int ex_arr[][3]) {
	int temp; // �迭�� ġȯ�ϱ� ���� �ӽ� ���� ����
	int count = 1;//count=1�� �����Ͽ� ù �� [0]�� �������� �ϱ� ���� �־���.
	//static int three_arr[7][3] = { {15,8,6},{},{},{},{},{},{} }; //�ش� �Լ��� ����� �ش� �迭�� ���ư�
	// new�� malloc ���� ���� ����!
	//new�� ����?

	for (int i = 0; i < 7; i++) {
		temp = ex_arr[i][0];
		ex_arr[i][0] = ex_arr[i][1];
		ex_arr[i][1] = temp;
	}

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (arr[i][j] != 0) {
				temp = arr[i][j];
				arr[i][j] = ex_arr[count][2];
				ex_arr[count][2] = temp;
				count++;
			}
		}
	}
	return ex_arr;

}

void input_sparr(int arr[][COL], int row) {
	arr[0][0] = 20;
	arr[2][7] = 1;
	arr[3][1] = 7;
	arr[6][4] = -1;
	arr[10][3] = 50;
	arr[13][6] = -9;
}

//�⺻ ��� ��� �Լ�
void printing_default(int arr[][COL],int row) {

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < 8; j++) {
			cout << arr[i][j] << "\t";
		}
		cout << endl;
	}
}

//��ġ ��� ��� �Լ�

void printing_trans(int** arr, int row, int col) {
	
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout << arr[i][j] << "\t";
		}
		cout << endl;
	}
}


//3����ǥ�� ��� �Լ�
void printing_three(int arr[][3],int row) {
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < 3; j++) {
			cout << arr[i][j] << "\t";
		}
		cout << endl;
	}
}

//int **�� ǥ�Ⱑ��!!!! -->> �� ������� ������ �𸣴� ������ �迭�� ������ �� ����!!!
int** trans_arr_make(int row, int col,int value,int trans_three_main_arr[][3]) {
	//C++���� 2���� �迭 �����Ҵ� ���
	int **trans_arr = new int* [row];
	for (int i = 0; i < row; i++) {
		trans_arr[i] = new int[col];
	}
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			trans_arr[i][j] = 0;
		}
	}

	int trans_row, trans_col, trans_value;

	for (int i = 1; i <= value; i++) {
		trans_row = trans_three_main_arr[i][0];
		trans_col = trans_three_main_arr[i][1];
		trans_value = trans_three_main_arr[i][2];

		trans_arr[trans_row][trans_col] = trans_value;


	}
	cout << endl;
	cout << endl;


	return trans_arr;

}


int main(void) {

	int sp_arr[ROW][COL] = {};	//15x8 �迭�� ����

	//������ ������ ���, �迭�� �Է¹���!(��°� ������ �Է��� �Լ���)
	cout << "========������ ǥ��========" << endl;
	input_sparr(sp_arr, ROW);// ������ �Է��� �Լ��� 
	printing_default(sp_arr,ROW);// ��� �Լ�
	cout << endl;// �ٹٲ�


	//3���� ����� ���ο��� �Է¹���!
	int(*three_main_arr)[3] = three_element_arr(sp_arr, 15, 8);
	cout << "========�ش� �������� 3���� ǥ���========" << endl;
	printing_three(three_main_arr, 7);
	cout << endl;// �ٹٲ�



	//==========��ġ��� �����============
	//3��������� ���� ��ġ�Ͽ��� ��ġ��� �����!
	int(*trans_three_main_arr)[3] = trans_three_element_arr(sp_arr, 15, 8, three_main_arr);
	cout << endl;

	//�����Ҵ����� 3���� ��� �迭�� �� ��ķ� ���ͽ�Ű��
	// -> ��ġ��� trans_arr[0][0]-> ��ġ����� ��, trans_arr[0][1]-> ��ġ����� ���� ����
	// trans_arr[count][0] -> ��ġ��� ��(row)��
	// trans_arr[count][1] -> ��ġ����� ��(col)��
	// trans_arr[count][2] -> ��ġ��� row,col�� �����ϴ� ��İ�
	int row = trans_three_main_arr[0][0]; //8�� ��!(��ġ�Ǿ)
	int col = trans_three_main_arr[0][1]; //15�� ��!(��ġ�Ǿ!)
	int value = trans_three_main_arr[0][2]; // �� ����!

	//��ġ�� 3������� ��� ����!

	cout << "======��ġ�� �������� 3���� ǥ���========" << endl;
	printing_three(trans_three_main_arr, 7);
	cout << endl;

	//��ġ��� ����(����)
	int** trans_arr{};

	trans_arr=trans_arr_make(row, col,value,trans_three_main_arr);

	cout << "========��ġ�� ������ ǥ��========" << endl;

	printing_trans(trans_arr, row, col);
	

	//�������� ����� ��!
	for (int i = 0; i < row; i++) {
		delete[] trans_arr[i];//������� ����

	}
	delete[] trans_arr;//������ �൵ ����
	
}