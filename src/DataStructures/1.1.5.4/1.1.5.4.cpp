#include <iostream>
#include <cstdlib>

using namespace std;

int findSmallestPosition(double list[], int startPosition, int listLength)
{
	int smallestPosition = startPosition;

	for (int i = startPosition; i < listLength; i++)
	{
		if (list[i] < list[smallestPosition])
			smallestPosition = i;
	}
	return smallestPosition;
}

void selectionSort(double list[], int listLength)
{
	for (int i = 0; i < listLength; i++)
	{
		int smallestPosition = findSmallestPosition(list, i, listLength);
		swap(list[i], list[smallestPosition]);
	}
	return;
}

int main()
{
	setlocale(LC_ALL, "rus");

	int n = 10;
	double A[10];
	A[0] = 1.1;
	A[1] = 12.5;
	A[2] = 1.3;
	A[3] = 4.6;
	A[4] = 3.9;
	A[5] = 8.5;
	A[6] = 7.1;
	A[7] = 2.2;
	A[8] = 0.3;
	A[9] = 4.4;
	double* Array = new double[n];
	for (int i = 0; i < n; i++)
	{
		Array[i] = A[i];
	}
	for (int i = 0; i < n; i++)
	{
		cout << Array[i];
		cout << " ; ";
	}
	cout << '\n';
	selectionSort(Array, n);

	for (int i = 0; i < n; i++)
	{
		cout << Array[i];
		cout << " ; ";
	}

	delete[] Array;
	return 0;
}