#include <iostream>
using namespace std;


void output(int arr[7][3]) {
	for (int i = 0; i < 7; i++) {
		for (int j = 0;j < 3; j++) {
			cout << arr[i][j] + "\t";
		}
		cout << endl;
	}
}



void three_element_arr(int arr[][8], int row,int col) {//�޴� �� : arr=> ������, row=> �������� ��, col => �������� ��
	int three_arr[7][3] = { {15,8,6},{},{},{},{},{},{} };
	// three_arr[0][0],[0][1],[0][2] ���� �⺻������ ä��
	// ���� ä������ ���� [1][0] �̴�. 



	//�������� Ž���ϸ鼭 ���� 0�� �ƴ� ���� ã�´�.�׸��� �� ���� 3���� ǥ����� ����Ǵ� 2���� �迭�� �ִ´�.
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (arr[i][j] != 0) {
				three_arr[i+1][0] = i;	
				three_arr[i+1][1] = j;
				three_arr[i+1][2] = arr[i][j];
			}
		}
	}

	//��¹�
	output(three_arr);
}




int main() {
	int sp_arr[15][8] = {};	//0���� �ʱ�ȭ
	int** three_arr = new int* [7];
	//������ ������ ���
	sp_arr[0][0] = 20;
	sp_arr[2][7] = 1;
	sp_arr[3][1] = 7;
	sp_arr[6][4] = -1;
	sp_arr[10][3] = 50;
	sp_arr[13][6] = -9;


	for (int i = 0; i < 15; i++) {
		for (int j = 0; j < 8; j++) {
			cout << sp_arr[i][j]<<"\t";
		}
		cout << endl;
		
	}

	cout << endl;
	//�ϴ� �Լ� �Ⱦ��� 3���� �迭 �����
	for (int i = 1; i <= 15; i++) {
		for (int j = 0; j < 8; j++) {
			if (sp_arr[i][j] != 0) {
				three_arr[i][0] = i;
				three_arr[i][1] = j;
				three_arr[i][2] = sp_arr[i][j];
			}
		}
	}

	for (int i = 0; i < 7; i++) {
		for (int j = 0; j < 3; j++) {
			cout << three_arr[i][j] << "\t";
		}
		cout << endl;
	}


	//3���� ǥ��� �б� �� ���
	//three_element_arr(sp_arr, 15, 8);
	
	
	




}