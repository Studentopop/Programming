#include<iostream>
#include<windows.h>
using namespace std;

void RoundToTens(int&);

int main()
{
	setlocale(LC_ALL, "RUS");

	int number1 = 14;
	cout << "�������� ����� ->   " << number1 << endl;
	RoundToTens(number1);
	cout << "����� ����� ����������->   " << number1 << endl;

	int number2 = 191;
	cout << "�������� ����� ->   " << number2 << endl;
	RoundToTens(number2);
	cout << "����� ����� ����������->   " << number2 << endl;

	int number3 = 27;
	cout << "�������� ����� ->   " << number3 << endl;
	RoundToTens(number3);
	cout << "����� ����� ����������->   " << number3 << endl;

	int number4 = -5327;
	cout << "�������� ����� ->   " << number4 << endl;
	RoundToTens(number4);
	cout << "����� ����� ����������->   " << number4 << endl;

	return 0;
}

void RoundToTens(int& value)
{
	int a = value % 10;
	if (a >= 5)
	{
		value += (10 - a);
	}
	if (a < 5 and a> 0)
	{
		value -= a;
	}
	if (a < 0)
	{
		a = a * (-1);
		if (a >= 5)
		{
			value -= (10 - a);
		}
		if (a < 5 and a > 0)
		{
			value += a;
		}
	}
}