#include<iostream>
#include<windows.h>
using namespace std;

void RoundToTens(int&);

int main()
{
	setlocale(LC_ALL, "RUS");

	int number1 = 14;
	cout << "Исходнок число ->   " << number1 << endl;
	RoundToTens(number1);
	cout << "Число после округления->   " << number1 << endl;

	int number2 = 191;
	cout << "Исходнок число ->   " << number2 << endl;
	RoundToTens(number2);
	cout << "Число после округления->   " << number2 << endl;

	int number3 = 27;
	cout << "Исходнок число ->   " << number3 << endl;
	RoundToTens(number3);
	cout << "Число после округления->   " << number3 << endl;

	int number4 = -5327;
	cout << "Исходнок число ->   " << number4 << endl;
	RoundToTens(number4);
	cout << "Число после округления->   " << number4 << endl;

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