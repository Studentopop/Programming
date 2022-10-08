#include<iostream>
using namespace std;

int main()
{

	int n;
	n = 5;
	bool A[10];
	A[0] = true;
	A[1] = false;
	A[2] = true;
	A[3] = false;
	A[4] = true;
	bool* Array = new bool[n];
	for (int i = 0; i < n; i++)
	{
		Array[i] = A[i];
	}
	for (int i = 0; i < n; i++)
	{
		cout << Array[i];
		cout << '\n';
	}
	delete[] Array;
	return 0;
}