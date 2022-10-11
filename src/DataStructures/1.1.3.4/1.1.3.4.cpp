#include<iostream>
#include<windows.h>
using namespace std;

void RoundToTens(int&);

int main()
{
	setlocale(LC_ALL, "RUS");

	//TODO: одна переменная +
	int number = 14;
	cout << "Исходное число ->   " << number << endl;
	RoundToTens(number);
	cout << "Число после округления->   " << number << endl;

	number = 191;
	cout << "Исходное число ->   " << number << endl;
	RoundToTens(number);
	cout << "Число после округления->   " << number << endl;

	number = 27;
	cout << "Исходное число ->   " << number << endl;
	RoundToTens(number);
	cout << "Число после округления->   " << number << endl;

	number = -5327;
	cout << "Исходное число ->   " << number << endl;
	RoundToTens(number);
	cout << "Число после округления->   " << number << endl;

	return 0;
}

void RoundToTens(int& value)
{
	//TODO: через switch+
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