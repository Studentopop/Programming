#include <iostream>
#include <ctime>
using namespace std;

int main() {

	int n;
	n = 5;
	double A[10];
	A[0] = 11.2;
	A[1] = 7.6;
	A[2] = 3.1;
	A[3] = -9;
	A[4] = 81.2;

	double* Array = new double[n];
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