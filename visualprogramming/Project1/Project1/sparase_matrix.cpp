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



void three_element_arr(int arr[][8], int row,int col) {//받는 값 : arr=> 희소행렬, row=> 희소행렬의 행, col => 희소행렬의 열
	int three_arr[7][3] = { {15,8,6},{},{},{},{},{},{} };
	// three_arr[0][0],[0][1],[0][2] 열을 기본정보로 채움
	// 다음 채워야할 값은 [1][0] 이다. 



	//희소행렬을 탐색하면서 값이 0이 아닌 값을 찾는다.그리고 그 값을 3원소 표기법이 적용되는 2차원 배열에 넣는다.
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (arr[i][j] != 0) {
				three_arr[i+1][0] = i;	
				three_arr[i+1][1] = j;
				three_arr[i+1][2] = arr[i][j];
			}
		}
	}

	//출력문
	output(three_arr);
}




int main() {
	int sp_arr[15][8] = {};	//0으로 초기화
	int** three_arr = new int* [7];
	//임의의 희소행렬 등록
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
	//일단 함수 안쓰고 3원소 배열 만들기
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


	//3원소 표기법 읽기 및 출력
	//three_element_arr(sp_arr, 15, 8);
	
	
	




}