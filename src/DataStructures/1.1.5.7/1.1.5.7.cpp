#include<iostream>
#include <time.h>

using namespace std;


int* MakeRandomArray(int arraySize)
{
	//TODO: � ��������� �����+
	int* array = new int[arraySize];
	for (int i = 0; i < arraySize; i++)
	{
		//TODO: ���������� �����+
		array[i] =  rand() % (101);
	}

	for (int i = 0; i < arraySize; i++)
	{
		cout << array[i];
		cout << " ";
	}
	delete[] Array;
	return 0;
}

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
