#include<iostream>
#include<windows.h>
using namespace std;

int result;


double GetPower(double, int);
void DemoGetPower(double, int);

int main()
{
	setlocale(LC_ALL, "RUS");
	//TODO: использовать одну переменную+
	double base;
	int exponent;
	cout << "¬ведите значение base ";
	cin >> base;
	cout << "¬ведите значение exponent ";
	cin >> exponent;
	cout << '\n';
	DemoGetPower(base, exponent);
	cout << "¬ведите значение base ";
	cin >> base;
	cout << "¬ведите значение exponent ";
	cin >> exponent;
	cout << '\n';
	DemoGetPower(base, exponent);
	cout << "¬ведите значение base ";
	cin >> base;
	cout << "¬ведите значение exponent ";
	cin >> exponent;
	cout << '\n';
	DemoGetPower(base, exponent);
	return 0;
}

double GetPower(double base, int exponent)
{
	result = pow(base, exponent);
	return result;
}
void DemoGetPower(double base, int exponent)
{
	cout << base << '^' << exponent << ":= " << GetPower(base, exponent) << endl;
}