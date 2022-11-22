//DynamicArray
#include <iostream>
#include "DynamicArray.h"

using namespace std;


void initMassiv(Arr* arr)
{

	cout << "������� �������� ����� �������: ";
	cin >> arr->length;
	arr->capacity = arr->length;
	cout << "������� ������� ���������� : " << arr->capacity << endl;
	arr->array = new int[arr->capacity];

	for (int i = 0; i < arr->capacity; i++)
	{
		arr->array[i] = rand() % 100;
	}
}

void showMassiv(Arr* arr)
{
	for (int i = 0; i < arr->length; i++)
	{
		cout << "�������� �������[" << i << "] ��� : " << arr->array[i] << "\n";
	}
}

void Add(Arr* arr)
{
	int newSize = arr->length + 1;
	int* newArray = new int[newSize];
	for (int i = 0; i < newSize; i++)
	{
		newArray[i] = arr->array[i];
	}
	arr->array = newArray;
	arr->length = newSize;
	if (arr->capacity <= arr->length)
	{
		arr->capacity = arr->capacity * 2;
	}


}

void addEnd(Arr* arr)
{
	Add(arr);

	int valueToAdd;
	cout << "\n������� �������, ������� ������ �������� � ����� : ";
	cin >> valueToAdd;
	arr->array[arr->length - 1] = valueToAdd;
	showMassiv(arr);
}
void addBegin(Arr* arr)
{
	Add(arr);
	int value;
	cout << "������� �������, ������� ������ �������� � ������:" << endl;
	cin >> value;
	for (int i = arr->length; i > 0; i--)
	{
		arr->array[i] = arr->array[i - 1];
	}
	arr->array[0] = value;
	showMassiv(arr);
}

void afterIndex(Arr* arr)
{

	Add(arr);
	int needIndex;
	cout << "������� ������, ����� �������� ������ �������� �������" << endl;
	cin >> needIndex;
	int value;
	cout << "������ �������, ������� ������ �������� ����� �������:   " << needIndex << endl;
	cin >> value;

	for (int i = arr->length - 1; i >= needIndex; i--)
	{
		arr->array[i + 1] = arr->array[i];
	}
	arr->array[needIndex + 1] = value;
	cout << " ����������� ������: " << endl;
	for (int i = 0; i < arr->length; i++)
	{
		cout << arr->array[i] << endl;
	}
}

void bubbleSort(Arr* arr)
{
	int tmp = 0;
	for (int i = 0; i < arr->length; i++) {
		for (int j = (arr->length - 1); j >= (i + 1); j--) {
			if (arr->array[j] < arr->array[j - 1]) {
				tmp = arr->array[j];
				arr->array[j] = arr->array[j - 1];
				arr->array[j - 1] = tmp;
			}
		}
	}
	cout << "��������������� ������ " << endl;
	showMassiv(arr);
}

void linearSearch(Arr* arr)
{
	cout << "������� �����, ������� ������ ����� � �������:" << endl;
	int value;
	cin >> value;
	bool ExitFlag;

	for (int i = 0; i < arr->length; i++)
	{
		if (arr->array[i] == value)
		{
			ExitFlag = true;
			cout << "������ ������ ����� � ������� �����: " << i;
			break;
		}
		else
		{
			ExitFlag = false;
		}
	}
}

void BinarySearch(Arr* arr)     // binary search
{
	bubbleSort(arr);
	bool flag = false;
	int num;
	cout << "������� �����, ������� ������ �����: ";
	cin >> num;
	int top = 0;
	int end = arr->length - 1;
	while (top <= end)
	{
		int mid = (top + end) / 2;
		if (arr->array[mid] == num)
		{
			cout << "Index: " << mid << "\n";
			flag = true;
			break;
		}
		else if (arr->array[mid] > num)
		{
			end = mid - 1;
		}
		else
		{
			top = mid + 1;
		}
	}
	if (flag == false)
	{
		cout << "������� �������� ��� � ������� " << endl;
	}
}

void DelByIndex(Arr* arr)
{
	int pos;
	cout << "������� ������ ��������, ������� ������ �������: ";
	cin >> pos;
	for (int i = pos; i < arr->length; i++)
	{
		arr->array[i] = arr->array[i + 1];
	}

	arr->array[arr->length - 1] = 0;
	cout << "������ ����� �������� ��������:" << endl;
	for (int i = 0; i < arr->length - 1; i++)
	{
		cout << arr->array[i] << " ";
	}
	cout << endl;
	delete[] arr->array;

}
