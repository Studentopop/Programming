#include<iostream>
using namespace std;

void main()
{
	setlocale(LC_ALL, "RUS");
	//TODO: ��������������+
	int size;
	cout << "������� ������������� ����� ";
	cin >> size;
	//TODO: � ���������+
	char* array = new char[size];
	for (int i = 0; i < size; i++)
	{
		cin >> array[i];
		cout << '\n';
	}
	for (int i = 0; i < size; i++)
	{
		cout << array[i];
		cout << "; ";
	}
	delete[] array;
}