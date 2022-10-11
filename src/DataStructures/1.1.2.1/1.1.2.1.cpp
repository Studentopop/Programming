
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

	//TODO: ������ � ����������+
	int maximumSize = 40;
	int minimumSize = 20;
	int size = 10;
	int randomDigits[10] = {};

	for (int i = 0; i < size; i++)
	{
		//TODO: ���������� �����+
		randomDigits[i] = rand() % maximumSize - minimumSize;
	}


	cout << endl << "������ c ������� o� -20 �� 20: " << endl;
	for (int i = 0; i < size; i++)
	{
		cout << randomDigits[i] << " ";
	}
	cout << '\n';


	selectionSort(randomDigits, size);

	cout << "Sorted array ..." << endl;
	for (int i = 0; i < size; i++)
		cout << randomDigits[i] << " ";
	cout << endl;


	return 0;
}