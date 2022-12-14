#include <iostream>
const int ROW = 15;
const int COL= 8;
using namespace std;

typedef int(*arrpointer)[3];
// 배열 포인터를 이용해 2차원 배열을 리턴 받음
// 배열 포인터 = 포인터에 배열의 주소를 저장-> 포인터에 배열의 주소들을 저장함으로써 
// 포인터 배열 = 포인터를 배열에 저장함

arrpointer three_element_arr(int arr[][8], int row, int col) {
	int temp; // 배열을 치환하기 위한 임시 방편 변수
	int count = 1;//count=1로 시작하여 첫 행 [0]에 간섭없이 하기 위해 넣었음.
	static int three_arr[7][3] = { {15,8,6},{},{},{},{},{},{} }; //해당 함수를 벗어나면 해당 배열은 날아감
	// new나 malloc 으로 선언 가능!
	//new로 선언?

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (arr[i][j] != 0) {
				three_arr[count][0] = i;
				three_arr[count][1] = j;

				//여기서 핵심-> 배열을 치환하는 방식
				// 치환하지않으면 오버플로 오류?
				temp = arr[i][j];
				arr[i][j] = three_arr[count][2];
				three_arr[count][2] = temp;
				count++;
			}
		}
	}
	return three_arr;//완성된 3원소 행렬 리턴

}

arrpointer trans_three_element_arr(int arr[][COL], int row, int col, int ex_arr[][3]) {
	int temp; // 배열을 치환하기 위한 임시 방편 변수
	int count = 1;//count=1로 시작하여 첫 행 [0]에 간섭없이 하기 위해 넣었음.
	//static int three_arr[7][3] = { {15,8,6},{},{},{},{},{},{} }; //해당 함수를 벗어나면 해당 배열은 날아감
	// new나 malloc 으로 선언 가능!
	//new로 선언?

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

//기본 행렬 출력 함수
void printing_default(int arr[][COL],int row) {

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < 8; j++) {
			cout << arr[i][j] << "\t";
		}
		cout << endl;
	}
}

//전치 행렬 출력 함수

void printing_trans(int** arr, int row, int col) {
	
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout << arr[i][j] << "\t";
		}
		cout << endl;
	}
}


//3원소표기 출력 함수
void printing_three(int arr[][3],int row) {
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < 3; j++) {
			cout << arr[i][j] << "\t";
		}
		cout << endl;
	}
}

//int **로 표기가능!!!! -->> 이 방식으로 차원을 모르는 이차원 배열을 선정할 수 있음!!!
int** trans_arr_make(int row, int col,int value,int trans_three_main_arr[][3]) {
	//C++에서 2차원 배열 동적할당 방법
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

	int sp_arr[ROW][COL] = {};	//15x8 배열을 생성

	//임의의 희소행렬 등록, 배열을 입력받음!(출력과 희소행렬 입력을 함수로)
	cout << "========희소행렬 표시========" << endl;
	input_sparr(sp_arr, ROW);// 희소행렬 입력을 함수로 
	printing_default(sp_arr,ROW);// 출력 함수
	cout << endl;// 줄바꿈


	//3원소 행렬을 메인에서 입력받음!
	int(*three_main_arr)[3] = three_element_arr(sp_arr, 15, 8);
	cout << "========해당 희소행렬의 3원소 표기법========" << endl;
	printing_three(three_main_arr, 7);
	cout << endl;// 줄바꿈



	//==========전치행렬 만들기============
	//3원소행렬을 먼저 전치하여서 전치행렬 만들기!
	int(*trans_three_main_arr)[3] = trans_three_element_arr(sp_arr, 15, 8, three_main_arr);
	cout << endl;

	//동적할당으로 3원소 행렬 배열을 원 행렬로 복귀시키기
	// -> 전치행렬 trans_arr[0][0]-> 전치행렬의 행, trans_arr[0][1]-> 전치행렬의 열로 설정
	// trans_arr[count][0] -> 전치행렬 행(row)값
	// trans_arr[count][1] -> 전치행렬의 열(col)값
	// trans_arr[count][2] -> 전치행렬 row,col에 대응하는 행렬값
	int row = trans_three_main_arr[0][0]; //8이 됨!(전치되어서)
	int col = trans_three_main_arr[0][1]; //15가 됨!(전치되어서!)
	int value = trans_three_main_arr[0][2]; // 값 개수!

	//전치된 3원소행렬 출력 구문!

	cout << "======전치된 희소행렬의 3원소 표기법========" << endl;
	printing_three(trans_three_main_arr, 7);
	cout << endl;

	//전치행렬 구현(생성)
	int** trans_arr{};

	trans_arr=trans_arr_make(row, col,value,trans_three_main_arr);

	cout << "========전치된 희소행렬 표시========" << endl;

	printing_trans(trans_arr, row, col);
	

	//해제까지 해줘야 함!
	for (int i = 0; i < row; i++) {
		delete[] trans_arr[i];//행단위로 해제

	}
	delete[] trans_arr;//마지막 행도 해제
	
}