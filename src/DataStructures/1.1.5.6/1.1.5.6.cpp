#include<iostream>
using namespace std;

int main()
{
	int n = 15;
	char A[15];
	A[0] = '3';
	A[1] = '2';
	A[2] = '7';
	A[3] = 'a';
	A[4] = '*';
	A[5] = 'b';
	A[6] = '0';
	A[7] = '-';
	A[8] = '3';
	A[9] = 'c';
	A[10] = 'v';
	A[11] = 'd';
	A[12] = '3';
	A[13] = 'b';
	A[14] = 'n';
	char* Array = new char[n];
	for (int i = 0; i < n; i++)
	{
		Array[i] = A[i];
	}
	cout << "Char array is: " << endl;
	for (int j = 0; j < n; j++)
	{
		cout << Array[j] << ' ';
	}
	cout << '\n';
	cout << "Letters in array: " << endl;
	for (int l = 0; l < 15; l++)
	{
		if (Array[l] >= 'a' and Array[l] <= 'z')
		{
			cout << Array[l] << ' ';
		}
	}
	delete[] Array;
	return 0;
}