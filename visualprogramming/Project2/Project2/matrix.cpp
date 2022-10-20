#include <iostream>
using namespace std;


//�߰��� ����
// ��� �κ� �Լ�ȭ ��Ű��!


typedef int(*arrpointer)[3];
// �迭 �����͸� �̿��� 2���� �迭�� ���� ����
// �迭 ������ = �����Ϳ� �迭�� �ּҸ� ����-> �����Ϳ� �迭�� �ּҵ��� ���������ν� 
// ������ �迭 = �����͸� �迭�� ������

arrpointer input_arr() {
	int row, col;
	cout << "��� ���� �Է��Ͻÿ�.>>";
	cin >> row >> col;

	//�⺻���� ��� ���� ����ϴ� ���
	int** default_arr = new int* [row];
	for (int i = 0; i < row; i++) {
		default_arr[i] = new int[col];
	}
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			default_arr[i][j] = 0;
		}
	}

	//3���� ��� ��� (���� ���!)
	



	

	// �⺻��� ��� !
	cout << "�⺻ ����� ���(���� 0���� �� ��� ���)";

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout << default_arr[i][j]<<"\t";
		}
		cout << endl;
	}
	
}


arrpointer three_element_arr(int arr[][8], int row, int col) {
	int temp; // �迭�� ġȯ�ϱ� ���� �ӽ� ���� ����
	int count = 1;//count=1�� �����Ͽ� ù �� [0]�� �������� �ϱ� ���� �־���.
	static int three_arr[7][3] = { {15,8,6},{},{},{},{},{},{} }; //�ش� �Լ��� ����� �ش� �迭�� ���ư�, �׷��� static���� ����
	// new�� malloc ���� ���� ����!
	//new�� ����?

	for (int i = 0; i < 15; i++) {
		for (int j = 0; j < 8; j++) {
			if (arr[i][j] != 0) {
				three_arr[count][0] = i;
				three_arr[count][1] = j;

				//���⼭ �ٽ�-> �迭�� ġȯ�ϴ� ���
				// ġȯ���������� �����÷� ����?
				temp = arr[i][j];
				arr[i][j] = three_arr[count][2];
				three_arr[count][2] = temp;

				count++;
				break;	// break�� ���������� �ݺ� ����?
			}
		}
	}
	return three_arr;

}


arrpointer trans_three_element_arr(int arr[][8], int row, int col,int ex_arr[][3]) {
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
	


	for (int i = 0; i < 15; i++) {
		for (int j = 0; j < 8; j++) {
			if (arr[i][j] != 0) {
				temp = arr[i][j];
				arr[i][j] = ex_arr[count][2];
				ex_arr[count][2] = temp;
				count++;
				break;
			}
		}
	}
	return ex_arr;

}




int main(void) {

	int sp_arr[][] =input_arr();	//0���� �ʱ�ȭ 15x8 �迭��
	//������ ������ ���
	sp_arr[0][0] = 20;
	sp_arr[2][7] = 1;
	sp_arr[3][1] = 7;
	sp_arr[6][4] = -1;
	sp_arr[10][3] = 50;
	sp_arr[13][6] = -9;

	for (int i = 0; i < 15; i++) {
		for (int j = 0; j < 8; j++) {
			cout << sp_arr[i][j] << "\t";
		}
		cout << endl;
	}

	cout << endl;// �ٹٲ�

	int (*three_main_arr)[3] = three_element_arr(sp_arr, 15, 8);

	cout << endl;




	for (int i = 0; i < 7; i++) {
		for (int j = 0; j < 3; j++) {
			cout << three_main_arr[i][j] << "\t";
		}
		cout << endl;
	}

	int(*trans_three_main_arr)[3] = trans_three_element_arr(sp_arr, 15, 8,three_main_arr);

	cout << endl;
	for (int i = 0; i < 7; i++) {
		for (int j = 0; j < 3; j++) {
			cout << trans_three_main_arr[i][j] << "\t";
		}
		cout << endl;
	}

	cout << endl;


	//�����Ҵ����� 3���� ��� �迭�� �� ��ķ� ���ͽ�Ű��
	// -> ��ġ��� trans_arr[0][0]-> ��ġ����� ��, trans_arr[0][1]-> ��ġ����� ���� ����
	int row = trans_three_main_arr[0][0];
	int col = trans_three_main_arr[0][1];
	int value = trans_three_main_arr[0][2]; // �ش� ���� �� ġȯ �� ���
	
	//C++���� 2���� �迭 �����Ҵ� ���
	int** trans_arr = new int* [row];
	for (int i = 0; i < row; i++) {
		trans_arr[i] = new int[col];
	}
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			trans_arr[i][j] = 0;
		}
	}
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout << trans_arr[i][j]<<"\t";
		}
		cout << endl;
	}


	// ��ġ ��� ��¾˰��� : 3���� ��� �迭���� i, j�� ���ͼ� �迭�� ġȯ�Ѵ�.
	// �ʱ��۾� 
	
	
	
	
	
	// trans_arr[count][0] -> ��ġ��� ��(row)��
	// trans_arr[count][1] -> ��ġ����� ��(col)��
	// trans_arr[count][2] -> ��ġ��� row,col�� �����ϴ� ��İ�

	int trans_row, trans_col, trans_value;

	for (int i = 1; i <= value; i++) {
		trans_row = trans_three_main_arr[i][0];
		trans_col = trans_three_main_arr[i][1];
		trans_value = trans_three_main_arr[i][2];

		trans_arr[trans_row][trans_col] = trans_value;

		
	}
	cout << endl;
	cout << endl;

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout << trans_arr[i][j] << "\t";
		}
		cout << endl;
	}
	


	//�������� ����� ��!
	for (int i = 0; i < row; i++) {
		delete[] trans_arr[i];//������� ����

	}

	delete[] trans_arr;//������ �൵ ����

}