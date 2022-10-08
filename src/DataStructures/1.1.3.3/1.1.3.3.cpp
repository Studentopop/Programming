#include<iostream>
#include<windows.h>
using namespace std;

int result;


double GetPower(double, int);
void DemoGetPower(double, int);

int main()
{
	setlocale(LC_ALL, "RUS");
	double base1, base2, base3;
	int exponent1, exponent2, exponent3;
	cout << "¬ведите значение base ";
	cin >> base1;
	cout << "¬ведите значение exponent ";
	cin >> exponent1;
	cout << '\n';
	DemoGetPower(base1, exponent1);
	cout << "¬ведите значение base ";
	cin >> base2;
	cout << "¬ведите значение exponent ";
	cin >> exponent2;
	cout << '\n';
	DemoGetPower(base2, exponent2);
	cout << "¬ведите значение base ";
	cin >> base3;
	cout << "¬ведите значение exponent ";
	cin >> exponent3;
	cout << '\n';
	DemoGetPower(base3, exponent3);
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