
	//1.1.2.1
#include <iostream>
#include <cstdlib>

	using namespace std;

int findSmallestPosition(int list[], int startPosition, int listLength)
{
	int smallestPosition = startPosition;

	for (int i = startPosition; i < listLength; i++)
	{
		if (list[i] < list[smallestPosition])
			smallestPosition = i;
	}
	return smallestPosition;
}

void selectionSort(int list[], int listLength)
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

	int randomDigits[10] = {};

	for (int i = 0; i < 10; i++)
	{
		randomDigits[i] = rand() % 40 - 20;
	}


	cout << endl << "Массив c числами oт -20 до 20: " << endl;
	for (int i = 0; i < 10; i++)
	{
		cout << randomDigits[i] << " ";
	}
	cout << '\n';


	selectionSort(randomDigits, 10);

	cout << "Sorted array ..." << endl;
	for (int i = 0; i < 10; i++)
		cout << randomDigits[i] << " ";
	cout << endl;


	return 0;
}