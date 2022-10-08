#include<iostream>
#include <time.h>

using namespace std;

int* MakeRandomArray(int);

int main()
{
	srand(time(NULL));

	MakeRandomArray(5);
	cout << '\n';
	MakeRandomArray(8);
	cout << '\n';
	MakeRandomArray(13);
	cout << '\n';
	return 0;
}

int* MakeRandomArray(int arraySize)
{
	int* Array = new int[arraySize];
	for (int i = 0; i < arraySize; i++)
	{
		Array[i] = 0 + rand() % (100 - 0 + 1);
	}
	for (int i = 0; i < arraySize; i++)
	{
		cout << Array[i];
		cout << " ";
	}
	return 0;
}