#include <iostream>
using namespace std;


//추가할 내용
// 모든 부분 함수화 시키기!


typedef int(*arrpointer)[3];
// 배열 포인터를 이용해 2차원 배열을 리턴 받음
// 배열 포인터 = 포인터에 배열의 주소를 저장-> 포인터에 배열의 주소들을 저장함으로써 
// 포인터 배열 = 포인터를 배열에 저장함

arrpointer input_arr() {
	int row, col;
	cout << "행과 열을 입력하시오.>>";
	cin >> row >> col;

	//기본적인 행과 열을 등록하는 방식
	int** default_arr = new int* [row];
	for (int i = 0; i < row; i++) {
		default_arr[i] = new int[col];
	}
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			default_arr[i][j] = 0;
		}
	}

	//3원소 행렬 출력 (먼저 출력!)
	



	

	// 기본행렬 출력 !
	cout << "기본 행렬을 출력(전부 0으로 된 행렬 출력)";

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout << default_arr[i][j]<<"\t";
		}
		cout << endl;
	}
	
}


arrpointer three_element_arr(int arr[][8], int row, int col) {
	int temp; // 배열을 치환하기 위한 임시 방편 변수
	int count = 1;//count=1로 시작하여 첫 행 [0]에 간섭없이 하기 위해 넣었음.
	static int three_arr[7][3] = { {15,8,6},{},{},{},{},{},{} }; //해당 함수를 벗어나면 해당 배열은 날아감, 그래서 static으로 선언
	// new나 malloc 으로 선언 가능!
	//new로 선언?

	for (int i = 0; i < 15; i++) {
		for (int j = 0; j < 8; j++) {
			if (arr[i][j] != 0) {
				three_arr[count][0] = i;
				three_arr[count][1] = j;

				//여기서 핵심-> 배열을 치환하는 방식
				// 치환하지않으면 오버플로 오류?
				temp = arr[i][j];
				arr[i][j] = three_arr[count][2];
				three_arr[count][2] = temp;

				count++;
				break;	// break를 넣지않으면 반복 오류?
			}
		}
	}
	return three_arr;

}


arrpointer trans_three_element_arr(int arr[][8], int row, int col,int ex_arr[][3]) {
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

	int sp_arr[][] =input_arr();	//0으로 초기화 15x8 배열을
	//임의의 희소행렬 등록
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

	cout << endl;// 줄바꿈

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


	//동적할당으로 3원소 행렬 배열을 원 행렬로 복귀시키기
	// -> 전치행렬 trans_arr[0][0]-> 전치행렬의 행, trans_arr[0][1]-> 전치행렬의 열로 설정
	int row = trans_three_main_arr[0][0];
	int col = trans_three_main_arr[0][1];
	int value = trans_three_main_arr[0][2]; // 해당 값은 값 치환 때 사용
	
	//C++에서 2차원 배열 동적할당 방법
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


	// 전치 행렬 출력알고리즘 : 3원소 행렬 배열에서 i, j를 따와서 배열을 치환한다.
	// 초기작업 
	
	
	
	
	
	// trans_arr[count][0] -> 전치행렬 행(row)값
	// trans_arr[count][1] -> 전치행렬의 열(col)값
	// trans_arr[count][2] -> 전치행렬 row,col에 대응하는 행렬값

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
	


	//해제까지 해줘야 함!
	for (int i = 0; i < row; i++) {
		delete[] trans_arr[i];//행단위로 해제

	}

	delete[] trans_arr;//마지막 행도 해제

}