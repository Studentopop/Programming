#include <iostream>
#include "DynamicArray.h"

using namespace std;


void Menu()
{
	cout << "Нажми 1 чтобы создать динамический массив\n";
	cout << "Нажми 2 чтобы отобразить динамический массив\n";
	cout << "Нажми 3 чтобы добавить новый элемент в конец массива\n";
	cout << "Нажми 4 чтобы добавить новый элемент в начало массива\n";
	cout << "Нажми 5 чтобы отсортировать массив\n";
	cout << "Нажми 6 чтобы удалить элемент по индексу\n";
	cout << "Нажми 7 для линейного поиска\n";
	cout << "Нажми 8 для двоичного поиска\n";
	cout << "Нажми 9 чтобы добавить элемент в определенную позицию\n";
	cout << "Нажми 0 для выхода из программы\n";
}

int AskButton()
{
	int button;

	cout << "\nВведите нужное число из меню \n";
	cin >> button;

	return button;
}
void Output(Arr* arr)
{
	if (arr->length > 0)
	{
		cout << "\nМассив:\n";
		for (int i = 0; i < arr->length; i++)
		{
			cout << arr->array[i] << " ";
		}
		cout << "\n";
	}
	else
	{
		cout << "Массив пуст\n";
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
			cout << "\nВы вышли из программы\n";
			break;
		}
		default:
		{
			cout << "\nВыбранная вами кнопка не существует\n";
			cout << "Вы можете использовать только предлагаемые кнопки из меню\n";
			Menu();
			break;
		}
		}
	}
}