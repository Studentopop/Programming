#include <iostream>
#include "DynamicArray.h"

using namespace std;


void Menu()
{
	cout << "����� 1 ����� ������� ������������ ������\n";
	cout << "����� 2 ����� ���������� ������������ ������\n";
	cout << "����� 3 ����� �������� ����� ������� � ����� �������\n";
	cout << "����� 4 ����� �������� ����� ������� � ������ �������\n";
	cout << "����� 5 ����� ������������� ������\n";
	cout << "����� 6 ����� ������� ������� �� �������\n";
	cout << "����� 7 ��� ��������� ������\n";
	cout << "����� 8 ��� ��������� ������\n";
	cout << "����� 9 ����� �������� ������� � ������������ �������\n";
	cout << "����� 0 ��� ������ �� ���������\n";
}

int AskButton()
{
	int button;

	cout << "\n������� ������ ����� �� ���� \n";
	cin >> button;

	return button;
}
void Output(Arr* arr)
{
	if (arr->length > 0)
	{
		cout << "\n������:\n";
		for (int i = 0; i < arr->length; i++)
		{
			cout << arr->array[i] << " ";
		}
		cout << "\n";
	}
	else
	{
		cout << "������ ����\n";
	}
}

int main()
{
	setlocale(LC_CTYPE, "");
	Arr* tab = new Arr;

	bool workStatus = true;

	Menu();

	while (workStatus == true)
	{
		int button = AskButton();

		switch (button)
		{
		case 1:
		{
			initMassiv(tab);
			Output(tab);
			break;
		}
		case 2:
		{
			showMassiv(tab);
			Output(tab);
			break;
		}
		case 3:
		{
			addEnd(tab);
			Output(tab);
			break;
		}
		case 4:
		{
			addBegin(tab);
			Output(tab);
			break;
		}
		case 5:
		{
			bubbleSort(tab);
			Output(tab);
			break;
		}
		case 6:
		{
			DelByIndex(tab);
			Output(tab);
			break;
		}
		case 7:
		{
			linearSearch(tab);
			Output(tab);
			break;
		}
		case 8:
		{
			BinarySearch(tab);
			Output(tab);
			break;
		}
		case 9:
		{
			afterIndex(tab);
			Output(tab);
			break;
		}
		case 0:
		{
			workStatus = false;
			cout << "\n�� ����� �� ���������\n";
			break;
		}
		default:
		{
			cout << "\n��������� ���� ������ �� ����������\n";
			cout << "�� ������ ������������ ������ ������������ ������ �� ����\n";
			Menu();
			break;
		}
		}
	}
}